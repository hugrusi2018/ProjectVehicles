using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectVehicles.Logica.BL
{
    public class Cars
    {
        /// <summary>
        /// GET CARS BY USER 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Models.DB.TbCars> GetTbCars(string userId)
        {
            DAL.Models.BDVehiclesContext _context = new DAL.Models.BDVehiclesContext();

            var listCars = (from _Tbcars in _context.TbCars
                           join _aspNetUsers in _context.AspNetUsers on _Tbcars.CarId equals _aspNetUsers.CardId
                           where _aspNetUsers.Id.Equals(userId)
                           select new Models.DB.TbCars
                           {
                               CarId = _Tbcars.CarId,
                               CarName = _Tbcars.CarName,
                               CarModel = _Tbcars.CarModel,
                               CarDisplacement = _Tbcars.CarDisplacement,
                               CarCapacity = _Tbcars.CarCapacity,
                               CarExpirationDateSoat = _Tbcars.CarExpirationDateSoat,
                               CarExpirationDateRtm = _Tbcars.CarExpirationDateRtm,
                               CarExpirationDateSt = _Tbcars.CarExpirationDateSt,
                               CarKilometers = _Tbcars.CarKilometers,
                               CarCreatedAt = _Tbcars.CarCreatedAt
                           }).ToList();

            return listCars;
        }

        public void CreateCars(string Name,
            string Model)
        {

        }
    }
}
