using System.Collections.Generic;

using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence.Contracts
{
    public interface IPartFamilyRepository
    {
        // ReSharper disable once InconsistentNaming
        IEnumerable<PartFamily> GetPartFamilyFromASN(ASN asn);
    }
}