// Url:https://leetcode.com/problems/arithmetic-slices-ii-subsequence

/*
446. Arithmetic Slices II - Subsequence
Hard

A sequence of numbers is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.

For example, these are arithmetic sequences:

1, 3, 5, 7, 9
7, 7, 7, 7
3, -1, -5, -9

The following sequence is not arithmetic.

1, 1, 2, 5, 7
&#xA0;

A zero-indexed array A consisting of N numbers is given. A subsequence slice of that array is any sequence of integers (P0, P1, ..., Pk) such that 0 &#x2264; P0 &lt; P1 &lt; ... &lt; Pk &lt; N.

A subsequence slice (P0, P1, ..., Pk) of array A is called arithmetic if the sequence A[P0], A[P1], ..., A[Pk-1], A[Pk] is arithmetic. In particular, this means that k &#x2265; 2.

The function should return the number of arithmetic subsequence slices in the array A.

The input contains N integers. Every integer is in the range of -231 and 231-1 and 0 &#x2264; N &#x2264; 1000. The output is guaranteed to be less than 231-1.
&#xA0;

Example:

Input: [2, 4, 6, 8, 10]

Output: 7

Explanation:
All arithmetic subsequence slices are:
[2,4,6]
[4,6,8]
[6,8,10]
[2,4,6,8]
[4,6,8,10]
[2,4,6,8,10]
[2,6,10]
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution446
{
    public class Solution
    {
        public void Init() { }

        public int NumberOfArithmeticSlices(int[] A) { }
    }
}
