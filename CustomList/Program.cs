using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            GenericList<string> clothingList = new GenericList<string>();
                        clothingList.Add("Shirt");*/

            /*List<int> intList = new List<int>() { 1, 2 };
            int howMany = intList.Count;*/

            // Transfer all the data from array1 to array2

            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = new int[6];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            //int[] array3 = new int[array1.Length + array2.Length];
            //for (int i = 0; i < array3.Length; i++)
            //{
                //array1 = array2;
            //}
        }
    }
}
