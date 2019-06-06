using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectVehicles.Logica.Models.BindingModel
{
    public class CarsCreateBindingModel
    {

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public int Model { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public string  Displacement { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public  int Capacity  { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public DateTime ExpirationDateSoat { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public DateTime ExpirationDateRtm { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public DateTime ExpirationDateSt { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public int Kilometers { get; set; }

        [Required(ErrorMessage = "The field Title is requiered")]
        [Display(Name = "Name")]
        public DateTime CreatedAt { get; set; }
    }


    public class CarsEditBindingModel
    {

        public string Name { get; set; }

        public int Model { get; set; }

        public string Displacement { get; set; }

        public int Capacity { get; set; }

        public DateTime ExpirationDateSoat { get; set; }

        public DateTime ExpirationDateRtm { get; set; }

        public DateTime ExpirationDateSt { get; set; }

        public int Kilometers { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
