using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbThirdPartiesTbCars
    {
        public int Id { get; set; }
        public int? CarId { get; set; }
        public int? ThirdId { get; set; }

        public TbCars Car { get; set; }
        public TbThirdParties Third { get; set; }
    }
}
