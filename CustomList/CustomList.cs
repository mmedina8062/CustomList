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
            // take our array that exists on our class
            // add the item (parameter) that is being passed into this method
            // to our array

            // incrament the count after adding the value to the array
            // count will represent the index in which to add the new item to the array

            array[Count] = items;
            Count++;

        }

        public void Remove(T items)
        {

        }






    }
}
