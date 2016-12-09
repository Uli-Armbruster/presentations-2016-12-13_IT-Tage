using System.Collections.Generic;
using System.Linq;

namespace SmartGateIn.Persistence.Contracts.Entities
{
    internal class Context
    {
        private IList<ClientState> _clientStateSet;
        private IList<ASN> _asnSet;
        private IList<AvailableTrailer> _availableTrailerSet;
        private IList<PartFamily> _partFamilySet;
        private IList<AvailableTrailer> _availableTrailerSuperGroupSet;
        private IList<ServerState> _serverStateSet;

        public IEnumerable<ASN> ASNSet
        {
            get
            {
                return _asnSet;
            }
            set
            {
                _asnSet = value.ToList();
            }
        }

        public IEnumerable<AvailableTrailer> AvailableTrailerSet
        {
            get
            {
                return _availableTrailerSet;
            }
            set
            {
                _availableTrailerSet = value.ToList();
            }
        }

        public IEnumerable<ClientState> ClientStateSet
        {
            get
            {
                return _clientStateSet;
            }
            set
            {
                _clientStateSet = value.ToList();
            }
        }

        public IEnumerable<PartFamily> PartFamilySet
        {
            get
            {
                return _partFamilySet;
            }
            set
            {
                _partFamilySet = value.ToList();
            }
        }

        private IList<Confirmation> ConfirmationSet { get; set; }

        public IEnumerable<AvailableTrailer> AvailableTrailerSuperGroupSet
        {
            get
            {
                return _availableTrailerSuperGroupSet;
            }
            set
            {
                _availableTrailerSuperGroupSet = value.ToList();
            }
        }

        public IEnumerable<ServerState> ServerStateSet
        {
            get
            {
                return _serverStateSet;
            }
            set
            {
                _serverStateSet = value.ToList();
            }
        }

        public Context()
        {
            CreateAsnSet();
            CreatePartFamilySet();
        }

        private void CreatePartFamilySet()
        {
            _partFamilySet = new List<PartFamily>();

            for (var i = 0; i <= 71; i++)
            {
                _partFamilySet.Add(new PartFamily
                {
                    ContentCode = $"{i}ContentCode",
                    ContentCodeDescription = $"{i}Desc",
                    SupplierNumber = i.ToString(),
                    SupplierName = $"{i}supplier",
                    Ydid = "fixed"
                });
            }
        }

        private void CreateAsnSet()
        {
            _asnSet = new List<ASN>();

            var asn = new ASN
            {
                DeliveryNoteNumber = "15999",
                TrailerNumber = "16000",
                SupplierNumber = "16001",
                Ydid = "fixed"
            };
            _asnSet.Add(asn);

            asn = new ASN
            {
                DeliveryNoteNumber = "180002819",
                TrailerNumber = "TRASPABPR2",
                SupplierNumber = "77348710"
            };

            _asnSet.Add(asn);
        }

        public void SaveChanges()
        {
        }

        public void AddToClientStateSet(ClientState appState)
        {
            _clientStateSet.Add(appState);
        }

        public void AddToConfirmationSet(Confirmation confirmation)
        {
            ConfirmationSet.Add(confirmation);
        }
    }
}
