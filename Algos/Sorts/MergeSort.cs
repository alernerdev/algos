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

			T [] temp = new T[25];
			int i, left_end, num_elements, tmp_pos;

			left_end = (mid - 1);
			tmp_pos = left;
			num_elements = (right - left + 1);

			while ((left <= left_end) && (mid <= right))
			{
				if (arr[left].CompareTo(arr[mid]) <= 0)
					temp[tmp_pos++] = arr[left++];
				else
					temp[tmp_pos++] = arr[mid++];
			}

			while (left <= left_end)
				temp[tmp_pos++] = arr[left++];

			while (mid <= right)
				temp[tmp_pos++] = arr[mid++];

			for (i = 0; i < num_elements; i++)
			{
				arr[right] = temp[right];
				right--;
			}
		}

	}
}


