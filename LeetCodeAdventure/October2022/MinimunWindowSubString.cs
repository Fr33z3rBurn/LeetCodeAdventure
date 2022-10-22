using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAdventure.October2022
{
	public class MinimunWindowSubString
	{
		//https://leetcode.com/problems/minimum-window-substring/
		//TODO
		public string MinWindow(string s, string t)
		{
			for (int i = 0; i < s.Length; i++)
			{
				for (int j = i + 1; j < s.Length; j++)
				{
					if ((j +i + 1 < s.Length) && s.Substring(i, j + 1).Contains(t))
					{
						return s.Substring(i, j + 1); ;
					}
				}
			}
			return String.Empty;
		}
	}
}
