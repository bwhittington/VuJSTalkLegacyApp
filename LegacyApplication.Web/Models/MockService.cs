using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyApplication.Web.Models
{
    public class MockService  : IMockService
    {
        public MockService()
        {

        }

        public Account GetAccount()
        {
            var account = new Account();
            account.AccountNumber = "ABC1234567890";
            account.CreatedDate = new DateTime(2012, 1, 1);
            account.Id = 1;

            account.PolicyHolder = new PolicyHolder();
            account.PolicyHolder.Id = 1;
            account.PolicyHolder.State = "OH";
            account.PolicyHolder.StreetAddress = "123 AnyStreet";
            account.PolicyHolder.StreetAddress2 = string.Empty;
            account.PolicyHolder.Zip = "12345";
            account.PolicyHolder.City = "AnyTown";
            account.PolicyHolder.CompanyName = "ABC Company";

            account.PolicyHolder.Contacts = new List<Contact>();
            var contact = new Contact();
            contact.City = "AnyTown";
            contact.Email = "jdoe@abc.com";
            contact.FirstName = "John";
            contact.Id = 1;
            contact.LastName = "Doe";
            contact.PhoneNumber = "555-123-4567";
            contact.StreetAddress = "123 AnyStreet";
            contact.Title = "CEO";
            contact.State = "OH";
            contact.Zip = "12345";
            account.PolicyHolder.Contacts.Add(contact);

            account.Policies = new List<Policy>();
            var cl = new Policy();
            cl.EffectiveDate = new DateTime(2019, 1, 1);
            cl.EndorsementNumber = "000";
            cl.ExpirationDate = new DateTime(2020, 1, 1);
            cl.Id = 1;
            cl.PolicyNumber = "123456789";
            cl.PolicyType = "Commecial Liability";
            cl.RenewalNumber = "00";
            cl.Cost = 10000;
            account.Policies.Add(cl);

            var cim = new Policy();
            cim.EffectiveDate = new DateTime(2019, 1, 1);
            cim.EndorsementNumber = "000";
            cim.ExpirationDate = new DateTime(2020, 1, 1);
            cim.Id = 2;
            cim.PolicyNumber = "234567891";
            cim.PolicyType = "Commecial Inland Marine";
            cim.RenewalNumber = "00";
            cim.Cost = 9000;
            account.Policies.Add(cim);

            var cc = new Policy();
            cc.EffectiveDate = new DateTime(2019, 1, 1);
            cc.EndorsementNumber = "000";
            cc.ExpirationDate = new DateTime(2020, 1, 1);
            cc.Id = 3;
            cc.PolicyNumber = "345678912";
            cc.PolicyType = "Commecial Crime";
            cc.RenewalNumber = "00";
            cc.Cost = 8000;
            account.Policies.Add(cc);

            var cp = new Policy();
            cp.EffectiveDate = new DateTime(2019, 1, 1);
            cp.EndorsementNumber = "000";
            cp.ExpirationDate = new DateTime(2020, 1, 1);
            cp.Id = 4;
            cp.PolicyNumber = "456789123";
            cp.PolicyType = "Commecial Property";
            cp.RenewalNumber = "00";
            cp.Cost = 7000;
            account.Policies.Add(cp);

            var ca = new Policy();
            ca.EffectiveDate = new DateTime(2019, 1, 1);
            ca.EndorsementNumber = "000";
            ca.ExpirationDate = new DateTime(2020, 1, 1);
            ca.Id = 5;
            ca.PolicyNumber = "678912345";
            ca.PolicyType = "Commecial Auto";
            ca.RenewalNumber = "00";
            ca.Cost = 6000;
            account.Policies.Add(ca);

            var wc = new Policy();
            wc.EffectiveDate = new DateTime(2019, 1, 1);
            wc.EndorsementNumber = "000";
            wc.ExpirationDate = new DateTime(2020, 1, 1);
            wc.Id = 6;
            wc.PolicyNumber = "789123456";
            wc.PolicyType = "Workers' Compensation";
            wc.RenewalNumber = "00";
            wc.Cost = 5000;
            account.Policies.Add(wc);

            return account;
        }
    }
}