using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class StackOverArray<T> : IStack<T> where T : new()
	{
		private int m_stackSize;
		private int m_top;
		private T[] m_arr;

		public StackOverArray()
		{
			m_stackSize = 5;
			m_top = -1;
			m_arr = new T[m_stackSize];
		}

		public int Count()
		{
			return m_top;
		}

		public bool IsEmpty()
		{
			return m_top == -1;
		}

		public T Pop()
		{
			if (m_top == -1)
				throw new InvalidOperationException();

			return m_arr[m_top--];
		}

		public void Push(T elem)
		{
			if (m_top < m_stackSize - 1)
			{
				m_arr[++m_top] = elem;
				return;
			}

			T[] newArr = new T[m_stackSize * 2];
			for (int i = 0; i <= m_top; i++)
				newArr[i] = m_arr[i];

			newArr[++m_top] = elem;
			m_arr = newArr;
			m_stackSize *= 2;
		}
	}
}
