using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Algos.StringSearch;

namespace Algos
{
	class Program
	{
		static void Main(string[] args)
		{
			//LinkedListTest();
			//StackTest();

			//BubbleSortTest();
			//QuickSortTest();
			//SelectionSortTest();

			//BinaryTreeTest();
			//StackArrayTest();

			//NaiveTextSearch();

			//MergeSortTest();

			Console.WriteLine("hit any key to continue");
			Console.ReadLine();
		}

		private static void SelectionSortTest()
		{
			int[] arr = { 5, 1, 12, -5, 16, 2, 12, 14 };

			ISort s = new SelectionSort();
			s.Sort<int>(arr, arr.Count());
			Utils<int>.PrintArray(arr, arr.Count());
		}

		private static void InsertionSortTest()
		{
			int[] arr = { 5, 1, 12, -5, 16, 2, 12, 14 };

			ISort s = new InsertionSort();
			s.Sort<int>(arr, arr.Count());
			Utils<int>.PrintArray(arr, arr.Count());
		}

		private static void MergeSortTest()
		{
			int[] arr = { 5, -4, 0, -10, 6 }; 

			ISort s = new MergeSort();
			s.Sort<int>(arr, arr.Count());
			Utils<int>.PrintArray(arr, arr.Count());
		}

		private static void NaiveTextSearch()
		{
			// this implementation does NOT find 2 "ll" in "lll"
			// it skips the full length of the found string 
			NaiveSearch naive = new NaiveSearch();
			IEnumerable<ISearchMatch> matches = naive.Search("I expect to find 2 llbb and llaa here", "ll");
			foreach (ISearchMatch m in matches)
				Console.WriteLine("{0} {1}", m.Start, m.Length);
		}

		private static void StackArrayTest()
		{
			IStack<double> s = new StackOverArray<double>();
			for (int i = 0; i < 15; i++)
				s.Push(i);

			while (!s.IsEmpty())
				Console.Write("{0} ", s.Pop());

			Console.Write("and now its empty {0} ", s.IsEmpty());

		}

		private static void BinaryTreeTest()
		{
			BinaryTree<int> b = new BinaryTree<int>();
			b.Insert(5);
			b.Print();

			b.Insert(2);
			b.Insert(6);
			b.Print();

			b.Insert(17);
			b.Insert(25);
			b.Insert(12);
			b.Insert(24);
			b.Print();

			TreeNode<int> t = b.Search(17);
			Console.WriteLine(t.elem);
 		}

		private static void BubbleSortTest()
		{
			int[] arr = { 5, -4, 0, -10, 6 };
			ISort b = new BubbleSort();
			b.Sort<int>(arr, arr.Count());
			Utils<int>.PrintArray(arr, arr.Count());
		}

		private static void QuickSortTest()
		{
			int[] arr = { 5, -4, 0, -10, 6 };
			ISort b = new QuickSort();
			b.Sort<int>(arr, arr.Count());
			Utils<int>.PrintArray(arr, arr.Count());
		}

		private static void StackTest()
		{
			IStack<int> stack = new Stack<int>();
			stack.Push(5);
			stack.Push(-6);
			stack.Push(7);
			Console.WriteLine(stack.Count());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.IsEmpty());
		}

		private static void LinkedListTest()
		{
			IList<string> list = new LinkedList<string>();
			list.InsertBefore("hello");
			list.InsertBefore("2 hellos");
			list.InsertBefore("greeting");

			Console.WriteLine(list.RemoveBefore().ToString());
			Console.WriteLine(list.RemoveBefore().ToString());
			Console.WriteLine(list.RemoveBefore().ToString());
		}
	}
}
