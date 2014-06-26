using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baichday.Models
{
   public interface IHome1
    {
         List<Add> index();
        Add postShow(int id);
         List<Add> search(string city);
         List<Add> category(string cat);
         List<Add> price(string p);
         List<Add> search12(string city);
         List<Add> cat1();
         List<Add> cat2();
         List<Add> cat3();
         List<Add> cat4();
         List<Add> price1();
         List<Add> price2();
         List<Add> price3();
         void addPost1(Comment c);
         List<Comment> showComment(int id);
         void addComment(Comment c);
        
       


    }
}
