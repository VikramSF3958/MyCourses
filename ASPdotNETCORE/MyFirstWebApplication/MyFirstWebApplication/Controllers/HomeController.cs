using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models;
using MyFirstWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeInterface _employeeRepo;
        public HomeController(IEmployeeInterface employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        [Route("")]
        [Route("vky/")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Employee employee)
        {
            Employee newEmployee = _employeeRepo.Add(employee);
            return RedirectToAction("details", new { id = newEmployee.id});
        }

        [HttpGet]
        public ViewResult Update()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Update(Employee employee)
        {
            Employee UpdatedEmployee = _employeeRepo.Update(employee);
            return RedirectToAction("details", new { id = UpdatedEmployee.id });
        }
        public ViewResult ShowAllEmp()
        {   

            IEnumerable<Employee> employees = _employeeRepo.GetAllEmployees();
            return View(employees);
        }

        public JsonResult Details(int id)
        {   
            return Json(_employeeRepo.GetEmployee(id));
        }

        public ViewResult ShowDetails()
        {
            Employee model = _employeeRepo.GetEmployee(11);
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").Equals("Development"))
            {
                return View(model);
            }
            return View("Testing",model);
        }

        public ViewResult EmpDetails()
        {
            //Employee model = _employeeRepo.GetEmployee(11);
            //ViewBag.Employee = model;
            //ViewBag.PageTitle = "Showing One Employee Details";

            HomeEmpDetailsViewModels homeEmpDetailsViewModels = new HomeEmpDetailsViewModels()
            {
                Employee = _employeeRepo.GetEmployee(11),
                PageTitle = "Employee Details"
            };
            return View(homeEmpDetailsViewModels);
        }
      
        public ActionResult ToGoogle()
        {
            return Redirect("https://www.google.com");
        }

        public ActionResult Razorpg()
        {
            return View();
        }


    }
}
