using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class BubbleSort : ISort
	{
		/*
		worst case: O(n squared)
		avg: O(n squared)
		best case for data thats already sorted: O(n)

		benefit: performed entirely in place.  No extra allocations neeeded -- space efficient
	*/

		public void Sort<T>(T [] arr, int length) where T : IComparable<T>
		{
			bool swapped = false;

			// looks like the worst case is when the array is sorted in wrong order.
			// Each value needs to bubble up down the line

			// 2 loops indexes are independent of each other
			for (int j = length - 1; j >= 0; j--) // and this is how many times
			{
				for (int i = 0; i < length - 1; i++) // for the entire array duration
				{
					if (arr[i].CompareTo(arr[i + 1]) > 0)
					{
						Utils<T>.Swap(arr, i, i + 1);
						swapped = true;
					}
				}

				// if nothing got swapped, break out of the loop -- done.
				if (!swapped)
					break;

				swapped = false;
			}
		}
	}
}
