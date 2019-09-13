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
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
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
    }
}

        /*public void Add_AddItemToEmptyList_ItemGoesToIndexOne()
        {
            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            string expected = "Pants";
            string actual;

            //act
            clothingList.Add("Pants");
            actual = clothingList[1];


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToEmptyList_ItemGoesToIndexTwo()
        {
            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            string expected = "Jacket";
            string actual;

            //act
            clothingList.Add("Jacket");
            actual = clothingList[2];


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToEmptyList_ItemGoesToIndexThree()
        {
            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            string expected = "Hat";
            string actual;

            //act
            clothingList.Add("Hat");
            actual = clothingList[3];


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToEmptyList_ItemGoesToIndexFour()
        {
            //arrange
            GenericList<string> clothingList = new GenericList<string>();
            string expected = "Socks";
            string actual;

            //act
            clothingList.Add("Socks");
            actual = clothingList[4];


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToEmptyList_ItemGoesToIndexFive()
        {
            //arrange
            GenericList<string> clothingItems = new GenericList<string>();
            string expected = "Shoes";
            string actual;

            //act
            clothingItems.Add("Shoes");
            actual = clothingItems[5];


            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_AmountOfClothingBoughtToEmptyList_CountIncrementsByOne()
        {
            //arrange
            GenericList<int> AmountOfClothingBought = new GenericList<int>();
            int expected = 1;
            int actual;

            //act
            AmountOfClothingBought.Add(2);
            actual = AmountOfClothingBought.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_RemoveAmountOfClothingBoughtFromList_StartAtEndOfIndex()
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
        }
    }
        
    }

}
    

*/