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
            CustomList<string> clothingList = new CustomList<string>();
            string expected = "Shirt";
            string actual;

            //act
            clothingList.Add("Shirt");
            actual = clothingList[0];


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToEmptyList_ItemGoesToIndexOne()
        {
            //arrange
            CustomList<string> clothingList = new CustomList<string>();
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
            CustomList<string> clothingList = new CustomList<string>();
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
            CustomList<string> clothingList = new CustomList<string>();
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
            CustomList<string> clothingList = new CustomList<string>();
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
            CustomList<string> clothingList = new CustomList<string>();
            string expected = "Shoes";
            string actual;

            //act
            clothingList.Add("Shoes");
            actual = clothingList[5];


            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddNumberToEmptyList_CountIncrementsByOne()
        {
            //arrange
            CustomList<int> OddDoubleDigitNumbersList = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            OddDoubleDigitNumbersList.Add(11);
            actual = OddDoubleDigitNumbersList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Subtract_SubtractItemFromList_StartAtIndexZero()
        {
            //arrange
            CustmonList<string> clothingList = new CustmonList<string>();
            string expected = "Shirt";
            string actual;

            //act
            clothingList.Subtract("Shirt");
            actual = clothingList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Subtract_SubtractNumberFromList_StartAtEndOfList()
        {
            //arrange
            CustomList<int> OddDoubleDigitNumbersList = new CustomList<int>();
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
    

