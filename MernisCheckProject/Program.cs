using MernisCheckProject.Abstract;
using MernisCheckProject.Adapters;
using MernisCheckProject.Concrete;
using MernisCheckProject.Entities;
using System;

namespace MernisCheckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "ahmet";
            customer.LastName = "ahmet";
            customer.DateOfBirth = new DateTime(1999,99,01);
            customer.NationalityId = "123123123123";
            BaseCustomerManager customerManager = new HepsiBuradaCustomerManager(new MernisServiceAdapter());
            customerManager.Save(customer);
            Console.ReadLine();
        }
    }
}
