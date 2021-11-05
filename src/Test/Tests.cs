using System.Collections.Generic;
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
            var res = TwoSum.Do(nums, target);
            Assert.AreEqual(res, expectedResult);
        }

        [TestCase("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [TestCase("", new string[] { })]
        [TestCase("2", new string[] { "a", "b", "c" })]
        public void LetterCombinationsTest(string digits, string[] expectedResult)
        {
            Assert.AreEqual(LetterCombinations.Do(digits), expectedResult);
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

        [TestCase]
        public void MergeTwoSortedListsTest()
        {
            var mergeTwoSortedLists = new MergeTwoSortedLists();
            var a = new ListNode(1, new ListNode(2, new ListNode(4)));
            var b = new ListNode(1, new ListNode(3, new ListNode(4)));

            var res = mergeTwoSortedLists.MergeTwoLists(a, b);

            Assert.IsTrue(res.val == 1);
            Assert.IsTrue(res.next.val == 1);
            Assert.IsTrue(res.next.next.val == 2);
            Assert.IsTrue(res.next.next.next.val == 3);
            Assert.IsTrue(res.next.next.next.next.val == 4);
            Assert.IsTrue(res.next.next.next.next.next.val == 4);
        }


        [TestCase(new int[] { 3, 0, 1 }, 2)]
        [TestCase(new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
        [TestCase(new int[] { 0 }, 1)]
        public void MissingNumberTest(int[] nums, int expectedValue)
        {
            var proc = new MissingNumber();

            var res = proc.Do(nums);

            Assert.AreEqual(res, expectedValue);
        }

        [TestCase(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 5, 6 })]
        [TestCase(new int[] { 1, 1 }, new int[] { 2 })]
        public void FindAllNumbersDisappearedInAnArrayTest(int[] nums, int[] expectedValues)
        {
            var proc = new FindAllNumbersDisappearedInAnArray();

            var res = proc.FindDisappearedNumbers(nums);

            Assert.AreEqual(res, expectedValues);
        }

        [TestCase]
        public void SummTreeNodes()
        {
            var proc = new SumNumbersProblem();
            var res = proc.SumNumbers(new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0)));

            Assert.AreEqual(res, 1026);
        }

        [TestCase]
        public void SumLeftLeaves()
        {
            var proc = new SumOfLeftLeavesProblem();
            var res = proc.Sum(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))));

            Assert.AreEqual(res, 24);
        }

        [TestCase(1, new string[] {"()"})]
        [TestCase(2, new string[] {"(())", "()()"})]
        [TestCase(3, new string[] {"((()))","(()())","(())()","()(())","()()()"})]
        public void GenerateParenthesesTest(int n, string[] expectedResult)
        {
            var proc = new GenerateParenthesesProblem();
            var res = proc.GenerateParentheses(n);

            Assert.AreEqual(res, expectedResult);
        }
    }
}