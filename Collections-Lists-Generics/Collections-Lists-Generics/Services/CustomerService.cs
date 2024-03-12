
using Collections_Lists_Generics.Data;
using Collections_Lists_Generics.Models;
using Collections_Lists_Generics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Service
{
    internal class CustomerService : ICustomerService
    {
        List<Customer> ICustomerService.GetAll()
        {
            return AppDbContext.customer;
        }

        Customer ICustomerService.GetById(int? id)
        {
            return id == null ? throw new NullReferenceException() : AppDbContext.customer.FirstOrDefault(m => m.Id == id);
        }
        List<Customer> ICustomerService.GetAllByAge(int age)
        {
            return AppDbContext.customer.Where(m => m.Age == age).ToList();
        }



        int ICustomerService.GetCount()
        {
            return AppDbContext.customer.Count();
        }
        public List<Customer> DescendingOrderByAge()
        {

            var result = AppDbContext.customer.OrderByDescending(m => m.Age).ToList();
            return result;
        }

        List<Customer> ICustomerService.AscendingOrderByAge()
        {
            var result = AppDbContext.customer.OrderBy(m => m.Age).ToList();
            return result;
        }
    }
}
