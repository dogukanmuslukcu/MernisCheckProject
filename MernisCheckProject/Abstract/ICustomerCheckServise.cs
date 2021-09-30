using MernisCheckProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MernisCheckProject.Abstract
{
    public interface ICustomerCheckServise
    {
        Task<bool> CheckIfRealPerson(Customer customer);
    }
}
