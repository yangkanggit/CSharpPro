using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcControllerApp.Models;

namespace MvcControllerApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.UserName = "小李飞刀";
            ViewData["UserName"] = "陆小凤";
            TempData["UserName"] = "楚留香";//临时数据
            Customers model = new Customers { ContactName = "谢晓峰" };

            return View(model); //这行代码其实就相当于ViewData.Model=model
        }
        public ActionResult UpdateCustomerInfo()
        {
            return View();
        }
        //[HttpPost]
        //public string UpdateCustomerInfo(FormCollection form)
        //{
        //    return Request.Form["ContactName"]; 
        //}
        //[HttpPost]
        //public string UpdateCustomerInfo(FormCollection form)
        //{
        //    return form["ContactName"];;
        //}
        //[HttpPost]
        //public string UpdateCustomerInfo(string ContactName)
        //{
        //    return ContactName;
        //}
        //[HttpPost]
        //public string UpdateCustomerInfo(Customers model)
        //{
        //    return model.ContactName+","+model.CompanyName;
        //}
    }
}
