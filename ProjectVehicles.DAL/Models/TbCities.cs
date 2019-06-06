using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbCities
    {
        public TbCities()
        {
            TbThirdParties = new HashSet<TbThirdParties>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public ICollection<TbThirdParties> TbThirdParties { get; set; }
    }
}
