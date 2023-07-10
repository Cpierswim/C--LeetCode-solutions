using LeetCodeSolutions;
using FluentAssertions;

namespace LeetCode_Tests
{
    public class AnagramUnitTest
    {
        [Fact]
        public void Example1()
        {
            var result = new Anagram().IsAnagram("anagram", "nagaram");
            result.Should().BeTrue();
        }
        [Fact] 
        public void Example2()
        {
            var result = new Anagram().IsAnagram("cat", "rat");
            result.Should().BeFalse();
        }
    }
}