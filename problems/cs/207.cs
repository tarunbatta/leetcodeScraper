// Url:https://leetcode.com/problems/course-schedule

/*
207. Course Schedule
Medium

There are a total of n courses you have to take, labeled from 0 to n-1.

Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]

Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

Example 1:

Input: 2, [[1,0]] 
Output: true
Explanation:&#xA0;There are a total of 2 courses to take. 
&#xA0;            To take course 1 you should have finished course 0. So it is possible.

Example 2:

Input: 2, [[1,0],[0,1]]
Output: false
Explanation:&#xA0;There are a total of 2 courses to take. 
&#xA0;            To take course 1 you should have finished course 0, and to take course 0 you should
&#xA0;            also have finished course 1. So it is impossible.


Note:


	The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
	You may assume that there are no duplicate edges in the input prerequisites.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution207
{
    public class Solution
    {
        public void Init() { }

        public bool CanFinish(int numCourses, int[][] prerequisites) { }
    }
}
