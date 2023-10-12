using System;
using System.Collections.Generic;

namespace LeetCode3
{
    public class Program
    {
        public static void Main()
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int l=nums1.Length+nums2.Length,l1=nums1.Length,l2=nums2.Length;
            int[] nums3=new int[l];
            nums1.CopyTo(nums3,0);
            nums2.CopyTo(nums3,l1);
            Array.Sort(nums3);
            if(l%2==0)
            {
                int x=l/2;
                return (double)(nums3[x]+nums3[x-1])/2;
            }
            else
            {
                return nums3[(l-1)/2];
            }
        }
    }
}
