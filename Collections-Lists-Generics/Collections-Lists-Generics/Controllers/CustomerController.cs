using Collections_Lists_Generics.Service.Interfaces;
using Collections_Lists_Generics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Controllers
{
    internal class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        public void GetAll()
        {
            foreach (var customer in _customerService.GetAll())
            {
                Console.WriteLine(customer.FullName + "-" + customer.Address + "-" + customer.Age);
            }
        }
        public void GetById()
        {
            try
            {
                int id = 4;
                var result = _customerService.GetById(id);
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void GetAllByAge()
        {
            int age = 21;
            foreach (var customer in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(customer.FullName + "-" + customer.Address + "-" + customer.Age);
            }

        }
        public void GetAllCountOfDatas()
        {
            Console.WriteLine(_customerService.GetCount());
        }
        public void DescendingOrderByAge()
        {

            var result = _customerService.DescendingOrderByAge();
            foreach (var customer in result)
            {
                Console.WriteLine(customer.FullName + "-" + customer.Age);
            }
            // Console.WriteLine(result);
        }
        public void AscendingOrderByAge()
        {
            var result = _customerService.AscendingOrderByAge();
            foreach (var customer in result)
            {
                Console.WriteLine(customer.FullName + "-" + customer.Age);
            }
        }
    }
}
