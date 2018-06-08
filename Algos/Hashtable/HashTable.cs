using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Algos
{
	public class HashTable<TKey, TValue>
	{
		const double m_fillFactor = .75;

		// this code does not take into account ratio of filled and empty slots -- just the total number of items
		int m_maxItemsAtCurrentSize = 0;
		int m_count = 0;

		HashTableArray<TKey, TValue> m_arr;

		public HashTable() : this(10)
		{

		}

		public HashTable(int initialCapacity)
		{
			if (initialCapacity < 1)
				throw new ArgumentOutOfRangeException("initialCapacity");

			m_arr = new HashTableArray<TKey, TValue>(initialCapacity);
			m_maxItemsAtCurrentSize = (int)(initialCapacity * m_fillFactor) + 1;
		}

		public void Add(TKey key, TValue value)
		{
			if (m_count >= m_maxItemsAtCurrentSize)
			{
				// array needs to grow and data gets copied over
				HashTableArray<TKey, TValue> largerArr = new HashTableArray<TKey, TValue>(m_arr.Capacity() * 2);
				foreach (HashTableArrayNode<TKey, TValue> n in m_arr.Items)
					largerArr.Add(n.Key, n.Value);

				m_arr = largerArr;
				m_maxItemsAtCurrentSize = (int)(m_arr.Capacity() * m_fillFactor) + 1;
			}

			m_arr.Add(key, value);
			m_count++;
		}

		public bool Remove(TKey key)
		{
			bool removed = m_arr.Remove(key);
			if (removed)
				m_count--;

			return removed;
		}

		public TValue this[TKey key]
		{
			get
			{
				TValue value;
				if (!m_arr.TryGetValue(key, out value))
					throw new ArgumentException("key");

				return value;
			}
			set
			{
				m_arr.Update(key, value);
			}
		}

		public bool TryGetValue(TKey key, TValue value)
		{
			return m_arr.TryGetValue(key, out value);
		}

		public void Clear()
		{
			m_arr.Clear();
			m_count = 0;
		}

		public int Count
		{
			get
			{
				return m_count;
			}
		}
	}
}
*/