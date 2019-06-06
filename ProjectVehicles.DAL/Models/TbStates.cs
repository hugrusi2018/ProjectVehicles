using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbStates
    {
        public TbStates()
        {
            TbBinnacles = new HashSet<TbBinnacles>();
            TbCars = new HashSet<TbCars>();
        }

        public int StaId { get; set; }
        public string StaName { get; set; }

        public ICollection<TbBinnacles> TbBinnacles { get; set; }
        public ICollection<TbCars> TbCars { get; set; }
    }
}
