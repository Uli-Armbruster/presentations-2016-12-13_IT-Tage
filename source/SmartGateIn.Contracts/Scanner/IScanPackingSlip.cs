using System;

namespace SmartGateIn.Contracts.Scanner
{
    public interface IScanPackingSlip
    {
        IObservable<ValidPackingSlipBarcodes> ScanBarcodesFromPackingSlip();
    }
}
