using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts.Filter;

namespace SmartGateIn.Persistence.Contracts
{
    public interface IAvailableSuperGroups
    {
        IEnumerable<string> FilterBy(AvailableSuperGroupFilter filter);
    }
}
