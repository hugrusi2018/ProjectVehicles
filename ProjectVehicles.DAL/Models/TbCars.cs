using System;
using System.Collections.Generic;

namespace ProjectVehicles.DAL.Models
{
    public partial class TbCars
    {
        public TbCars()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
            TbBinnacles = new HashSet<TbBinnacles>();
            TbThirdPartiesTbCars = new HashSet<TbThirdPartiesTbCars>();
        }

        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CarModel { get; set; }
        public string CarDisplacement { get; set; }
        public int FuelId { get; set; }
        public int CarCapacity { get; set; }
        public int SerId { get; set; }
        public DateTime CarExpirationDateSoat { get; set; }
        public DateTime CarExpirationDateRtm { get; set; }
        public DateTime CarExpirationDateSt { get; set; }
        public int CarKilometers { get; set; }
        public int StaId { get; set; }
        public DateTime CarCreatedAt { get; set; }

        public TbFueld Fuel { get; set; }
        public TbServicesType Ser { get; set; }
        public TbStates Sta { get; set; }
        public ICollection<AspNetUsers> AspNetUsers { get; set; }
        public ICollection<TbBinnacles> TbBinnacles { get; set; }
        public ICollection<TbThirdPartiesTbCars> TbThirdPartiesTbCars { get; set; }
    }
}
