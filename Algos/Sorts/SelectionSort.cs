using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	public class SelectionSort : ISort
	{
		public void Sort<T>(T[] arr, int length) where T : IComparable<T>
		{
			/* The algorithm divides the input list into two parts: 
			 * the sublist of items already sorted, which is built up from left to right at the front (left)of the list, 
			 * and the sublist of items remaining to be sorted that occupy the rest of the list.
			 * Initially, the sorted sublist is empty and the unsorted sublist is the entire input list.
			 * The algorithm proceeds by finding the smallest(or largest, depending on sorting order) 
			 * element in the unsorted sublist, exchanging(swapping) it with the leftmost unsorted 
			 * element(putting it in sorted order), and moving the sublist boundaries one element to the right
			 */
			for (int i = 0; i < length - 1; i++) // start off with the whole array
			{
				// leftmost unsorted position
				int index = i;

				// INNER LOOP GOES OVER UNSORTED ELMENTS

				// figure out the smallest number in the unsorted part -- and remember it
				for (int j = i + 1; j < length; j++) // move over the unsorted part
					if (arr[j].CompareTo(arr[index]) < 0) // arr[[j] < arr[index]
						index = j;

				Utils<T>.Swap(arr, index, i);
			}
		}
	}
}


