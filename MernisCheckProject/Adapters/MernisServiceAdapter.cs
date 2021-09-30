using MernisCheckProject.Abstract;
using MernisCheckProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using mernissServiceReference;
using static mernissServiceReference.KPSPublicSoapClient;


namespace MernisCheckProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckServise
    {
        public Task<bool> CheckIfRealPerson(Customer customer)
        {
            bool dogrulamaSonucu = true;
            try
             {
                var mernisClient = new mernissServiceReference.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrula(long.Parse(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
                dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                dogrulamaSonucu = false;
            }
            return Task.FromResult(dogrulamaSonucu);
        }
      
    }
}
