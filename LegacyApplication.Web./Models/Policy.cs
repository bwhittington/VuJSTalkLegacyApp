using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyApplication.Web.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyType { get; set; }
        public string PolicyNumber { get; set; }
        public string RenewalNumber { get; set; }
        public string EndorsementNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Cost { get; set; }
    }
}