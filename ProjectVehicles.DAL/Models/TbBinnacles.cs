using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbBinnacles
    {
        public int BinId { get; set; }
        public int? CarId { get; set; }
        public int? StaId { get; set; }
        public int? ThirdId { get; set; }

        public TbCars Car { get; set; }
        public TbStates Sta { get; set; }
        public TbThirdParties Third { get; set; }
    }
}
