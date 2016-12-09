using System;

namespace SmartGateIn.Contracts.Scanner
{
    public interface IScanSummarySheet
    {
        IObservable<string> ScanBarcodeFromSummarySheet();
    }
}
