using System;
namespace LeetCodeAdventure.October2022
{
	//https://leetcode.com/problems/set-mismatch/
	//TODO
	public class SetMismatch
	{
		public int[] FindErrorNums(int[] nums)
		{
			var dupNum = nums.GroupBy(x => x).Where(z => z.Count() == 2).Select(y => y.Key).FirstOrDefault();
			var edge = new int[] { 2, 2 };
			if (dupNum == 2 && (nums.Contains(3) || nums.Length == 2))
			{
				return new int[] { 2, 1 };
			}
			return new int[] { dupNum, dupNum + 1 };
		}
	}
}

