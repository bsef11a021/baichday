using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Baichday.Models;

namespace Baichday.Models
{
    public class Customer1:ICustomer1
    {
   
        //
        // GET: /Add/

       
        public List<Add> ManagePost(int cid)
        {
            Database1Entities3 c = new Database1Entities3();
            
            
            var q = (from e in c.Adds
                     where e.Cid==cid
                     select e).ToList();
           return q;
            }
        
        public void delete(int id)
        {
            
            Database1Entities3 c = new Database1Entities3();
            var q1 = from x in c.Comments
                     where x.Aid == id
                     select x;
            //{
            foreach (var i in q1)
            {

                c.Comments.Remove(i);
                
            }
            c.SaveChanges();
            //    q1=c.Comments.First(Y => Y.Aid.Equals(id));
            //}
            
            var q = c.Adds.First(x => x.Id.Equals(id));
            c.Adds.Remove(q);
            c.SaveChanges();
            
            //return RedirectToAction("ManagePost");
            
        }
        public Add edit(int id)
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.First(x => x.Id.Equals(id));


            return q;
        }
      
        public bool checkUserName(string name)
        {
           
            Database1Entities3 c = new Database1Entities3();
            var q = c.Customers.Where(x => x.Name == name);
            if (q.Count() == 0)
            {
                return true;
            }
            else
            {



                return false;
            }
        }
        public bool signin(Customer cus)
        {
           
            

           

            Database1Entities3 c = new Database1Entities3();
            var q = (from x in c.Customers
                     where x.Name.Equals(cus.Name)
                     where x.password.Equals(cus.password)
                     select x).ToList();

            if (q.Count() != 0)
            {
                return true;
            }
            else
            {

                return false;

            }


        }
        public bool signin1(Customer cus)
        {
           


           

            Database1Entities3 c = new Database1Entities3();
            var q = (from x in c.Customers
                     where x.Name.Equals(cus.Name)
                     where x.password.Equals(cus.password)
                     select x).ToList();

            if (q.Count() != 0)
            {
                return true;
            }
            else
            {

                return false;

            }


        }
        public void signup(Customer cus)
        {
            Database1Entities3 c = new Database1Entities3();
            //Customer c1 = new Customer();
            //c1.Name = Request["username"];
            //c1.password = Request["userpassword"];
            //c1.Email = Request["email"];
            c.Customers.Add(cus);
            c.SaveChanges();


            
        }
        public void signup1(Customer cus)
        {
            Database1Entities3 c = new Database1Entities3();
            //Customer c1 = new Customer();
            //c1.Name = Request["username"];
            //c1.password = Request["userpassword"];
            //c1.Email = Request["email"];
            c.Customers.Add(cus);
            c.SaveChanges();


            
        }
        public void AddPost1(Add add)
        {
            Database1Entities3 c = new Database1Entities3();
            //Add c1 = new Add();
            //c1.title = Request["title"];
            //c1.location = Request["location"];
            //c1.Price = Request["price"];
            //c1.description = Request["description"];
            //c1.contact = Request["contact"];
            //c1.category = Request["category"];
           // add.Cid = getID();
            


            //HttpPostedFileBase file = Request.Files[0];
            //var path = Path.Combine(Server.MapPath("~/images/"), file.FileName);
            //file.SaveAs(path);

            //c1.image = file.FileName;

            c.Adds.Add(add);
            c.SaveChanges();
           
        }
        public void editPost(Add a)
        {
            Database1Entities3 c = new Database1Entities3();
         // Add q=  c.Adds.First(x => x.Id.Equals(a.Id));
          var q1 = from x in c.Adds
                  where x.Id == a.Id
                  select x;
          foreach (var q in q1)
          {
              q.Aid = a.Aid;
              q.category = a.category;
              q.Cid = a.Cid;
              q.location = a.location;
              q.contact = a.contact;
              q.title = a.title;
              q.Price = a.Price;
              q.image = a.image;
              q.description = a.description;
          }
          c.SaveChanges();
        }
        

    }
}

