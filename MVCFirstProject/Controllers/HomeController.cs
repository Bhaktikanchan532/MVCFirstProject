using Microsoft.AspNetCore.Mvc;
using MVCFirstProject.Models;
using System.Diagnostics;

namespace MVCFirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "this is my first MVC application";
            List<string> CourseList = new List<string>()
            {
                "C#","SQL","MVC","ANGULAR","JAVA","REACT"
            };
            ViewData["list"] = CourseList;
            ViewBag.List = CourseList;
            List<string> ColorList = new List<string>()
            {
                "Red","Blue","Black","Yellow","Pink","Purple"
            };
            ViewData["lt"] = ColorList;
            ViewBag.Lt = ColorList;

            List<Student> StudentList = new List<Student>()
            {
                new Student{Name="Riya",City="Pune",Percentage=89},
                new Student{Name="Raj",City="Mumbai",Percentage=80},
                new Student{Name="Rohan",City="Satara",Percentage=85},
                new Student{Name="Pooja",City="Kolhapur",Percentage=79},

            };
            ViewData["studlist"] = StudentList;
            //  ViewBag["slist"] = StudentList;

            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee{Name="Riya",City="Pune",Salary=20000},
                new Employee{Name="Raj",City="Mumbai",Salary=15000},
                new Employee{Name="Rohan",City="Satara",Salary=8500},
                new Employee{Name="Pooja",City="Kolhapur",Salary=25000},

            };
            ViewData["emplist"] = EmployeeList;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}