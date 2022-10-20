using System;
namespace LeetCodeAdventure.October2022
{
	//https://leetcode.com/problems/top-k-frequent-words/
	public class TopKFrequentWords
	{
		public IList<string> TopKFrequent(string[] words, int k)
		{
			var distinctWords = words.ToArray().Select(x => x).Distinct().ToArray();
			var tupleList = new List<Tuple<int, string>>();
			foreach (var word in distinctWords)
			{
				var count = words.Where(x => x == word).Count();
				var theTuple = Tuple.Create<int, string>(count, word);
				tupleList.Add(theTuple);
			}
			var sortArray = tupleList.ToArray();
			Array.Sort(sortArray);
			Array.Reverse(sortArray);

			var anotherList = sortArray.OrderByDescending(x => x.Item1).ThenBy(y => y.Item2).ToList();
			var returnList = new List<string>();
			for (int i = 0; i < k; i++)
			{
				returnList.Add(anotherList[i].Item2);
			}

			return returnList;
		}
	}
}

