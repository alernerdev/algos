using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class LinkedList<T> : IList<T>
	{
		ListNode<T> m_root = null;

		public void InsertBefore(T elem)
		{
			ListNode<T> node = new ListNode<T>(elem);

			if (m_root == null)
			{
				m_root = node;
				return;
			}

			node.next = m_root;
			m_root = node;
		}

		public T RemoveBefore()
		{
			if (m_root == null)
				return default(T);

			ListNode<T> node = m_root;
			m_root = m_root.next;

			return node.elem;
		}
	}
}
