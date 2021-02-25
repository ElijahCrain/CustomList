using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
	[TestClass]
	 public class RemoveMethodUnitTest
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
		[TestMethod]

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
		[TestMethod]

		public void Decreese_count_byTwo()
		{
			//Arange
			CustomList<int> collectionOfNumbers = new CustomList<int>();


			int number1 = 9;
			int number2 = 7;
			int number3 = 5;
			int expected = 1;
			int actual;

			//Act

			collectionOfNumbers.Add(number1);
			collectionOfNumbers.Add(number2);
			collectionOfNumbers.Add(number3);
			collectionOfNumbers.Remove(number2);
			collectionOfNumbers.Remove(number3);
			actual = collectionOfNumbers.Count;

			//Assert

			Assert.AreEqual(expected, actual);

		}
		[TestMethod]

		public void Test_ifSecondIndex_IsTrusAfterDecrease()
		{
			//Arange
			CustomList<int> customListSecond = new CustomList<int>();
			int num = 6;
			int numone = 3;
			int numTwo = 4;
			int expected = 3;
			int actual;

			//act
			customListSecond.Add(num);
			customListSecond.Add(num);
			customListSecond.Add(numTwo);
			customListSecond.Add(numone);
			customListSecond.Add(num);
			customListSecond.Remove(numTwo);

			actual = customListSecond[2];

			//assert

			Assert.AreEqual(expected, actual);
		}
		[TestMethod]

		public void Remove_Item_AndChecksIfRemoved()
		{
			//Arrange
			CustomList<int> itemsToRemove = new CustomList<int>();
			int number1 = 4;
			int number2 = 5;
			int number3 = 6;
			int number4 = 7;
			int expected = 6;
			int actual;
			//Act
			itemsToRemove.Add(number1);
			itemsToRemove.Add(number2);
			itemsToRemove.Add(number3);
			itemsToRemove.Add(number4);
			itemsToRemove.Remove(number2);
			actual = itemsToRemove[1];
			//Assert
			Assert.AreEqual(expected, actual);
		}

	} 
}
