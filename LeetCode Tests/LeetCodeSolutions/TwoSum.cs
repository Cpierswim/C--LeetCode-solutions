using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class TwoSum
    {
        public int[] BruteForceSolution(int[] nums, int target)
        {
            int[] result = new int[2];
            bool found = false;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        found = true;
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
                if (found)
                    break;
            }

            return result;
        }

        public int[] HashMapSolution(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]) && nums[i] + nums[i] == target)
                    return new int[] { map[nums[i]], i };
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }

            int[] result = new int[2];
            var keys = map.Keys.ToArray();
            for (int i = 0; i < keys.Length; i++)
            {
                var number = keys[i];
                if(map.ContainsKey(target - number) && keys[i] != target-number)
                {
                    result[0] = map[keys[i]];
                    result[1] = map[target- number];
                    break;
                }
            }
                

            return result;
        }
    }
}
