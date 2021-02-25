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
		//Propertys
		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= count)
				{
					throw new IndexOutOfRangeException("Your Input is out of range");
				}
				return _items[index];
			}
			set
			{
				if (index < 0 || index >= count)
				{
					throw new IndexOutOfRangeException("Your Input is out of range");
				}
				_items[index] = value;
			}
		}
		public int Count
		{
			get
			{
				return count;
			}
			
		}
		public int Capacity
		{
			get
			{
				return capacity;
			}
			set
			{
				capacity = value;
			}
		}
		//Constructor
		public CustomList()
		{
			count = 0;
			capacity = 4;
			_items = new T[capacity];
		}

		//member methods
		public void  Add(T itemToAdd)
		{
			if (count == capacity)
			{
				Capacity = Capacity * 2;
				//create new  array
				// _items: [ 23, 43,12, 56 ]

				T[] _items2 = new T[Capacity];

				for (int i = 0; i < Count; i++)
				{
					_items2[i] = _items[i];

				}


				_items = _items2;


			}

			_items[count] = itemToAdd;
			count++;
		}
			//remove method 
			//can not use conventual == //.= use a bool
		public void Remove(T itemToRemove)
		{
			for (int i = 0; i < count; i++)
			{
				if (_items[i].Equals(itemToRemove))
				{
					_items[i] = itemToRemove;
					i--;
				}
				
			}

		}
		 
	}
}
