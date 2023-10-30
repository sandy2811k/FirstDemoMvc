using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemoMvc.Controllers
{
    public class PersonController : Controller
    {
        private object form;

        public IActionResult PersonalDetails()
        {
            List <string> cities=new List<string>()
            {
                "Pune","Mumbai","Delhi","Solapur","Kolhapur"
            };
            ViewData["cities"] = new SelectList(cities);

            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cities"];
            ViewBag.Hobbies = form["Hobbies"];
            return View("DisplayDetails");
        }
    }
}
