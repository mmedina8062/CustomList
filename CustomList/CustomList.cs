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
            if (Count == array.Length)
            {
                IncreaseArraySize();
            }

            array[Count] = items;
            Count++;

        }

        private void IncreaseArraySize()
        {
            T[] NewArraySize = array;
            array = new T[array.Length + 4];

            for (int i = 0; i < NewArraySize.Length; i++)
            {
                array[i] = NewArraySize[i];
            }
        }

        public bool Remove(T item)
        {


            // is the item there at all?
            // if so, remove

            for (int i = 0; i < Count; i++)
            {
                if (array.Contains(item)) //items matches array[i] )
                {
                    // grab the next value
                    array[i] = array[i + 1];
                    Count--;

                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        public override string ToString() 
        {
            T[] NewArray1 = array;
            T[] NewArray2 = array;

            for (int i = 0; i<array.Length; i++)
            {
                array[i] = NewArray1[i];
                array[i] = NewArray2[i];   

            }
            return NewArray1 + " " + NewArray2;
        }

    }

}
        


        
       /* public void DecreasedArraySize(T items)
        {
            T[] DecreaseArraySize = array;
            array = new T[array.Length - 1];

            for (int i = 0; i < DecreaseArraySize.Length; i++)
            {
                
                array[i - 1] = DecreaseArraySize[i - 1];
                Count--;

                
                
            }
            
        }*/






  

