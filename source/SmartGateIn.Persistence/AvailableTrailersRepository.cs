using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;
using SmartGateIn.Persistence.Contracts.Filter;

namespace SmartGateIn.Persistence
{
    internal class AvailableTrailersRepository : IAvailableTrailersRepository
    {
        public IEnumerable<AvailableTrailer> FilterBy(AvailableTrailerFilter filter)
        {
            for (var i = 0; i <= 61; i++)
            {
                yield return new AvailableTrailer
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
