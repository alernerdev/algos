using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.StringSearch
{
	public interface ISearchMatch
	{
		int Start { get; }
		int Length { get; }
	}

	public interface IStringSearch
	{
		IEnumerable<ISearchMatch> Search(string toSearch, string toFind);
	}
}
