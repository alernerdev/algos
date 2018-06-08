using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.StringSearch
{
	/*
	 * average performance: O(n+m) where n is the source and m is the string to find
	 * worst: O(n*m)
	 * does NOT require pre-processing
	 */
	class NaiveSearch : IStringSearch
	{
		public IEnumerable<ISearchMatch> Search(string toSearch, string toFind)
		{
			if (toFind.Length == 0)
				yield break;

			if (toSearch.Length == 0)
				yield break; 

			// no point in searching if the length remaining is less than the string to find
			for (int startIndex = 0; startIndex < toSearch.Length - toFind.Length; startIndex++)
			{
				int charsMatched = 0;
				while (toFind[charsMatched] == toSearch[startIndex+charsMatched])
				{
					charsMatched++;
					if (toFind.Length == charsMatched)
					{
						// I found a full string!
						yield return new StringSearchMatch(startIndex, charsMatched);
						startIndex += charsMatched - 1; // subtract 1 because 1 is added on the next loop iteration

						break;
					}
				}
			}
		}
	}
}
