namespace LeetCodeSolutions
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            var s_dictionary = getDictionaryOfCharOccurances(s);
            var t_dictionary = getDictionaryOfCharOccurances(t);

            bool equal = false;
            if (s_dictionary.Count == t_dictionary.Count) // Require equal count.
            {
                equal = true;
                foreach (var pair in s_dictionary)
                {
                    int value;
                    if (t_dictionary.TryGetValue(pair.Key, out value))
                    {
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
            }
            return equal;
        }

        private Dictionary<char, int> getDictionaryOfCharOccurances(string s)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach(char c in s.ToCharArray())
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                } else { 
                    charCounts[c] = 0;
                }
            }
            return charCounts;
        }
    }
}