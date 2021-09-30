using MernisCheckProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisCheckProject.Abstract
{
   public interface ICustomerService
    {
        void Save(Customer customer);
        
    }
}
