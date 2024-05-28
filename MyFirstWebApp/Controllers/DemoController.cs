using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewData["Name"] = "陳小強";
            ViewBag.Name = "陳小強";
            TempData["Name"] = "陳小強";
            return RedirectToAction("ShowTempData");
        }

        public ActionResult ShowTempData()
        {
            return View();
        }

        public ActionResult ShowMembers()
        {
            var memberA = new Member() { Id = 1, Name = "Alex", Age = 12 };
            var memberB = new Member() { Id = 2, Name = "Ben", Age = 34 };
            var memberC = new Member() { Id = 3, Name = "Carol", Age = 56 };
            var memberList = new List<Member>() { memberA, memberB, memberC};
            ViewData["Members"] = memberList;
            ViewBag.Members = memberList;
            return View();
        }

        // GET: Demo/ShowHelloWorld
        public string ShowHelloWorld()
        {
            return "Hello World!" ;
        }

        public string ShowPrice(string product, int price)
        {
            return $"商品是:{product}，價格是{price}";
        }
    }
}