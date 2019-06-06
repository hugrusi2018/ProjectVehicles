using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbThirdParties
    {
        public TbThirdParties()
        {
            TbBinnacles = new HashSet<TbBinnacles>();
            TbThirdPartiesTbCars = new HashSet<TbThirdPartiesTbCars>();
        }

        public int ThirdId { get; set; }
        public string ThirdName { get; set; }
        public string ThirdAddress { get; set; }
        public string ThirdTelephone { get; set; }
        public DateTime ThirdCreatedAt { get; set; }
        public string ThirdObservation { get; set; }
        public int CityId { get; set; }
        public int ThirdTypeId { get; set; }

        public TbCities City { get; set; }
        public TbThirdType ThirdType { get; set; }
        public ICollection<TbBinnacles> TbBinnacles { get; set; }
        public ICollection<TbThirdPartiesTbCars> TbThirdPartiesTbCars { get; set; }
    }
}
