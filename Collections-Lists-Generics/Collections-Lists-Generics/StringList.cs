using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics
{
    internal class StringList
    {
        private string[] stringArray;
        public StringList()
        {
            stringArray = new string[0];
        }
        public void Add(string word)
        {
            Array.Resize(ref stringArray, stringArray.Length + 1);
            stringArray[stringArray.Length - 1] = word;
        }

        public string[] GetAll()
        {
            return stringArray;
        }
        public string[] Delete(string word)
        {
            string[] arr = new string[0];
            bool a = true;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == word)
                {

                    continue;

                }
                else
                {

                    while (a == true)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = stringArray[i];

                        if (i == stringArray.Length - 1)
                        {
                            a = false;
                        }
                        break;

                    }

                }

            }
            // stringArray=arr;
            return arr;
        }
    }
}
