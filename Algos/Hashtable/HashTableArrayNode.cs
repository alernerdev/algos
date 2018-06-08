using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	public class HashTableArrayNode<TKey, TValue>
	{
		// conflict with my own LinkedList implementation
		System.Collections.Generic.LinkedList<HashTableNodePair<TKey, TValue>> m_items;

		public void Add(TKey key, TValue value)
		{
			if (m_items == null)
				m_items = new System.Collections.Generic.LinkedList<HashTableNodePair<TKey, TValue>>();
			else
			{
				// this is for collision management
				foreach(HashTableNodePair<TKey, TValue> pair in m_items)
				{
					if (pair.Key.Equals(key))
					{
						throw new ArgumentException("key is already present in the hashtable");
					}
				}
			}

			m_items.AddFirst(new HashTableNodePair<TKey, TValue>(key, value));
		}

		public void Update(TKey key, TValue value)
		{
			bool updated = false;

			if (m_items != null)
			{
				// this is for collision management
				foreach (HashTableNodePair<TKey, TValue> pair in m_items)
				{
					if (pair.Key.Equals(key))
					{
						pair.Value = value; //set new value
						updated = true;
						break;
					}
				}

			}

			if (!updated)
				throw new ArgumentException("collection does not contain the key");

		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			bool found = false;

			if (m_items !=null)
			{
				foreach (HashTableNodePair<TKey, TValue> p in m_items)
					if (p.Key.Equals(key))
					{
						value = p.Value;
						found = true;
						break;
					}
			}

			return found;
		}

		public bool Remove(TKey key)
		{
			bool removed = false;

			if (m_items != null)
			{
				LinkedListNode<HashTableNodePair<TKey, TValue>> current = m_items.First;
				while (current != null)
				{
					if (current.Value.Equals(key))
					{
						m_items.Remove(current);
						removed = true;
						break;
					}

					current = current.Next;
				}
			}

			return removed;
		}

		public void Clear()
		{
			if (m_items != null)
				m_items.Clear();
		}

		public IEnumerable<TValue> Values
		{
			get
			{
				if (m_items != null)
				{
					foreach (HashTableNodePair<TKey, TValue> p in m_items)
						yield return p.Value;
				}
			}
		}

		public IEnumerable<TKey> Keys
		{
			get
			{
				if (m_items != null)
				{
					foreach (HashTableNodePair<TKey, TValue> p in m_items)
						yield return p.Key;
				}
			}
		}

		public IEnumerable<HashTableNodePair<TKey, TValue>> Items
		{
			get
			{
				if (m_items != null)
				{
					foreach (HashTableNodePair<TKey, TValue> p in m_items)
						yield return p;
				}
			}
		}
	}
}
