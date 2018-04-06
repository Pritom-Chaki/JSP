using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSP.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string presentAddress { get; set; }
        public string permanentAddress { get; set; }
        public string institute { get; set; }
        public string passion { get; set; }
        public string department { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
        public string email { get; set; }

    }
}