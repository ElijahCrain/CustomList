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

		public void Test_for_NumberOfCapacityIncresse()
		{
			//Arange
			CustomList<int> customListCapacity = new CustomList<int>();

			int numOne = 2;
			int numTwo = 4;
			int numThree = 6;
			int numFour = 8;
			int numFive = 10;
			int expected = 8;
			int actual;

			//act
			customListCapacity.Add(numOne);
			customListCapacity.Add(numTwo);
			customListCapacity.Add(numThree);
			customListCapacity.Add(numFour);
			customListCapacity.Add(numFive);
			actual = customListCapacity.Capacity;

			//Assert
			Assert.AreEqual(expected, actual);


		}
		public void Test_FithItemIn_IndexIsTrue()
		{
			//Arange
			CustomList<int> customListFivth = new CustomList<int>();
			int num = 6;
			int numone = 3;
			int expected = 3;
			int actual;

			//act
			customListFivth.Add(num);
			customListFivth.Add(num);
			customListFivth.Add(num);
			customListFivth.Add(num);
			customListFivth.Add(numone);
			actual = customListFivth[4];

			//assert

			Assert.AreEqual(expected, actual);

		}
		public void Test_()
		{
			//Arange
			CustomList<int> customListFivth = new CustomList<int>();
			int num = 6;
			int numone = 3;
			int expected = 6;
			int actual;

			//act
			customListFivth.Add(num);
			customListFivth.Add(numone);
			customListFivth.Add(numone);
			customListFivth.Add(numone);
			customListFivth.Add(numone);
			actual = customListFivth[0];

			//assert

			Assert.AreEqual(expected, actual);

		}

	}
}
