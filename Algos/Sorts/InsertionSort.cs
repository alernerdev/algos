using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class InsertionSort : ISort
	{
		/* similar to bubble sort in characteristics even though its a single pass algorithm
		worst case: O(n squared)
		avg: O(n squared)
		best case for data thats already sorted: O(n)

		benefit: performed entirely in place.  No extra allocations neeeded -- space efficient
		*/

		public void Sort<T>(T [] arr, int length) where T : IComparable<T>
		{
			bool swapped = false;

			for (int i = 1; i < length; i++) // for all elements
			{
				// INNER LOOP GOES OVER SORTED ELMENTS

				for (int j = i; j > 0; j--) // take the next element and compare to elements to the left
				{
					if (arr[j].CompareTo(arr[j - 1]) < 0)  // arr[j] < arr[j - 1]
					{
						swapped = true;

						Utils<T>.Swap(arr, j, j - 1);
					}

					if (!swapped)
						break;
				}

				swapped = false;
			}
		}
	}
}
