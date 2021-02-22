using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
	[TestClass]
	public class AddMethodUnitTest
	{
		[TestMethod]
		public void Add_Item_CountIncreases_ByOne()
		{
			//Arange

			CustomList<int> collectionOfNumbers = new CustomList<int>();

			int number = 9;
			int expected = 1;
			int actual;

			//Act

			collectionOfNumbers.Add(number);
			actual = collectionOfNumbers.Count;

			//Assert

			Assert.AreEqual(expected, actual);

		}
		public void Add_ItemsCount_ByThree()
		{          
			//Arange

			CustomList<int> collectionOfNumbers = new CustomList<int>();

			int numberOne = 9;
			int numberTwo = 5;
			int numberThree = 7;
			int expected = 3;
			int actual;

			//Act

			collectionOfNumbers.Add(numberOne);
			collectionOfNumbers.Add(numberTwo);
			collectionOfNumbers.Add(numberThree);
			actual = collectionOfNumbers.Count;
			

			//Assert

			Assert.AreEqual(expected, actual);
		}

		public void Add_ThreeNumbersToList_TestReturn()
		{
			//Arange
			CustomList<int> collectionOfNumbers = new CustomList<int>();

			int numberOne = 8;
			int numberTwo = 4;
			int numberThree = 6;
			int expected = 6;
			int actual;

			//Act

			collectionOfNumbers.Add(numberOne);
			collectionOfNumbers.Add(numberTwo);
			collectionOfNumbers.Add(numberThree);
			actual = collectionOfNumbers[2];
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
