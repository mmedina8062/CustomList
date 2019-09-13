using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class GenericList<T>
    {
        //member var
        private T[] array;
        public int Capacity { get; set; }
        public int Count;

        //constructor
        public GenericList()
        {
            Count = 0;
            array = new T[3];
        }

        public T this[int i]
        {
            get { return array[i]; }
        }

        public void Add(T items)
        {
            // check the capacity of our array - do this below this comment using an if statement
            if (Count > array.Length)
            {
                IncreaseArraySize();
            }

            // if no more room is left to add a new item, we need to make our array have more spots - aka if we
            // enter our if statement becuase there is no more room left - call the IncreaseArraySizeMethod


            array[Count] = items;
            Count++;

        }

        private void IncreaseArraySize()
        {
            // TODO
        }

        public void Remove(T items)
        {

        }






    }
}
