using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class ListNode<T>
	{
		public T elem;
		public ListNode<T> next;

		public ListNode(T e)
		{
			elem = e;
			next = null;
		}
	}
}
