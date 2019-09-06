// Url:https://leetcode.com/problems/all-paths-from-source-to-target

/*
797. All Paths From Source to Target
Medium

Given a directed, acyclic graph of N nodes.&#xA0; Find all possible paths from node 0 to node N-1, and return them in any order.

The graph is given as follows:&#xA0; the nodes are 0, 1, ..., graph.length - 1.&#xA0; graph[i] is a list of all nodes j for which the edge (i, j) exists.

Example:
Input: [[1,2], [3], [3], []] 
Output: [[0,1,3],[0,2,3]] 
Explanation: The graph looks like this:
0---&gt;1
|    |
v    v
2---&gt;3
There are two paths: 0 -&gt; 1 -&gt; 3 and 0 -&gt; 2 -&gt; 3.


Note:


	The number of nodes in the graph will be in the range [2, 15].
	You can print different paths in any order, but you should keep the order of nodes inside one path.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution797
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph) { }
    }
}
