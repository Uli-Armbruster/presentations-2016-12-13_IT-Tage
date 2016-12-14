﻿using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using SmartGateIn.Contracts;

namespace SmartGateIn.UI
{
    /// <summary>
    ///     Minimod.RxMessageBroker, Version 0.0.1
    ///     <para>An Event-/Message broker by using the Rx.</para>
    /// </summary>
    /// <remarks>
    ///     Licensed under the Apache License, Version 2.0; you may not use this file except in compliance with the License.
    ///     http://www.apache.org/licenses/LICENSE-2.0
    /// </remarks>
    internal class RxMessageBrokerMinimod : IMessageBroker
    {
        private static RxMessageBrokerMinimod DefaultInstance;
        private readonly Subject<object> _stream = new Subject<object>();

        public static RxMessageBrokerMinimod Default
            => DefaultInstance ?? (DefaultInstance = new RxMessageBrokerMinimod());

        public static void OverrideDefault(RxMessageBrokerMinimod newMessenger)
        {
            DefaultInstance = newMessenger;
        }

        public static void Reset()
        {
            DefaultInstance = null;
        }

        public IObservable<object> Stream => _stream;

        public IDisposable Register<T>(Action<T> action)
        {
            return _stream
                .OfType<T>()
                .Subscribe(action);
        }

        public IDisposable Register<T>(Action<T> action, IScheduler scheduler)
        {
            return _stream
                .OfType<T>()
                .ObserveOn(scheduler)
                .Subscribe(action);
        }

        public IDisposable Register<T>(Action<T> action, Func<T, bool> predicate)
        {
            return Register(action, predicate, Scheduler.CurrentThread);
        }

        public IDisposable Register<T>(Action<T> action, Func<T, bool> predicate, IScheduler scheduler)
        {
            return _stream
                .OfType<T>()
                .ObserveOn(scheduler)
                .Where(predicate)
                .Subscribe(action);
        }

        public void Bridge<T>(Action<T> fromEvent)
        {
            Observable
                .FromEvent<T>(a => fromEvent += a, a => fromEvent -= a)
                .Select(x => (object) x)
                .Merge(_stream);
        }

        public IDisposable Register<T1, T2>(Action<Tuple<T1, T2>> action)
        {
            return Register(action, Scheduler.CurrentThread);
        }

        public IDisposable Register<T1, T2>(Action<Tuple<T1, T2>> action, IScheduler scheduler)
        {
            return Register<T1, T2, Tuple<T1, T2>>(action, (x, y) => new Tuple<T1, T2>(x, y), scheduler);
        }

        public IDisposable Register<T1, T2, TResult>(Action<TResult> action, Func<T1, T2, TResult> selector)
        {
            return Register(action, selector, Scheduler.CurrentThread);
        }

        public IDisposable Register<T1, T2, TResult>(Action<TResult> action,
                                                     Func<T1, T2, TResult> selector,
                                                     IScheduler scheduler)
        {
            var left = _stream.OfType<T1>();
            var right = _stream.OfType<T2>();
            var match = left
                .And(right)
                .Then(selector);
            return Observable
                .When(match)
                .ObserveOn(scheduler)
                .Subscribe(action);
        }

        public void Send<T>(T message)
        {
            _stream
                .OnNext(message);
        }
    }
}
