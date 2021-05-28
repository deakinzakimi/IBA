using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace habonapp.Models
{
    public class Organiser
    {
        public string id { get; set; }

        public int oactive;

        public string firstname { get; set; }

        public string lasttname { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string suburb { get; set; }

        public string state { get; set; }

        public string postcode { get; set; }

        public string country { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string confirmpassword { get; set; }
    }
}