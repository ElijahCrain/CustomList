using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	public class CustomList<T>
	{
		//member varaibles
		private T[] _items;

		private int count;
		private int capacity;
		//Constructor
		public CustomList()
		{
			count = 0;
			capacity = 4;
			_items = new T[capacity];
		}

		//member methods
		public void Add(T itemToAdd)
		{
			if (count == capacity)
			{
				//create new  array
				//move items over
				//new array is now _items array.
			}
			_items[count] = itemToAdd;
			count++;
		}


	}
}
