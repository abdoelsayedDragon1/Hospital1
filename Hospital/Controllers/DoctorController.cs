using Hospital.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorController : Controller
    {

        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
           var Doc = dbContext.Doctors.ToList();
            return View(model: Doc);
        }

        public IActionResult view(int id)
        {
            var Doctor = dbContext.Doctors.Where(x => x.Id == id).FirstOrDefault();
            return View(Doctor);
        }
    }
}
