using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbThirdType
    {
        public TbThirdType()
        {
            TbThirdParties = new HashSet<TbThirdParties>();
        }

        public int ThirdTypeId { get; set; }
        public string ThirdTypeName { get; set; }

        public ICollection<TbThirdParties> TbThirdParties { get; set; }
    }
}
