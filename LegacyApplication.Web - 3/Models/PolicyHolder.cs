using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyApplication.Web.Models
{
    public class PolicyHolder
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}