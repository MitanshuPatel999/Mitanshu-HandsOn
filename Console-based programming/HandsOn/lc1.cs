using System;
using System.Collections.Generic;

namespace LeetCode1
{
    public class Program
    {
        public static void Main()
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindDuplicate(new int[] { 1, 3, 4, 2, 2 }));
        }
    }
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            IDictionary<int, int?> d = new Dictionary<int, int?>();
            int k = 0;
            foreach (var i in nums)
            {
                k = i;
                if (!d.ContainsKey(k))
                    d[k] = null;
                else
                {
                    return k;
                }

            }
            return 0;
        }
    }
}