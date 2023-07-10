using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTesting{
    [Testclass]
    public class AnagramTesting{
        [TestMethod]
        public void Example1(){
           
            Solution.isAnagram("anagram", "nanagram");
        }
    }
}

namespace LeetCode{

    public static void main(string[] args){
   
    }

    public class Solution {
        public static bool IsAnagram(string s, string t) {
            Dictionary<char, int> first = new();
        }
    }
}