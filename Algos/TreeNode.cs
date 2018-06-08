using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class TreeNode<T> where T : IComparable
	{
		public T elem;
		public TreeNode<T> left;
		public TreeNode<T> right;

		public TreeNode(T e)
		{
			elem = e;
			left = null;
			right = null;
		}
	}
}
