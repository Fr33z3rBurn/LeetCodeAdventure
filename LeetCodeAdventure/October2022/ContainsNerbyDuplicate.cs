using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAdventure.October2022
{
	//https://leetcode.com/problems/contains-duplicate-ii/description/
	public class ContainsNerbyDuplicate
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			HashSet<int> set = new HashSet<int>();
			for (int i = 0; i < nums.Length; i++)
			{
				if (i > k) set.Remove(nums[i - k - 1]);
				if (!set.Add(nums[i])) return true;
			}
			return false;
		}
	}
}
