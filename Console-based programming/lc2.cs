using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode2
{
    public class Program
    {
        public static void Main()
        {
            Solution s = new Solution();
            Console.WriteLine(s.MinOperations(new int[] { 1,1 },3));
        }
    }
    public class Solution {
    public int MinOperations(int[] nums, int x) {
        int l=nums.Length-1,s=0,c=0;
        if(nums[s]>x && nums[l]>x)
            return -1;
        if(nums[s]<x&&nums[l]>x)
            foreach(var i in nums){
                x-=i;
                c++;
                if(x==0)
                    return c;
                if(x<0)
                    break;
            }
        if(nums[s]>x&&nums[l]<x)
            for(int i=l;i>=0;i--){
                x-=nums[i];
                c++;
                if(x==0)
                    return c;
                if(x<0)
                    break;
            }
        while(x>0 && s<l ){
            if(nums[s]>=nums[l]&&nums[s]<=x)
                {x-=nums[s];
                s++;
                c++;}

            if(nums[s]<nums[l]&&nums[l]<=x)
                {x-=nums[l];
                l--;
                c++;}

            if(nums[l]>x&&nums[s]<=x)
                {x-=nums[s];
                s++;
                c++;}
            
            if(nums[s]>x&&nums[l]<=x)
                {x-=nums[l];
                l--;
                c++;}

            if(x==0)
                return c;

            if(nums[s]>x && nums[l]>x)
                return -1;
        }

      return -1;  
    }
}
}