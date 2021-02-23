using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
	[TestClass]
	class RemoveMethodUnitTest
	{
		[TestMethod]
		public void remove_Item_CountDecreases_ByOne()
		{
			//Arange

			CustomList<int> collectionOfNumbers = new CustomList<int>();

			int number1 = 9;
			int number2 = 7;
			int expected = 1;
			int actual;

			//Act
			collectionOfNumbers.Add(number1);
			collectionOfNumbers.Add(number2);
			collectionOfNumbers.Remove(number1);
			actual = collectionOfNumbers.Count;

			//Assert

			Assert.AreEqual(expected, actual);
		}
		public void Test_for_NumberOfCapacityIfDecreasse_ByOne()
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

			//Act


			customListCapacity.Add(numOne);
			customListCapacity.Add(numTwo);
			customListCapacity.Add(numThree);
			customListCapacity.Add(numFour);
			customListCapacity.Add(numFive);
			customListCapacity.Remove(numFive);

			actual = customListCapacity.Capacity;

			//Assert

			Assert.AreEqual(expected, actual);

		}
		public void Test_2()
		{
			//Arange
			CustomList<int> collectionOfNumbers = new CustomList<int>();

			//Act

			//Assert


		}
		public void Test_3()
		{
			//Arange
			CustomList<int> collectionOfNumbers = new CustomList<int>();

			//Act

			//Assert


		}
	} 
}
