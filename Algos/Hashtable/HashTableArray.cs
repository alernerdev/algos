using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Algos
{
	class HashTableArray<TKey, TValue>
	{
		HashTableArrayNode<TKey, TValue> [] m_arr;

		public HashTableArray(int initialCapacity)
		{
			m_arr = new HashTableArrayNode<TKey, TValue>[initialCapacity];
			for (int i = 0; i < initialCapacity; i++)
			{
				// doing this upfront is probably wasteful and can be done as needed when needed
				m_arr[i] = new HashTableArrayNode<TKey, TValue>();
			}
		}

		public void Add(TKey key, TValue value)
		{
			// you want to store the key value as well in case of a collision
			// and you need to look through the keys themselves
			m_arr[GetIndex(key)].Add(key, value);
		}

		public void Update(TKey key, TValue value)
		{
			m_arr[GetIndex(key)].Update(key, value);
		}

		public bool Remove(TKey key)
		{
			return m_arr[GetIndex(key)].Remove(key);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return m_arr[GetIndex(key)].TryGetValue(key, out value);
		}

		public int Capacity()
		{
			return m_arr.Length;
		}

		public void Clear()
		{
			foreach (HashTableArrayNode<TKey, TValue> n in m_arr)
				n.Clear();
		}
	}

}
*/