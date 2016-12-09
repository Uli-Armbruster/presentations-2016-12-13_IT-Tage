using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence
{
    internal class PartFamiliesRepository : IPartFamilyRepository
    {
        public IEnumerable<PartFamily> GetPartFamilyFromASN(ASN asn)
        {
            for (var i = 0; i <= 71; i++)
            {
                yield return new PartFamily
                {
                    ContentCode = $"{i}ContentCode",
                    ContentCodeDescription = $"{i}Desc",
                    SupplierNumber = i.ToString(),
                    SupplierName = $"{i}supplier"
                };
            }
        }
    }
}
