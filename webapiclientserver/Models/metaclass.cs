using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace webapiclientserver.Models
{
    public class metaclass
    {

        public int id { get; set; }
        public string name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        
        public string phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime dob { get; set; }

    }
}