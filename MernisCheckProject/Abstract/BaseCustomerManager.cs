using MernisCheckProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisCheckProject.Abstract
{
    public  abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("kaydedilmiştir : "+customer.FirstName+customer.LastName);
        }
    }
}
