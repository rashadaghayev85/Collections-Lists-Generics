
using Collections_Lists_Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Service.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetAllByAge(int age);
        int GetCount();
        List<Customer> DescendingOrderByAge();
        List<Customer> AscendingOrderByAge();
    }
}
