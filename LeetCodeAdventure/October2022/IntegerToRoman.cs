using System;
using System.Text;

namespace LeetCodeAdventure.October2022
{
	//https://leetcode.com/problems/integer-to-roman/
	public class IntegerToRoman
	{
		public string IntToRoman(int num)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < num / 1000; i++)
			{
				sb.Append("M");
			}
			num -= ((num / 1000) * 1000);
			for (int i = 0; i < num / 500; i++)
			{
				sb.Append("D");
			}
			num -= ((num / 500) * 500);
			for (int i = 0; i < num / 100; i++)
			{
				sb.Append("C");
			}
			num -= ((num / 100) * 100);
			for (int i = 0; i < num / 50; i++)
			{
				sb.Append("L");
			}
			num -= ((num / 50) * 50);
			for (int i = 0; i < num / 10; i++)
			{
				sb.Append("X");
			}
			num -= ((num / 10) * 10);
			for (int i = 0; i < num / 5; i++)
			{
				sb.Append("V");
			}
			num -= ((num / 5) * 5);
			for (int i = 0; i < num / 1; i++)
			{
				sb.Append("I");
			}

			return sb.ToString().Replace("IIII", "IV").Replace("VIV", "IX").Replace("XXXX", "XL").Replace("LXL", "XC").Replace("CCCC", "CD").Replace("DCD", "CM");
		}
	}
}

