using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAdventure.July2022
{
	public class FibonacciNumber
	{
		public int Fib(int n)
		{
			if (n <= 1 )
			{
				return n;
			}

			return Fib(n - 1) + Fib(n - 2);
		}
	}
}
