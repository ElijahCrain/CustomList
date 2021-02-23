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
