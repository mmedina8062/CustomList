using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {

            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            string expected = "Shirt";
            string actual;

            //act
            clothingList.Add("Shirt");
            actual = clothingList[0];


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddRestOfClothingItemsToArray()
        {

            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            int expected = 4;
            int actual;

            //act
            clothingList.Add("Shirt");
            clothingList.Add("Pants");
            clothingList.Add("Shoes");
            clothingList.Add("Hat");
            actual = clothingList.Count;



            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetItemsAddedToList()
        {

            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            int expected = 1;
            int actual;

            //act
            clothingList.Add("Shirt");
            actual = clothingList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }


        /*public void Remove_RemoveAmountOfClothingBoughtFromList_StartAtEndOfIndex()
        {
            //arrange
            GenericList<int> OddDoubleDigitNumbersList = new GenericList<int>();
            int expected = 19;
            int actual;


            //act
            OddDoubleDigitNumbersList.Subtract(19);
            actual = OddDoubleDigitNumbersList.Count;



            //assert
            Assert.AreEqual(expected, actual);
        }*/
    }
}
    
