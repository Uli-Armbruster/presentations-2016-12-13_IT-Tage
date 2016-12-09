using SmartGateIn.Contracts.Scanner;
using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence.Contracts
{
    // ReSharper disable once InconsistentNaming
    public interface IASNRepository
    {
        ASN FindAsnWithPackingSlipDetails(ValidPackingSlipBarcodes barcodes);
    }
}
