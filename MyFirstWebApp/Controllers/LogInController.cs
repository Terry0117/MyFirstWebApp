using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        // 使用FormCollection取得Form回傳的資料
        //[HttpPost]
        //public ActionResult Verify(FormCollection obj)
        //{
        //    ViewBag.Account = obj["account"];
        //    ViewBag.Password = obj["password"];

        //    return View();
        //}
        //直接將form回傳的元素寫在參數內
        //[HttpPost]
        //public ActionResult Verify(string account, string password)
        //{
        //    ViewBag.Account = account;
        //    ViewBag.Password = password;

        //    return View();
        //}
        //自行建立類別與屬性，來對應form裡面元素name屬性
        [HttpPost]
        public ActionResult Verify(LogInViewModel vm)
        {
            ViewBag.Account = vm.Account;
            ViewBag.Password = vm.Password;

            return View();
        }
    }
}