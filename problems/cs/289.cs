// Url:https://leetcode.com/problems/game-of-life

/*
289. Game of Life
Medium

According to the Wikipedia&apos;s article: &quot;The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970.&quot;

Given a board with m by n cells, each cell has an initial state live (1) or dead (0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):


	Any live cell with fewer than two live neighbors dies, as if caused by under-population.
	Any live cell with two or three live neighbors lives on to the next generation.
	Any live cell with more than three live neighbors dies, as if by over-population..
	Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.


Write a function to compute the next state (after one update) of the board given its current state.&#xA0;The next state is created by applying the above rules simultaneously to every cell in the current state, where&#xA0;births and deaths occur simultaneously.

Example:

Input: 
[
&#xA0; [0,1,0],
&#xA0; [0,0,1],
&#xA0; [1,1,1],
&#xA0; [0,0,0]
]
Output: 
[
&#xA0; [0,0,0],
&#xA0; [1,0,1],
&#xA0; [0,1,1],
&#xA0; [0,1,0]
]


Follow up:


	Could you solve it in-place? Remember that the board needs to be updated at the same time: You cannot update some cells first and then use their updated values to update other cells.
	In this question, we represent the board using a 2D array. In principle, the board is infinite, which would cause problems when the active area encroaches the border of the array. How would you address these problems?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution289
{
    public class Solution
    {
        public void Init() { }

        public void GameOfLife(int[][] board) { }
    }
}
