using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
	interface IStack<T>
	{
		void Push(T elem);
		T Pop();
		int Count();
		bool IsEmpty();
	}
}
