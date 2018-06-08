using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.StringSearch
{
	public class StringSearchMatch : ISearchMatch
	{
		protected int m_start;
		protected int m_length;
		public StringSearchMatch(int start, int length)
		{
			m_start = start;
			m_length = length;
		}

		public int Length
		{
			get
			{
				return m_length;
			}
		}

		public int Start
		{
			get
			{
				return m_start;
			}
		}
	}
}
