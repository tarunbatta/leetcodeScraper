// Url:https://leetcode.com/problems/string-to-integer-atoi

/*
8. String to Integer (atoi)
Medium

Implement atoi which&#xA0;converts a string to an integer.

The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

If no valid conversion could be performed, a zero value is returned.

Note:


	Only the space character &apos; &apos; is considered as whitespace character.
	Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [&#x2212;231,&#xA0; 231&#xA0;&#x2212; 1]. If the numerical value is out of the range of representable values, INT_MAX (231&#xA0;&#x2212; 1) or INT_MIN (&#x2212;231) is returned.


Example 1:

Input: &quot;42&quot;
Output: 42


Example 2:

Input: &quot;   -42&quot;
Output: -42
Explanation: The first non-whitespace character is &apos;-&apos;, which is the minus sign.
&#xA0;            Then take as many numerical digits as possible, which gets 42.


Example 3:

Input: &quot;4193 with words&quot;
Output: 4193
Explanation: Conversion stops at digit &apos;3&apos; as the next character is not a numerical digit.


Example 4:

Input: &quot;words and 987&quot;
Output: 0
Explanation: The first non-whitespace character is &apos;w&apos;, which is not a numerical 
&#xA0;            digit or a +/- sign. Therefore no valid conversion could be performed.

Example 5:

Input: &quot;-91283472332&quot;
Output: -2147483648
Explanation: The number &quot;-91283472332&quot; is out of the range of a 32-bit signed integer.
&#xA0;            Thefore INT_MIN (&#x2212;231) is returned.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution8
{
public class Solution {    public int MyAtoi(string str) {            }
}
