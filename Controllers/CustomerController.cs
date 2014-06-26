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
    public class CustomerController : Controller
    {
        ICustomer1 cu;
        //
        // GET: /Add/
        public CustomerController(ICustomer1 c)
        {
            cu = c;
        }


        public ActionResult sign()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult sign1()
        {
            return View();
        }
        public ActionResult ManagePost()
        {
            
            
            int cid=getID();
            var q = cu.ManagePost(cid);
            
                return View(q);
           
        }
        public ActionResult delete(int id)
        {
            cu.delete(id);
            return RedirectToAction("ManagePost");
            
        }
        public ActionResult edit(int id)
        {
           Add q= cu.edit(id);
            
            return View(q);

        }
        public ActionResult sign2()
        {
            return View();
        }
        public JsonResult checkUserName()
        {
            string name = Request["u"];
            if(cu.checkUserName(name))
            {
                return this.Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {



                return this.Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult signin(Customer c)
        {
            string nm = c.Name;
           
            

            Session.Add("name", nm);


            if (ModelState.IsValid)
            {
                if (cu.signin(c))
                {
                    return View("AddPost");
                }
                else
                {

                    return View("Failure");

                }
            }
            else
            {
                return View("Failure");
            }


        }
        public ActionResult signin1(Customer c)
        {
            string nm = c.Name;
          


            Session.Add("name", nm);

           

            if (cu.signin1(c))
            {
                return RedirectToAction("ManagePost");
            }
            else
            {

                return View("Failure");

            }


        }
        public ActionResult signup(Customer c)
        {
            cu.signup(c);


            return View("sign1");
        }
        public ActionResult signup1(Customer c)
        {
            cu.signin1(c);


            


            return View("sign2");
        }
        public ActionResult AddPost1(Add a)
        {

           
                a.Cid = getID();
                string p = Request["picture"];


                HttpPostedFileBase file = Request.Files[0];
                var path = Path.Combine(Server.MapPath("~/images/"), file.FileName);
                file.SaveAs(path);

                a.image = file.FileName;

                if (ModelState.IsValid)
                {
                    cu.AddPost1(a);
                }
                else
                {
                    return View("AddPost");
                }
           
            return View("Success");
        }
        private int getID()
        {

            Database1Entities3 c = new Database1Entities3();
            string name=Session["name"].ToString();
            
            var q = c.Customers.First(x => x.Name.Equals(name));
            return (q.Id);
        }
        public ActionResult editPost(Add a)
        {

            HttpPostedFileBase file = Request.Files[0];
            var path = Path.Combine(Server.MapPath("~/images/"), file.FileName);
            file.SaveAs(path);

            a.image = file.FileName;
            cu.editPost(a);
            return RedirectToAction("Success");
        
        }
        public ActionResult Failure()
        {
            return View();
        }
    }
}
