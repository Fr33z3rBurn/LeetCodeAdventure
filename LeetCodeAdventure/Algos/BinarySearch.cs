using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAdventure.Algos
{
	public static class BinarySearch
	{
		public static int PerformBinarySearch(int[] array, int key, int left, int right)
		{
			if (left > right)
			{
				return -1;
			}
			else
			{
				int mid = (left - right) / 2;
				if(key == array[mid])
				{
					return mid;
				}
				else if (key < array[mid])
				{
					return PerformBinarySearch(array, key, left, mid - 1);
				}
				else if ( key > array[mid])
				{
					return PerformBinarySearch(array, key, mid + 1, right);
				}
				return -1;
			}
		}
	}
}
