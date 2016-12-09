using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SmartGateIn.Contracts.Common.Returnables
{
    public abstract class CheckInProcessType
    {
        public static readonly CheckInProcessType OtherReturnables = new OtherReturnables();

        public static readonly CheckInProcessType Empty = new EmptyReturnables();

        public static readonly CheckInProcessType DefaultReturnables = new DefaultReturnables();

        public static readonly CheckInProcessType None = new NoneReturnables();

        public int Id { get; }
        public string ActionText { get; private set; }
        public string Literal { get; private set; }
        public string Description { get; protected set; }
        public string GateInNotPossible { get; protected set; }
        private bool Configurable { get; }
        public string ProcessErrorMessage { get; protected set; }
        public string SystemErrorMessage { get; protected set; }

        protected CheckInProcessType(int id, string actionText, string literal, bool configurable)
        {
            Id = id;
            ActionText = actionText;
            Literal = literal;
            Configurable = configurable;
        }

        private static IEnumerable<CheckInProcessType> All()
        {
            var allFields = typeof(CheckInProcessType)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f =>
                           f.FieldType == typeof(CheckInProcessType)
                           && f.IsInitOnly);

            return allFields
                .Select(f => (CheckInProcessType) f.GetValue(null)).ToList();
        }

        public static IEnumerable<CheckInProcessType> Configurables()
        {
            return All().Where(type => type.Configurable);
        }

        internal static CheckInProcessType FromId(int id)
        {
            var type = All().SingleOrDefault(t => t.Id == id);

            if (type != null)
            {
                return type;
            }

            throw new ArgumentOutOfRangeException($"There is no process type with id '{id}'");
        }
    }
}
