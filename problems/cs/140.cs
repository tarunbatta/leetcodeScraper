// Url:https://leetcode.com/problems/word-break-ii

/*
140. Word Break II
Hard

Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, add spaces in s to construct a sentence where each word is a valid dictionary word.&#xA0;Return all such possible sentences.

Note:


	The same word in the dictionary may be reused multiple times in the segmentation.
	You may assume the dictionary does not contain duplicate words.


Example 1:

Input:
s = &quot;catsanddog&quot;
wordDict = [&quot;cat&quot;, &quot;cats&quot;, &quot;and&quot;, &quot;sand&quot;, &quot;dog&quot;]
Output:
[
&#xA0; &quot;cats and dog&quot;,
&#xA0; &quot;cat sand dog&quot;
]


Example 2:

Input:
s = &quot;pineapplepenapple&quot;
wordDict = [&quot;apple&quot;, &quot;pen&quot;, &quot;applepen&quot;, &quot;pine&quot;, &quot;pineapple&quot;]
Output:
[
&#xA0; &quot;pine apple pen apple&quot;,
&#xA0; &quot;pineapple pen apple&quot;,
&#xA0; &quot;pine applepen apple&quot;
]
Explanation: Note that you are allowed to reuse a dictionary word.


Example 3:

Input:
s = &quot;catsandog&quot;
wordDict = [&quot;cats&quot;, &quot;dog&quot;, &quot;sand&quot;, &quot;and&quot;, &quot;cat&quot;]
Output:
[]
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution140
{
    public class Solution
    {
        public void Init() { }

        public IList<string> WordBreak(string s, IList<string> wordDict) { }
    }
}
