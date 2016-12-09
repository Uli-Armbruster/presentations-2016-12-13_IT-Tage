using SmartGateIn.Contracts.Common;
using SmartGateIn.Contracts.Common.Returnables;
using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.UI
{
    internal class CheckInContext
    {
        public CheckInContext(Config config)
        {
            ConfiguredProcessType = config.CheckInProcessType;
            TerminalId = config.MachineName;
        }

        internal string TripId { get; set; }

        internal string TerminalId { get; }

        internal string SuperGroup { private get; set; }

        // ReSharper disable once InconsistentNaming
        internal ASN ASN { get; set; }

        internal CheckInProcessType ConfiguredProcessType { get; private set; }

        internal CheckInProcessType SelectedProcessType { get; set; }

        internal PartFamily PartFamily { private get; set; }

        internal AvailableTrailer Trailer { private get; set; }

        internal Confirmation Confirmation
        {
            get
            {
                var confirmation = new Confirmation
                {
                    Ydid = ASN.Ydid,
                    SupplierNumber = ASN.SupplierNumber,
                    TrailerNumber = ASN.TrailerNumber,
                    DeliveryNoteNumber = ASN.DeliveryNoteNumber,
                    ReturnProcessType = SelectedProcessType.Literal,
                    ContentCode = PartFamily.ContentCode,
                    TripId = TripId,
                    TerminalId = TerminalId
                };

                // ReSharper disable once InvertIf
                if (Trailer != null)
                {
                    confirmation.ReturnContentCode = Trailer.ContentCode;
                    confirmation.ReturnSupplierNumber = Trailer.SupplierNumber;
                    confirmation.ReturnSuperGroup = SuperGroup;
                }

                return confirmation;
            }
        }
    }
}
