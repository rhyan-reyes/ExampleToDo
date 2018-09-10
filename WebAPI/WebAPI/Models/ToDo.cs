using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ToDo
    {
        public int id { get; set; }
        public string task { get; set; }
        public DateTime DateCreated { get; set}
        public DateTime DateModified { get; set; }
    }
}