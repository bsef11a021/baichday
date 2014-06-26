
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baichday.Models
{
    public class Home1:IHome1
    {
        public List<Add> index()
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.ToList();
            return q;
        }
      

        public Add postShow(int id)
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.First(x => x.Id.Equals(id));

           
            
            return q;
        }
        
        public List<Add> search(string city)
        {
            

            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.location.Equals(city)).ToList();

            return q;
        }
        public List<Add> search12(string city)
        {

           
            Database1Entities3 c = new Database1Entities3();
            List<Add> q = c.Adds.Where(x => x.location.Equals(city)).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad=new Add();
                ad.title=a.title;
                ad.Price=a.Price;
                ad.location=a.location;
                ad.description=a.description;
                ad.image=a.image;
                ad.Cid=a.Cid;
                ad.category=a.category;
                ad.contact=a.contact;
                ad.Id = a.Id;
                obj.Add(ad);


            
            }
           
            return obj;
        }
        public List<Add> category(string cat)
        {

           
            Database1Entities3 c = new Database1Entities3();
            if (cat.Equals("m"))
            {

                var q = c.Adds.Where(x => x.category.Equals("mobile")).ToList();
                return q;

            }
            else if (cat.Equals("pe"))
            {
                var q = c.Adds.Where(x => x.category.Equals("pets")).ToList();
                return q;
            }
            else if (cat.Equals("v"))
            {
                var q = c.Adds.Where(x => x.category.Equals("vehicles")).ToList();
                return q;
            }
            else if (cat.Equals("pr"))
            {
                var q = c.Adds.Where(x => x.category.Equals("property")).ToList();
                return q;
            }
            return null;
        }
        public List<Add> price(string p)
        {
            
            Database1Entities3 c = new Database1Entities3();
            if (p.Equals("100"))
            {

                var q = 

                    (from e in c.Adds
                         where e.Price.StartsWith("1")
                         select e).ToList();
                // var q = c.Adds.Where(x => x.Price.StartsWith("1")).ToList();

                return q;
            }

            else if (p.Equals("200"))
            {

                var q = (from e in c.Adds
                         where e.Price.StartsWith("2")
                         select e).ToList();

                return q;
            }
            else if (p.Equals("300"))
            {

                var q = (from e in c.Adds
                         where e.Price.StartsWith("3")
                         select e).ToList();

                return q;
            }
            return null;


        }
        public List<Add> cat1()
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.category.Equals("mobile")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
            
        
        }
        public List<Add> cat2()
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.category.Equals("pets")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
            
        }
        public List<Add> cat3()
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.category.Equals("vehicles")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
            
        }
        public List<Add> cat4()
        {
            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.category.Equals("property")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
        }

        public List<Add> price1()
        {

            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.Price.StartsWith("1")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
        }
        public List<Add> price2()
        {

            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.Price.StartsWith("2")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
        }
        public List<Add> price3()
        {

            Database1Entities3 c = new Database1Entities3();
            var q = c.Adds.Where(x => x.Price.StartsWith("3")).ToList();
            List<Add> obj = new List<Add>();
            foreach (var a in q)
            {
                Add ad = new Add();
                ad.title = a.title;
                ad.Price = a.Price;
                ad.location = a.location;
                ad.description = a.description;
                ad.image = a.image;
                ad.Cid = a.Cid;
                ad.category = a.category;
                ad.contact = a.contact;
                ad.Id = a.Id;
                obj.Add(ad);



            }

            return obj;
        }
        public void addPost1(Comment c)
        {
            Database1Entities3 c1 = new Database1Entities3();
            c1.Comments.Add(c);
            c1.SaveChanges();
        }
        public void addComment(Comment c)
        {
            Database1Entities3 c1 = new Database1Entities3();
            c1.Comments.Add(c);
            c1.SaveChanges();

        
        }
        public List<Comment> showComment(int id)
        {
            Database1Entities3 c1 = new Database1Entities3();
            var q = c1.Comments.Where(x=>x.Aid.Equals(id)).ToList();
            return q;
       
        }
    }
}