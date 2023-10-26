using System;
using System.Collections.Generic;

namespace LeetCode3_1
{
    public class Program
    {
        public static void Main()
        {
            Solution s = new Solution();
            Console.WriteLine(s.FindMedianSortedArrays(new int[] { 1, 3}, new int[] {2}));
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int l=nums1.Length+nums2.Length,l1=nums1.Length,l2=nums2.Length,s1=0,s2=0,i=0;
            int[] nums3=new int[l];
            // nums1.CopyTo(nums3,0);
            // nums2.CopyTo(nums3,l1);
            while(i<l && s1<l1 && s2<l2){
                if(nums1[s1]<nums2[s2])
                {
                    nums3[i]=nums1[s1];
                    s1++;
                }
                else{
                    nums3[i]=nums2[s2];
                    s2++;
                }
                i++;
            }
            if(s1<l1){
                // nums1.CopyTo(nums3,i);
                while(s1<l1){
                    nums3[i]=nums1[s1];
                    s1++;
                    i++;
                }
            }
            if(s2<l2){
                // nums2.(nums3,i);
                while(s2<l2){
                    nums3[i]=nums2[s2];
                    s2++;
                    i++;
                }
            }

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
