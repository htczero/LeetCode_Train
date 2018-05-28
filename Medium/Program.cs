using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Abs(int.MinValue));
            Solution s = new Solution();
            //s.Divide(10, 3);
            char[,] ch = { { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'X' }, { 'O', 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'X' }, { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' }, { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' }, { 'X', 'X', 'O', 'O', 'X', 'O', 'X', 'O', 'X' }, { 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O' }, { 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O' } };
            s.Solve(ch);
            Console.ReadKey();
        }
    }

    class Solution
    {
        #region 2. Add Two Numbers
        //You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        //Example

        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
                return l1 == null ? l2 : l1;
            ListNode head = new ListNode(0);
            ListNode res = head;
            ListNode m = l1, n = l2;

            int c = 0;
            while (m != null && n != null)
            {
                int sum = m.val + n.val + c;
                head.next = new ListNode(sum % 10);
                c = sum / 10;
                head = head.next;
                m = m.next;
                n = n.next;
            }
            m = m == null ? n : m;
            while (m != null)
            {
                int sum = m.val + c;
                head.next = new ListNode(sum % 10);
                c = sum / 10;
                head = head.next;
            }
            return res.next;
        }
        #endregion

        #region 5. Longest Palindromic Substring
        //Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.

        //Example 1:

        //Input: "babad"
        //Output: "bab"
        //Note: "aba" is also a valid answer.
        //Example 2:

        //Input: "cbbd"
        //Output: "bb"

        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return s;
            int max = 1, pos = 0;
            for (int i = 0; s.Length - i + 1 > max; i++)
            {
                for (int j = s.Length - 1; j > i; j--)
                {
                    if (s[j] == s[i])
                    {
                        int x = i + 1, y = j - 1;
                        while (x < y && s[x] == s[y])
                        {
                            x++; y--;
                        }
                        if (x >= y && max < j - i + 1)
                        {
                            max = j - i + 1;
                            pos = i;
                            break;
                        }
                    }
                }
            }
            return s.Substring(pos, max);
        }

        public string LongestPalindrome2(string s)
        {
            if (s.Length <= 1)
                return s;
            int max = 1, pos = 0;
            int[] mark = new int[128];
            for (int i = 0; i < s.Length; i++)
            {
                mark[s[i]] = i;
            }
            for (int i = 0; i < s.Length - max; i++)
            {
                for (int j = mark[s[i]]; j > i; j--)
                {
                    if (s[j] == s[i])
                    {
                        int x = i + 1, y = j - 1;
                        while (x < y && s[x] == s[y])
                        {
                            x++; y--;
                        }
                        if (x >= y && max < j - i + 1)
                        {
                            max = j - i + 1;
                            pos = i;
                            break;
                        }
                    }
                }
            }
            return s.Substring(pos, max);
        }
        #endregion

        #region 6. ZigZag Conversion  **
        //The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

        //P   A   H   N
        //A P L S I I G
        //Y   I   R
        //And then read line by line: "PAHNAPLSIIGYIR"

        //Write the code that will take a string and make this conversion given a number of rows:

        //string convert(string s, int numRows);
        //Example 1:

        //Input: s = "PAYPALISHIRING", numRows = 3
        //Output: "PAHNAPLSIIGYIR"
        //Example 2:

        //Input: s = "PAYPALISHIRING", numRows = 4
        //Output: "PINALSIGYAHRPI"
        //Explanation:

        //P     I    N
        //A   L S  I G
        //Y A   H R
        //P     I
        public string Convert(string s, int numRows)
        {
            if (numRows <= s.Length)
                return s;
            int n = (numRows - 1) << 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= numRows; i++)
            {
                int pos = i, next = i;
                while (pos < s.Length)
                {
                    sb.Append(s[pos - 1]);
                    next = n - next;
                    next = next == 0 ? n : next;
                    pos = pos + next;
                }

            }
            return null;
        }
        #endregion

        #region 8. String to Integer (atoi)
        //Implement atoi which converts a string to an integer.

        //The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

        //The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

        //If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

        //If no valid conversion could be performed, a zero value is returned.

        //Note:
        //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN (−231) is returned.

        //Example 1:

        //Input: "42"
        //Output: 42
        //Example 2:

        //Input: "   -42"
        //Output: -42
        //Explanation: The first non-whitespace character is '-', which is the minus sign.
        //             Then take as many numerical digits as possible, which gets 42.
        //Example 3:

        //Input: "4193 with words"
        //Output: 4193
        //Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.
        //Example 4:

        //Input: "words and 987"
        //Output: 0
        //Explanation: The first non-whitespace character is 'w', which is not a numerical 
        //             digit or a +/- sign. Therefore no valid conversion could be performed.
        //Example 5:

        //Input: "-91283472332"
        //Output: -2147483648
        //Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer.
        //             Thefore INT_MIN (−231) is returned.
        public int MyAtoi(string str)
        {
            if (str == null || str.Length == 0)
                return 0;
            str = str.TrimStart();
            int[] mark = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            long m = 1;
            if (str[0] == '-')
                m = -1;
            int i = 0;
            if (str[0] == '-' || str[0] == '+')
                i = 1;
            long res = 0;
            for (; i < str.Length && Char.IsDigit(str[i]); i++)
            {
                res = res * 10 + mark[str[i] - '0'];
                if (res * m >= int.MaxValue)
                    return int.MaxValue;
                if (res * m <= int.MinValue)
                    return int.MinValue;
            }
            res *= m;
            return (int)res;
        }
        #endregion

        #region 11. Container With Most Water **
        //Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are 
        //drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a 
        //container, such that the container contains the most water.

        //Note: You may not slant the container and n is at least 2.
        public int MaxArea(int[] height)
        {
            int max = 0;
            int h = height[0];
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > h)
                {
                    h = height[i];
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        int tmp = (j - i) * Math.Min(h, height[j]);
                        max = max > tmp ? max : tmp;
                    }
                }
            }
            return max;
        }
        #endregion

        #region 15. 3Sum
        //Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

        //Note:

        //The solution set must not contain duplicate triplets.

        //Example:

        //Given array nums = [-1, 0, 1, 2, -1, -4],

        //A solution set is:
        //[
        //  [-1, 0, 1],
        //  [-1, -1, 2]
        //]
        public IList<IList<int>> ThreeSum(int[] nums)
        {

        }

        public bool TwoSum(Dictionary<int, int> dic, IList<int> list, int sum)
        {

        }
        #endregion

        #region 33. Search in Rotated Sorted Array

        //Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

        //(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

        //You are given a target value to search. If found in the array return its index, otherwise return -1.

        //You may assume no duplicate exists in the array.

        //Your algorithm's runtime complexity must be in the order of O(log n).

        //Example 1:

        //Input: nums = [4,5,6,7,0,1,2], target = 0
        //Output: 4
        //Example 2:

        //Input: nums = [4,5,6,7,0,1,2], target = 3
        //Output: -1
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    if (nums[mid] >= nums[left])
                        left = mid + 1;
                    else
                        right = mid;
                }
                else
                {
                    if (target > nums[left])
                        left = mid + 1;
                    else
                        right = mid;
                }
            }
            return nums[left] == target ? left : -1;
        }
        #endregion

        #region 151. Reverse Words in a String
        //Given an input string, reverse the string word by word.

        //For example,
        //Given s = "the sky is blue",
        //return "blue is sky the".

        //Update (2015-02-12):
        //For C programmers: Try to solve it in-place in O(1) space.
        public string ReverseWords(string s)
        {
            if (s == null)
                return s;
            StringBuilder sb = new StringBuilder();
            string tmp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    tmp = s[i] + tmp;
                else if (tmp != "")
                {
                    sb.Append(tmp + ' ');
                    tmp = "";
                }
            }
            if (tmp != "")
                sb.Append(tmp);
            return sb.ToString().TrimEnd();
        }
        #endregion

        #region 29. Divide Two Integers **搁置
        //Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.

        //Return the quotient after dividing dividend by divisor.

        //Example 1:

        //Input: dividend = 10, divisor = 3
        //Output: 3
        //Example 2:

        //Input: dividend = 7, divisor = -3
        //Output: -2
        //Note:

        //Both dividend and divisor will be 32-bit signed integers.
        //The divisor will never be 0.
        //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 231 − 1 when the division result overflows.
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0 || (dividend == int.MinValue && divisor == -1))
                return int.MaxValue;

            bool sign = (dividend > 0) ^ (divisor > 0);
            uint a = (uint)Math.Abs(divisor);
            uint b = (uint)Math.Abs(dividend);
            int result = 0;
            for (int i = 32; i >= 0; i--)
            {
                if ((b >> i) >= a)
                {
                    result = (result << 1) | 0x01;
                    b -= (a << i);
                }
                else
                    result = result << 1;
            }
            if (sign)
                result = -result;
            return result;
        }
        //we assure the factor ret's binary fomula is

        //ret = a0 + a1*2 + a2*2^2 + ...... + a29*2^29 + a30*2^30 + a31*2^31; ai = 0 or 1, i = 0......31

        //the dividend B and divisor A is non-negative, then

        //A(a0 + a1*2 + a2*2^2 + ...... + a29*2^29 + a30*2^30 + a31*2^31) = B; Eq1

        //(1) when Eq1 divided by 2^31, we can get A*a31 = B>>31; then a31 = (B>>31)/A;

        //if (B>>31) > A, then a31 = 1; else a31 = 0;

        //(2) when Eq1 divided by 2^30, we can get A*a30 + A*a31*2 = B>>30; then a30 = ((B>>30) - a31*A*2)/A; and (B>>30) - a31*A*2 can be rewritten by (B-a31*A<<31)>>30, so we make B' = B-a31*A<<31, the formula simplified to a30 = (B'>>30)/A

        //if (B'>>30) > A, then a30 = 1; else a30 = 0;

        //(3) in the same reason, we can get a29 = ((B-a31*A<<31-a30*A<<30)>>29)/A, we make B'' = B' - a30*A<<30, the formula simplified to a29 = (B''>>29)/A;

        //do the same bit operation 32 times, we can get a31 ..... a0, so we get the ret finally.

        //the C solution with constant time complexity        
        public int Divide2(int dividend, int divisor)
        {
            if (divisor == 0 || (dividend == int.MinValue && divisor == -1))
                return int.MaxValue;

            if (divisor == 1)
                return dividend;

            bool sign = (dividend > 0) ^ (divisor > 0);
            long dvd = Math.Abs((long)dividend);
            long dvs = Math.Abs((long)divisor);
            long result = 0;
            while (dvd >= dvs)
            {
                long tmp = dvs, multiple = 1;
                while (dvd >= (tmp << 1))
                {
                    tmp <<= 1;
                    multiple <<= 1;
                }
                dvd -= tmp;
                result += multiple;
            }
            if (sign)
                result = -result;
            return (int)result;
        }
        #endregion

        #region 166. Fraction to Recurring Decimal **循环小数搞不定
        //Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

        //If the fractional part is repeating, enclose the repeating part in parentheses.

        //For example,

        //Given numerator = 1, denominator = 2, return "0.5".
        //Given numerator = 2, denominator = 1, return "2".
        //Given numerator = 2, denominator = 3, return "0.(6)".


        //Credits:
        //Special thanks to @Shangrila for adding this problem and creating all test cases.
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == denominator)
                return "1";
            StringBuilder sb = new StringBuilder();
            bool b = true;
            if (numerator < denominator)
            {
                sb.Append("0.");
                b = false;
                numerator *= 10;
            }
            while (numerator != 0)
            {
                int res = numerator / denominator;
                numerator %= denominator;
                if (b && numerator < denominator)
                    sb.Append(".");
                if (numerator < denominator)
                {
                    numerator *= 10;

                }
            }
            return null;
        }
        #endregion

        #region 220. Contains Duplicate III ** 超时
        //Given an array of integers, find out whether there are two distinct indices i and j in the array such that the absolute 
        //difference between nums[i] and nums[j] is at most t and the absolute difference between i and j is at most k.
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j <= k && i + j < nums.Length; j++)
                {
                    if (Math.Abs((long)nums[i] - nums[j + i]) <= t)
                        return true;
                }
            }
            return false;
        }
        #endregion

        #region 130. Surrounded Regions
        //        Given a 2D board containing 'X' and 'O' (the letter O), capture all regions surrounded by 'X'.

        //A region is captured by flipping all 'O's into 'X's in that surrounded region.

        //Example:

        //X X X X
        //X O O X
        //X X O X
        //X O X X
        //After running your function, the board should be:

        //X X X X
        //X X X X
        //X X X X
        //X O X X
        //Explanation:

        //Surrounded regions shouldn’t be on the border, which means that any 'O' on the border of the board are not flipped to 'X'. Any 'O' that is not on the border and it is not connected 
        //to an 'O' on the border will be flipped to 'X'. Two cells are connected if they are adjacent cells connected horizontally or vertically.
        public void Solve(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            if (row < 3 || col < 3)
                return;
            int[,] mark = new int[row, col];
            for (int i = 1; i < row - 1; i++)
            {
                for (int j = 1; j < col - 1; j++)
                {
                    if (board[i, j] == 'O')
                        Search(i, j, board, mark);
                }
            }
        }

        public void Search(int i, int j, char[,] board, int[,] mark)
        {
            if (mark[i, j] == 1)
                return;
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            int[,] dir = { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };
            mark[i, j] = 1;
            Queue<int[]> q = new Queue<int[]>();
            List<int[]> list = new List<int[]>();
            q.Enqueue(new int[] { i, j });
            bool b = true;
            while (q.Count != 0)
            {
                int[] pos = q.Dequeue();
                list.Add(pos);
                for (int k = 0; k < 4; k++)
                {
                    int x = pos[0] + dir[k, 0];
                    int y = pos[1] + dir[k, 1];
                    if (x < 0 || x >= row || y < 0 || y >= col)
                        continue;
                    if (board[x, y] == 'O' && mark[x, y] == 0)
                    {
                        if (x == 0 || x == row - 1 || y == 0 || y == col - 1)
                            b = false;
                        q.Enqueue(new int[] { x, y });
                    }
                    mark[x, y] = 1;
                }
            }
            if (b)
                foreach (var item in list)
                    board[item[0], item[1]] = 'X';
        }

        public void Solve2(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            if (row < 3 || col < 3)
                return;

            for (int i = 0; i < row; i++)
            {
                DFS(i, 0, board);
                DFS(i, col - 1, board);
            }

            for (int i = 0; i < col; i++)
            {
                DFS(0, i, board);
                DFS(row - 1, i, board);
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    board[i, j] = board[i, j] == 'A' ? 'O' : 'X';
                }
            }
        }

        public void DFS(int i, int j, char[,] board)
        {
            if (board[i, j] != 'O')
                return;

            board[i, j] = 'A';
            if (i > 0)
                DFS(i - 1, j, board);

            if (i < board.GetLength(0) - 1)
                DFS(i + 1, j, board);

            if (j > 0)
                DFS(i, j - 1, board);

            if (j < board.GetLength(1) - 1)
                DFS(i, j + 1, board);
        }
        #endregion

        #region 127. Word Ladder
        //Given two words (beginWord and endWord), and a dictionary's word list, find the length of shortest transformation sequence from beginWord to endWord, such that:

        //Only one letter can be changed at a time.
        //Each transformed word must exist in the word list. Note that beginWord is not a transformed word.
        //Note:

        //Return 0 if there is no such transformation sequence.
        //All words have the same length.
        //All words contain only lowercase alphabetic characters.
        //You may assume no duplicates in the word list.
        //You may assume beginWord and endWord are non-empty and are not the same.
        //Example 1:

        //Input:
        //beginWord = "hit",
        //endWord = "cog",
        //wordList = ["hot","dot","dog","lot","log","cog"]

        //Output: 5

        //Explanation: As one shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog",
        //return its length 5.
        //Example 2:

        //Input:
        //beginWord = "hit"
        //endWord = "cog"
        //wordList = ["hot","dot","dog","lot","log"]

        //Output: 0

        //Explanation: The endWord "cog" is not in wordList, therefore no possible transformation.
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            return 0;
        }
        #endregion



        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion

        #region 

        #endregion
    }
}
