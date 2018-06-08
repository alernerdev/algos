using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	public class HashTableNodePair<TKey, TValue>
	{
		protected TKey m_key;
		protected TValue m_value;
		public HashTableNodePair(TKey key, TValue value)
		{
			m_key = key;
			m_value = value;
		}

		public TKey Key
		{
			get
			{
				return m_key;
			}
		}
		public TValue Value
		{
			get
			{
				return m_value;
			}
			set
			{
				m_value = value;
			}
		}
	}
}

