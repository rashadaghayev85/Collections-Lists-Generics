using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Lists_Generics
{
    internal class DataList<T>
    {
        private T[] TArray;
        public DataList()
        {
            TArray = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref TArray, TArray.Length + 1);
            TArray[TArray.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return TArray;
        }

        public T[] Delete(T word)
        {
            T[] arr = new T[0];
            bool a = true;
            for (int i = 0; i < TArray.Length; i++)
            {

                if (EqualityComparer<T>.Default.Equals(TArray[i], word))
                {

                    continue;

                }
                else
                {

                    while (a == true)
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = TArray[i];

                        if (i == TArray.Length - 1)
                        {
                            a = false;
                        }
                        break;

                    }

                }
            }
            return arr;
        }


    }
}
