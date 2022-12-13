﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - By Jade A";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 0,
                FirstName = "Clark",
                LastName = "Kent",
            };
            return View(dayTimeInstructor);
        }         
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Helen",
                    LastName = "Keller",
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Ben",
                    LastName = "Franklin",
                },
                new Instructor
                {
                    Id=3,
                    FirstName= "Niel",
                    LastName= "DeGrasse Tyson",
                },
            };
            return View(instructors);
        }
    }
}