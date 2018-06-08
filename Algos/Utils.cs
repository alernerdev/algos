using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	class Utils<T>
	{
		public static void Swap(T [] arr, int i1, int i2)
		{
			T temp = arr[i1];
			arr[i1] = arr[i2];
			arr[i2] = temp;
		}

		public static void PrintArray(T [] arr, int length)
		{
			for (int i = 0; i < length; i++)
			{
				Console.Write( arr[i]);
				Console.Write(" ");
			}
			Console.WriteLine("");
		}

	}
}
