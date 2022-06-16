using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAdventure.June2022
{
	public class LongestPalindromicSubstring
	{
		//https://leetcode.com/problems/longest-palindromic-substring/

		public string LongestPalindrome(string s)
		{
			if (s.Length == 1)
			{
				return s;
			}
			string candidate = "";
			string longestPalindrome = "";

			for (int i = 0; i < s.Length; i++)
			{
				for (int j = 0; j < s.Length; j++)
				{
					if ((i + j) <= s.Length)
					{
						if (s.Substring(i, j) == ReverseString(s.Substring(i, j)))
						{
							//is palendrome check length
							if (s.Substring(i, j).Length > candidate.Length)
							{
								candidate = (s.Substring(i, j));
							}
							if (candidate.Length > longestPalindrome.Length)
							{
								longestPalindrome = candidate;
							}
						}
					}
				}
			}

			return longestPalindrome;
		}

		private string ReverseString(string stringToReverse)
		{
			char[] array = stringToReverse.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}
	}
}
