using SmartGateIn.Contracts.Scanner;
using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence
{
    // ReSharper disable once InconsistentNaming
    internal class ASNRepository : IASNRepository
    {
        public ASN FindAsnWithPackingSlipDetails(ValidPackingSlipBarcodes barcodes)
        {
            return new ASN
            {
                DeliveryNoteNumber = "180002819",
                TrailerNumber = "TRASPABPR2",
                SupplierNumber = "77348710"
            };
        }
    }
}
