using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchClaim.Models
{
    public class MockDependencyInjection
    {

        public static class DependencyFactory
        {
            public static ISearchResultsService NewResultsService()
            {
                return new MockSearchResultsService();
            }
        }

        public interface ISearchResultsService
        {
            List<PersonClaim> FindClaims(string firstName, string lastName, string ClaimNumber, string CertificateNumber, string CompanyName, DateTimeOffset EffectiveDate, int Account, string Creditor, int LoanNumber);
            
        }

        public class MockSearchResultsService : ISearchResultsService
        {
            public List<PersonClaim> FindClaims(string firstName, string lastName, string ClaimNumber, string CertificateNumber, string CompanyName, DateTimeOffset EffectiveDate, int Account, string Creditor, int LoanNumber)
            {
                return new List<PersonClaim>(new[] { new PersonClaim { FirstName = "Bill", 
                    LastName = "Ryan", 
                    ClaimNumber= "asdfg2", 
                    CertificateNumber="qwerty45", 
                    CompanyName="Fortegra", 
                    EffectiveDate =DateTimeOffset.Now, 
                    Account= 232, 
                    Creditor="Wells Fargo", 
                    LoanNumber = 123456 } });//throw new NotImplementedException();
            }          
        }       
    }
}