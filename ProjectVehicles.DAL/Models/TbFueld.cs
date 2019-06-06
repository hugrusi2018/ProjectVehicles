using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbFueld
    {
        public TbFueld()
        {
            TbCars = new HashSet<TbCars>();
        }

        public int FuelId { get; set; }
        public string FuelName { get; set; }

        public ICollection<TbCars> TbCars { get; set; }
    }
}
