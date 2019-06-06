using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ProjectVehicles.Controllers
{
    public class CarsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public CarsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

            
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}


        public async Task<IActionResult> Index()
        {

           //IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);

           // Logica.BL.Cars cars = new Logica.BL.Cars();
           // var listCars = cars.GetTbCars(user.Id).FirstOrDefault();


            //Logica.BL.Projects projects = new Logica.BL.Projects();


            //var result = await _userManager.IsInRoleAsync(user, "Admin") ? projects.GetPojects(null, tenant.Id) : projects.GetPojects(null, tenant.Id, user.Id);

            //var listProjects = result.Select(x => new Logica.Models.ViewModel.CarsIndexViewModel
            //{
            //    Id = x.Id,
            //    Title = x.Title,
            //    Details = x.Details,
            //    CreatedAt = x.CreateAt,
            //    ExpectedCompletionDate = x.ExpectedCompletationDate,
            //    UpdateAt = x.UpdateAt

            //});

            //listProjects = tenant.Plan.Equals("premium") ?
            //                listProjects :
            //                listProjects.Take(1).ToList();

            return View();


        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Logica.Models.BindingModel.CarsCreateBindingModel model)
        {

            if (ModelState.IsValid)
            {
                //IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);

                //Logica.BL.Cars cars = new Logica.BL.Cars();
                //var car = cars.GetTbCars(user.Id).FirstOrDefault();

                //Logica.BL.Cars cars = new Logica.BL.Cars();
                //cars.CreateCars(model.Name,
                //    model.Model,
                //    model.ExpirationDateSt,
                //    car.CarId;

                return RedirectToAction("Index");
            }

            //return View();
            return View(model);
        }
    }
}