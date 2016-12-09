using System.Collections.Generic;
using System.Linq;

namespace SmartGateIn.Contracts.Scanner
{
    public class ValidPackingSlipBarcodes
    {
        private readonly IEnumerable<string> _numbers;

        public ValidPackingSlipBarcodes(IEnumerable<string> numbers)
        {
            _numbers = numbers;
        }

        public string Number1 => _numbers.First();

        public string Number2 => _numbers.Skip(1).First();

        public string Number3 => _numbers.Count() == AtTheMost()
                                     ? _numbers.Last()
                                     : string.Empty;

        public bool MaximumReached()
        {
            return !string.IsNullOrWhiteSpace(Number3);
        }

        public static int AtTheMost()
        {
            return 3;
        }

        public static int NotLessThan()
        {
            return 2;
        }
    }
}
