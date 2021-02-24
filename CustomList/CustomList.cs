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
				if (index <= 0 || index >= count)
				{
					index = 0;
					index = count;
				}
				return _items[index];
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
				// _items2 [ null, null, null, null, null, null, null, null ]

				for (int i = 0; i < _items.Length; i++)
				{
					//move items over
					_items2[i] = _items[i];

					// _items2 [ 23, 43, 12, 56, null, null, null, null ]


				}

				// _items2 [ 23, 43, 12, 56, null, null, null, null ]
				// _items: [ 23, 43,12, 56 ]

				_items = _items2;

				// _items: [ 23, 43, 12, 56, null, null, null, null ]

			}

			_items[count] = itemToAdd;
			count++;
		}

		 
	}
}
