using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyApplication.Web.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public List<Policy> Policies { get; set; }
        public PolicyHolder PolicyHolder { get; set; }

    }
}