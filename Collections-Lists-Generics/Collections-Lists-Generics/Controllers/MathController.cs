using Collections_Lists_Generics.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Controllers
{
    internal class MathController
    {
        private MathService _mathService;
        public MathController()
        {
            _mathService = new MathService();
        }
        public void Factorial()
        {
        label: Console.WriteLine("factorialini axtardiginiz ededi daxil edin:");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Cavab:" + _mathService.Factorial(number));
            goto label;
        }
    }
}
