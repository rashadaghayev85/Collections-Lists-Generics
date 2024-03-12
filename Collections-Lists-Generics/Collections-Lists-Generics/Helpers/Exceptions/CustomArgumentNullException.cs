using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics.Helpers.Exceptions
{
    internal class CustomArgumentNullException:Exception
    {
        public CustomArgumentNullException(string msj) : base(msj)
        {

        }
    }
}
