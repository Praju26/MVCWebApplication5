using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication5.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
                Students student = new Students()
                {
                    StudentId = 2,
                    Name = "Max Payne",
                    TotalMarks = 450.5
                };
                return View(student);//pass the object student to the view  
            
        }
    }
}
