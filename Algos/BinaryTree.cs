using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class BinaryTree<T> where T : IComparable
	{
		protected TreeNode<T> m_root = null;

		public void Print()
		{
			if (m_root == null)
				return;

			print(m_root);
		}

		public void BreadthPrint()
		{
			if (m_root == null)
				return;

			Queue<TreeNode<T>> q = new Queue<TreeNode<T>>();
			q.Enqueue(m_root);

			TreeNode<T> node;
			while (q.Count > 0)
			{
				node = q.Dequeue();
				Console.Write(node.elem);
				Console.Write(" ");

				if (node.left != null)
					q.Enqueue(node.left);

				if (node.right != null)
					q.Enqueue(node.right);
			}
		}

		void print(TreeNode<T> leaf) 
		{
			if (leaf == null)
				return;

			// pre-order: node first.   Left then right
			// in-order: left, node, right
			// post order: left, right, node

			print(leaf.left);
			Console.Write(leaf.elem);
			Console.Write(" ");
			print(leaf.right);
		}

		public void Insert(T elem) 
		{
			if (m_root ==null)
			{
				m_root = new TreeNode<T>(elem);
				return;
			}

			insert(elem, m_root);
		}

		public TreeNode<T> Search(T value)
		{
			if (m_root == null )
				return null;

			return search(value, m_root);
		}

		public void Clear()
		{
			clear(m_root);
		}

		protected TreeNode<T> search(T value, TreeNode<T> leaf)
		{
			if (leaf == null)
				return null; //not found

			if (value.CompareTo(leaf.elem) == 0)
				return leaf;
			else if (leaf.right != null)
			{
				if (value.CompareTo(leaf.right.elem) >= 0)
					return search(value, leaf.right);
				else
					return search(value, leaf.left);
			}
			else
				return search(value, leaf.left);
		}

		protected void clear(TreeNode<T> leaf)
		{
			if (leaf == null)
				return;

			clear(leaf.left);
			clear(leaf.right);

			// free up leaf resources here
		}

		protected void insert(T value, TreeNode<T> leaf) 
		{
			if (value.CompareTo(leaf.elem) < 0)
			{
				if (leaf.left != null)
					insert(value, leaf.left);
				else
				{
					leaf.left = new TreeNode<T>(value);
				}
			}
			else
			{
				if (leaf.right != null)
					insert(value, leaf.right);
				else
				{
					leaf.right = new TreeNode<T>(value);
				}
			}
		}
	}
}
