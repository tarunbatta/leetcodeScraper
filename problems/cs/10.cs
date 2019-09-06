// Url:https://leetcode.com/problems/regular-expression-matching

/*
10. Regular Expression Matching
Hard

Given an input string (s) and a pattern (p), implement regular expression matching with support for &apos;.&apos; and &apos;*&apos;.

&apos;.&apos; Matches any single character.
&apos;*&apos; Matches zero or more of the preceding element.


The matching should cover the entire input string (not partial).

Note:


	s&#xA0;could be empty and contains only lowercase letters a-z.
	p could be empty and contains only lowercase letters a-z, and characters like&#xA0;.&#xA0;or&#xA0;*.


Example 1:

Input:
s = &quot;aa&quot;
p = &quot;a&quot;
Output: false
Explanation: &quot;a&quot; does not match the entire string &quot;aa&quot;.


Example 2:

Input:
s = &quot;aa&quot;
p = &quot;a*&quot;
Output: true
Explanation:&#xA0;&apos;*&apos; means zero or more of the preceding&#xA0;element, &apos;a&apos;. Therefore, by repeating &apos;a&apos; once, it becomes &quot;aa&quot;.


Example 3:

Input:
s = &quot;ab&quot;
p = &quot;.*&quot;
Output: true
Explanation:&#xA0;&quot;.*&quot; means &quot;zero or more (*) of any character (.)&quot;.


Example 4:

Input:
s = &quot;aab&quot;
p = &quot;c*a*b&quot;
Output: true
Explanation:&#xA0;c can be repeated 0 times, a can be repeated 1 time. Therefore, it matches &quot;aab&quot;.


Example 5:

Input:
s = &quot;mississippi&quot;
p = &quot;mis*is*p*.&quot;
Output: false
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution10
{
    public class Solution
    {
        public void Init() { }

        public bool IsMatch(string s, string p) { }
    }
}
