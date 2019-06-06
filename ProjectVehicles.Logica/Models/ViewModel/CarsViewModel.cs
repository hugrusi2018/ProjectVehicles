using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectVehicles.Logica.Models.ViewModel
{
    public class CarsIndexViewModel
    {
        [Display(Name = "Id")]
        public int CarId { get; set; }

        [Display(Name = "Name")]
        public string CarName { get; set; }

        [Display(Name = "Model")]
        public int CarModel { get; set; }

        [Display(Name = "Displacement")]
        public string CarDisplacement { get; set; }

        [Display(Name = "FuelId")]
        public int FuelId { get; set; }

        [Display(Name = "Id Capacity")]
        public int CarCapacity { get; set; }

        [Display(Name = "SerId")]
        public int SerId { get; set; }

        [Display(Name = "ExpirationDateSoat")]
        public DateTime CarExpirationDateSoat { get; set; }

        [Display(Name = "ExpirationDateRtm")]
        public DateTime CarExpirationDateRtm { get; set; }

        [Display(Name = "ExpirationDateSt")]
        public DateTime CarExpirationDateSt { get; set; }

        [Display(Name = "Kilometers")]
        public int CarKilometers { get; set; }

        [Display(Name = "StaId")]
        public int StaId { get; set; }

        [Display(Name = "CreatedAt")]
        public DateTime CarCreatedAt { get; set; }
    }
}
