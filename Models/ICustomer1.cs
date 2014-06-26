using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baichday.Models
{
    public interface ICustomer1
    {
         List<Add> ManagePost(int cid);
         void delete(int id);
         Add edit(int id);
         bool checkUserName(string name);
         bool signin(Customer cus);
         bool signin1(Customer cus);
         void signup(Customer cus);
         void signup1(Customer cus);
         void AddPost1(Add add);
         void editPost(Add add);
    }
}
