using System;
using System.Text;

namespace LeetCodeAdventure.October2022
{
	public class ArrayStrings
	{
		public bool ArrayStringsAreEqual(string[] word1, string[] word2)
		{
			var sb1 = new StringBuilder();
			var sb2 = new StringBuilder();

			foreach (var word in word1)
			{
				sb1.Append(word);
			}
			foreach (var word in word2)
			{
				sb2.Append(word);
			}

			if(sb1.ToString() == sb2.ToString())
			{
				return true;
			}
			return false;
		}
	}
}

