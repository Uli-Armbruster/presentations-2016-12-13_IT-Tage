using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Filter;

namespace SmartGateIn.Persistence
{
    internal class AvailableSuperGroupsRepository : IAvailableSuperGroups
    {
        public IEnumerable<string> FilterBy(AvailableSuperGroupFilter filter)
        {
            yield return "HALL50";
            yield return "HALL52";
        }
    }
}
