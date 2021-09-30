using MernisCheckProject.Abstract;
using MernisCheckProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisCheckProject.Concrete
{
     public class HepsiBuradaCustomerManager :BaseCustomerManager
    {
        private ICustomerCheckServise _customerCheckServise;

        public HepsiBuradaCustomerManager(ICustomerCheckServise customerCheckServise)
        {
            _customerCheckServise = customerCheckServise;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckServise.CheckIfRealPerson(customer).Result)
            {
                base.Save(customer);
            }
            else 
            {
                throw new Exception("Kişi bilgileri geçersizdir.");
            }
        }
    }
}
