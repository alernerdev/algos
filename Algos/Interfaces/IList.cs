using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	interface IList<T>
	{
		void InsertBefore(T elem);
		T RemoveBefore();
	}
}
