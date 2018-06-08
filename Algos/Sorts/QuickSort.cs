using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	/* divide and conquer algorithm
	
	worst case: can be as bad as O(n squared)
	avg: O(n log n )
	best case: O(n log n)

	space: its O(n)
	*/

	class QuickSort : ISort
	{
		public void Sort<T>(T [] arr, int length) where T : IComparable<T>
		{
			doSort(arr, 0, length - 1);
		}

		protected void doSort<T>(T [] arr, int lowerIndex, int upperIndex) where T : IComparable<T>
		{
			int i = lowerIndex;
			int j = upperIndex;
			int pivotIndex = i + (j - i) / 2;
			T pivot = arr[pivotIndex];

			while (i < j)
			{
				while (arr[i].CompareTo(pivot) < 0)  // arr[i] < pivot
					i++;

				while (arr[j].CompareTo(pivot) > 0) // arr[j] > pivot
					j--;

				if (i <= j)
				{
					Utils<T>.Swap(arr, i, j);
					i++;
					j--;
				}
			}

			if (lowerIndex < j)
				doSort(arr, lowerIndex, j);

			if (i < upperIndex)
				doSort(arr, i, upperIndex);
		}

	}
}