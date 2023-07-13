using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;
using FluentAssertions;

namespace LeetCode_Tests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 2, 5, 5, 11 }, 10, new int[] { 1, 2 })]
        public void Tests(int[] nums, int target, int[] answer)
        {
            //var result = new TwoSum().BruteForceSolution(nums, target);
            var result = new TwoSum().HashMapSolution(nums, target);
            result.Should().BeEquivalentTo(answer);
        }
    }
}
