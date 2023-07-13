using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions;


namespace LeetCodeSolutions
{
    public class GroupAnagrams
    {
        public IList<IList<string>> Solution(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                String sorted = new String(arr);

                if (!dict.ContainsKey(sorted))
                {
                    dict.Add(sorted, new List<String>() { strs[i] });
                }
                else
                {
                    dict[sorted].Add(strs[i]);
                }
            }

            return dict.Values.ToList();
        }
    }
}
