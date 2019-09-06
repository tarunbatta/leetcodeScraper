// Url:https://leetcode.com/problems/flipping-an-image

/*
832. Flipping an Image
Easy

Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.&#xA0; For example, flipping&#xA0;[1, 1, 0]&#xA0;horizontally results in&#xA0;[0, 1, 1].

To invert an image means&#xA0;that each 0 is replaced by 1, and each 1 is replaced by 0.&#xA0;For example, inverting&#xA0;[0, 1, 1]&#xA0;results in&#xA0;[1, 0, 0].

Example 1:

Input: [[1,1,0],[1,0,1],[0,0,0]]
Output: [[1,0,0],[0,1,0],[1,1,1]]
Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]


Example 2:

Input: [[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]


Notes:


	1 &lt;= A.length = A[0].length &lt;= 20
	0 &lt;= A[i][j]&#xA0;&lt;=&#xA0;1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution832
{
    public class Solution
    {
        public void Init() { }

        public int[][] FlipAndInvertImage(int[][] A) { }
    }
}
