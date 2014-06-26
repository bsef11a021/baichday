using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Baichday.Models
{
    public class CustomerMetaData
    {
        [Required (ErrorMessage="Enter name")]
        public string Name { get; set; }
         [Required(ErrorMessage="Enter Password")]
        public string password { get; set; }
       // [Required(ErrorMessage="Enter email address")]
       // [DataType(DataType.EmailAddress)]
       //  public string Email { get; set; }

    }
}