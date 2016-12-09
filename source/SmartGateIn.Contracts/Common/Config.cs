using System;

using SmartGateIn.Contracts.Common.Returnables;

namespace SmartGateIn.Contracts.Common
{
    public class Config
    {
        private string _machineName;
        public string User { get; set; }

        public string Password { get; set; }

        public string BackendUri { get; set; }

        public string GateUri { get; set; }

        public string GateUser { get; set; }

        public string GatePassword { get; set; }

        public int CheckInProcessTypeId { get; set; }

        public CheckInProcessType CheckInProcessType => CheckInProcessType.FromId(CheckInProcessTypeId);

        public string MachineName
        {
            get
            {
                return string.IsNullOrWhiteSpace(_machineName) ? Environment.MachineName : _machineName;
            }
            set
            {
                _machineName = value;
            }
        }
    }
}
