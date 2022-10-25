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
			Array.Sort(nums);
			int missingNo = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != i + 1)
				{
					missingNo = i + 1;
					break;
				}
			}
			return new int[] { dupNum, missingNo };
		}
	}
}

