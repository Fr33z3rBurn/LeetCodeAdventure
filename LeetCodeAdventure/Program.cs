using LeetCodeAdventure.October2022;

var Tkfw = new TopKFrequentWords();

var stringsArray = new string[] { "i", "love", "leetcode", "i", "love", "coding" };

var test = Tkfw.TopKFrequent(stringsArray, 2);

Console.WriteLine(test);