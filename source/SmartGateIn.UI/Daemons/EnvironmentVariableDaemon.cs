using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

using Castle.Core;

using SmartGateIn.Contracts;

namespace SmartGateIn.UI.Daemons
{
    internal class EnvironmentVariableDaemon : IStartable
    {
        private readonly IMessageBroker _broker;
        private IDisposable _subscription;
        private bool _lastState;

        public EnvironmentVariableDaemon(IMessageBroker broker)
        {
            _broker = broker;
        }

        public void Start()
        {
            var subject = Observable.Interval(TimeSpan.FromSeconds(2), new NewThreadScheduler());
            _subscription = subject.Do(_ => EvaluateEnvironmentVariable()).Subscribe();
        }

        public void Stop()
        {
            _subscription?.Dispose();
        }

        private void EvaluateEnvironmentVariable()
        {
            var state = GetState();

            if (!state.Item1)
            {
                return;
            }

            object systemEvent;
            if (state.Item2)
            {
                systemEvent = new LockSystemEvent
                {
                    Headline = "Administration Notification",
                    Message = "System was locked due to server problems"
                };
            }
            else
            {
                systemEvent = new UnlockSystemEvent();
            }

            _broker.Send(systemEvent);
        }
        
        /// <summary>
        ///     First bool means state changed
        ///     Last bool contains the new state
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, bool> GetState()
        {
            var env = Environment.GetEnvironmentVariable("env_locksystem", EnvironmentVariableTarget.User);
            var newState = !string.IsNullOrWhiteSpace(env);

            if (newState == _lastState)
            {
                return Tuple.Create(false, _lastState);
            }

            _lastState = newState;
            return Tuple.Create(true, newState);
        }
    }
}
