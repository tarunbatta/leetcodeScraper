// Url:https://leetcode.com/problems/flatten-nested-list-iterator

/*
341. Flatten Nested List Iterator
Medium

Given a nested list of integers, implement an iterator to flatten it.

Each element is either an integer, or a list -- whose elements may also be integers or other lists.

Example 1:


Input: [[1,1],2,[1,1]]
Output: [1,1,2,1,1]
Explanation: By calling next repeatedly until hasNext returns false, 
&#xA0;            the order of elements returned by next should be: [1,1,2,1,1].


Example 2:

Input: [1,[4,[6]]]
Output: [1,4,6]
Explanation: By calling next repeatedly until hasNext returns false, 
&#xA0;            the order of elements returned by next should be: [1,4,6].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution341
{
    /** * // This is the interface that allows for creating nested lists. * // You should not implement it, or speculate about its implementation * interface NestedInteger { * *     // @return true if this NestedInteger holds a single integer, rather than a nested list. *     bool IsInteger(); * *     // @return the single integer that this NestedInteger holds, if it holds a single integer *     // Return null if this NestedInteger holds a nested list *     int GetInteger(); * *     // @return the nested list that this NestedInteger holds, if it holds a nested list *     // Return null if this NestedInteger holds a single integer *     IList<NestedInteger> GetList(); * } */
    public class NestedIterator {​    public NestedIterator(IList<NestedInteger> nestedList) { }​    public bool HasNext() { }​    public int Next() { } }​/** * Your NestedIterator will be called like this: * NestedIterator i = new NestedIterator(nestedList); * while (i.HasNext()) v[f()] = i.Next(); *
}
