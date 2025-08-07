using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ShowAll()
        {
            StudentBl studentBl = new StudentBl();
            List<Student> studentListModel =studentBl.GetAll();
            return View("ShowAll", studentListModel);

        }
    }
}
