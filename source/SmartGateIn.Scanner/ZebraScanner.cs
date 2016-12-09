using System;
using System.Linq;
using System.Reactive.Linq;

using SmartGateIn.Contracts.Scanner;

namespace SmartGateIn.Scanner
{
    internal class ZebraScanner : IScanPackingSlip, IScanSummarySheet
    {
        public IObservable<ValidPackingSlipBarcodes> ScanBarcodesFromPackingSlip()
        {
            var tick = Observable.Interval(TimeSpan.FromMilliseconds(350)).Take(ValidPackingSlipBarcodes.AtTheMost());

            return Enumerable
                .Range(15999, 16059)
                .ToObservable()
                .Zip(tick, (e, _) => e)
                .Do(code => Console.WriteLine($"Barcode scanned: {code}"))
                .Buffer(ValidPackingSlipBarcodes.AtTheMost())
                .Select(x => new ValidPackingSlipBarcodes(x.Select(i => i.ToString())))
                .Publish()
                .RefCount();
        }

        public IObservable<string> ScanBarcodeFromSummarySheet()
        {
            var scans = new[] { "TRIPID1234" };
            var tick = Observable.Interval(TimeSpan.FromSeconds(1)).Take(scans.Length);

            return scans
                .ToObservable()
                .Zip(tick, (e, _) => e)
                .Do(code => Console.WriteLine($"TripId scanned: {code}"))
                .Publish()
                .RefCount();
        }
    }
}
