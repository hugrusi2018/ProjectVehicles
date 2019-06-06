using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbServicesType
    {
        public TbServicesType()
        {
            TbCars = new HashSet<TbCars>();
        }

        public int SerId { get; set; }
        public string SerName { get; set; }

        public ICollection<TbCars> TbCars { get; set; }
    }
}
