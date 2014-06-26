using Baichday.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baichday.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        IHome1 i;
        public HomeController(IHome1 iu)
        {
            i = iu;
        }

        public ActionResult index()
        {

            var q = i.index();
            return View(q);
        }
        public ActionResult subpage()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult postShow(int id)
        {
           Add q= i.postShow(id);
           Session.Add("id", id);
           List<Comment> co = i.showComment(id);
           ViewBag.l = co;

            return View(q);
        }
        public JsonResult search12()
        {
            string city = Request["u"];

            List<Add> q = i.search12("lahore");
           
            
           // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult search13()
        {
            string city = Request["u"];

            List<Add> q = i.search12("islamabad");


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult search14()
        {
            string city = Request["u"];

            List<Add> q = i.search12("karachi");


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult price1()
        {
            string city = Request["u"];

            List<Add> q = i.price1();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult price2()
        {
            string city = Request["u"];

            List<Add> q = i.price2();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult price3()
        {
            string city = Request["u"];

            List<Add> q = i.price3();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult cat1()
        {
            string city = Request["u"];

            List<Add> q = i.cat1();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult cat4()
        {
            string city = Request["u"];

            List<Add> q = i.cat4();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult cat2()
        {
            string city = Request["u"];

            List<Add> q = i.cat2();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public JsonResult cat3()
        {
            string city = Request["u"];

            List<Add> q = i.cat3();


            // List<Add> w= i.search12(city);

            return this.Json(q, JsonRequestBehavior.AllowGet);
        }
        public ActionResult search()
        {
            string city = Request["u"];
           var q= i.search(city);
           return View(q);

        }
      
       
        public ActionResult category()
        {

            string cat = Request["u"];
            var q = i.category(cat);
            
                return View(q);
            
            
        }
        public ActionResult Search1()
        {
            return View();
        }
        public ActionResult price()
        {
            string p = Request["u"];
            var q=i.price(p);
            
                return View(q);
            


        }
        public ActionResult addComment(Comment c)
        {
            c.Aid = (int)Session["id"];
            i.addComment(c);
            return RedirectToAction("Success");
        }
       

    }
}
