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

        [TestCase]
        public void RemoveNthFromEndTest()
        {
            var removeNthFromEnd = new RemoveNthFromEndProblem();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7)))))));
            
            removeNthFromEnd.RemoveNthFromEnd(head, 2);

            Assert.IsTrue(head.next.next.next.next.next.val == 7);
        }

        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("([)]", false)]
        [TestCase("{[]}", true)]
        public void ValidParenthesesTest(string input, bool expectedResult)
        {
            var validParentheses = new ValidParentheses();
            var res = validParentheses.IsValid(input);

            Assert.AreEqual(res, expectedResult); 
        }
        
    }
}