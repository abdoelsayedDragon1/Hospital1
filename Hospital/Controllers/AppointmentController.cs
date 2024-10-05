using Hospital.Data;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
           var App= dbContext.Appointments.ToList();
            return View(model:App);
        }

        public IActionResult Save(Appointment appointment)
        {
            if (ModelState.IsValid) 
            {
                dbContext.Appointments.Add(appointment);
                dbContext.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(appointment);



    }   }
};
