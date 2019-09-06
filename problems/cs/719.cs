// Url:https://leetcode.com/problems/find-k-th-smallest-pair-distance

/*
719. Find K-th Smallest Pair Distance
Hard

Given an integer array, return the k-th smallest distance among all the pairs. The distance of a pair (A, B) is defined as the absolute difference between A and B. 

Example 1:
Input:
nums = [1,3,1]
k = 1
Output: 0 
Explanation:
Here are all the pairs:
(1,3) -&gt; 2
(1,1) -&gt; 0
(3,1) -&gt; 2
Then the 1st smallest distance pair is (1,1), and its distance is 0.



Note:

2 &lt;= len(nums) &lt;= 10000.
0 &lt;= nums[i] &lt; 1000000.
1 &lt;= k &lt;= len(nums) * (len(nums) - 1) / 2.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution719
{
    public class Solution
    {
        public void Init() { }

        public int SmallestDistancePair(int[] nums, int k) { }
    }
}
