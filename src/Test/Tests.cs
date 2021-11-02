using LeetCode.Problems;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTest(int[] nums, int target, int[] expectedResult)
        {
            var res = TwoSum.Main(nums, target);
            Assert.AreEqual(res, expectedResult);
        }

        [TestCase("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [TestCase("", new string[] { })]
        [TestCase("2", new string[] { "a", "b", "c" })]
        public void LetterCombinationsTest(string digits, string[] expectedResult)
        {
            Assert.AreEqual(LetterCombinations.Main(digits), expectedResult);
        }
        
    }
}