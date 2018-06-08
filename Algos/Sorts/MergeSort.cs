using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class MergeSort : ISort
	{
		public void Sort<T>(T[] arr, int length) where T : IComparable<T>
		{
			_sort(arr, 0, length -1);
		}

		protected void _sort<T>( T [] arr, int left, int right) where T : IComparable<T>
		{
			int mid;

			Console.WriteLine("_sort: left {0} right {1}", left, right);

			// keep splitting the array till you end up with left and right arrays of size 1

			if (right > left)
			{
				mid = (right + left) / 2;
				_sort(arr, left, mid);
				_sort(arr, (mid + 1), right);

				_merge(arr, left, (mid + 1), right);
			}
		}

		static public void _merge<T>(T[] arr, int left, int mid, int right) where T : IComparable<T>
		{
			Console.WriteLine("_merge: left {0} mid {1} right {2}", left, mid, right);

			T [] results = new T[25];
			int i, left_end, num_elements, results_pos;

			left_end = (mid - 1);
			results_pos = left;
			num_elements = (right - left + 1);

			// imagine you have left and right arrays here and you compare the start of left and right array and
			// keep taking whatever is smaller while "popping" the front of that array
			while ((left <= left_end) && (mid <= right))
			{
				if (arr[left].CompareTo(arr[mid]) <= 0)
					results[results_pos++] = arr[left++];
				else
					results[results_pos++] = arr[mid++];
			}

			// we have reached the end of either left or right array.  Copy over whatever is left over.  Only one "branch" still has data --
			// the other is empty
			while (left <= left_end)
				results[results_pos++] = arr[left++];

			while (mid <= right)
				results[results_pos++] = arr[mid++];

			// finally copy sorted data into the original array
			for (i = 0; i < num_elements; i++)
			{
				arr[right] = results[right];
				right--;
			}
		}

	}
}


