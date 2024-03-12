

using Collections_Lists_Generics.Helpers.Exceptions;
using Collections_Lists_Generics.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Service
{
    internal class MathService : IMathService
    {
        public string Factorial(int? number)
        {
            try
            {
                int factorial = 1;
                if (number < 0)
                {
                    throw new CustomNegativeNumberException("Faktorial axtarilan eden menfi ola bilmez");
                }
                if (number == 0)
                {
                    factorial = 1;
                }

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                return factorial.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
