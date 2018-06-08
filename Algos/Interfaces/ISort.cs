using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	interface ISort
	{
		void Sort<T>(T [] arr, int length) where T : IComparable<T>;
	}
}
