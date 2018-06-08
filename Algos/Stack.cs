using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class Stack<T> : LinkedList<T>, IStack<T>
	{
		protected int m_count;

		public Stack()
		{
			m_count = 0;
		}

		public int Count()
		{
			return m_count;
		}

		public bool IsEmpty()
		{
			return m_count == 0;
		}

		public T Pop()
		{
			T node = RemoveBefore();
			if (node != null)
				m_count--;

			return node;
		}

		public void Push(T elem)
		{
			InsertBefore(elem);
			m_count++;
		}
	}
}
