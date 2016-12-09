using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts.Entities;
using SmartGateIn.Persistence.Contracts.Filter;

namespace SmartGateIn.Persistence.Contracts
{
    public interface IAvailableTrailersRepository
    {
        IEnumerable<AvailableTrailer> FilterBy(AvailableTrailerFilter filter);
    }
}
