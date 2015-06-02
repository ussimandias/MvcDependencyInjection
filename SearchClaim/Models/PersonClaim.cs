using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchClaim.Models
{
    public class PersonClaim
    {      
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ClaimNumber { get; set; }
            public string CertificateNumber { get; set; }
            public string CompanyName { get; set; }
            public DateTimeOffset EffectiveDate { get; set; }
            public int Account { get; set; }
            public string Creditor { get; set; }
            public int LoanNumber { get; set; }
        
    }
}