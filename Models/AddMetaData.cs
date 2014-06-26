using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Baichday.Models
{
    public class AddMetaData
    {
        [Required (ErrorMessage="Enter title for add")]
        public string title{get;set;}
        [Required(ErrorMessage = "Enter price for add")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Enter contact for add")]
        public string  contact { get; set; }
        [Required(ErrorMessage = "Enter location for add")]
        public string location { get; set; }



    }
}