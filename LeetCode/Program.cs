using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(10);
            //TreeNode n1 = new TreeNode(5);
            //TreeNode n2 = new TreeNode(-3);
            //TreeNode n3 = new TreeNode(3);
            //TreeNode n4 = new TreeNode(2);
            //TreeNode n5 = new TreeNode(11);
            //TreeNode n6 = new TreeNode(3);
            //TreeNode n7 = new TreeNode(-2);
            //TreeNode n8 = new TreeNode(1);
            //root.left = n1;
            //root.right = n2;
            //n1.left = n3;
            //n1.right = n4;
            //n2.right = n5;
            //n3.left = n6;
            //n3.right = n7;
            //n4.right = n8;
            //PathSum(root, 8);

            //int[] h = { 1, 1, 1, 1, 1, 1, 999, 999, 999, 999, 999 };
            //int[] t = { 499, 500, 501 };
            //int k = FindRadius(h, t);
            //Console.WriteLine(k);
            //FindMaxConsecutiveOnes(new int[] { 1 });
            //Console.WriteLine(CheckPerfectNumber(28));
            //int[,] arr = { { 1, 2 }, { 3, 4 } };
            //MatrixReshape(arr, 4, 1);
            //ReverseStr("abcdefg", 3);
            //Console.WriteLine(FindUnsortedSubarray(new int[] { 3, 2, 1 }));
            //FindLHS(new int[] { 1, 4, 1, 3, 1, -14, 1, -13 });

            //TreeNode n1 = new TreeNode(4);
            //TreeNode n2 = new TreeNode(-7);
            //TreeNode n3 = new TreeNode(-3);
            //TreeNode n4 = new TreeNode(-9);
            //TreeNode n5 = new TreeNode(-3);
            //TreeNode n6 = new TreeNode(9);
            //TreeNode n7 = new TreeNode(-7);
            //TreeNode n8 = new TreeNode(-4);
            //TreeNode n9 = new TreeNode(6);
            //TreeNode n10 = new TreeNode(-6);
            //TreeNode n11 = new TreeNode(-6);
            //TreeNode n12 = new TreeNode(0);
            //TreeNode n13 = new TreeNode(6);
            //TreeNode n14 = new TreeNode(5);
            //TreeNode n15 = new TreeNode(9);
            //TreeNode n16 = new TreeNode(-1);
            //TreeNode n17 = new TreeNode(-4);
            //TreeNode n18 = new TreeNode(-2);
            //n1.left = n2;
            //n1.right = n3;
            //n3.left = n4;
            //n3.right = n5;
            //n4.left = n6;
            //n4.right = n7;
            //n5.left = n8;
            //n6.left = n9;
            //n7.left = n10;
            //n7.right = n11;
            //n9.left = n12;
            //n9.right = n13;
            //n10.left = n14;
            //n11.left = n15;
            //n12.right = n16;
            //n13.left = n17;
            //n15.left = n18;

            //TreeNode n1 = new TreeNode(1);
            //TreeNode n2 = new TreeNode(2);
            //TreeNode n3 = new TreeNode(3);
            //TreeNode n4 = new TreeNode(4);
            //n1.left = n2;
            //n1.right = n3;
            //n2.left = n4;
            //LongestUnivaluePath(n1);
            //FindSecondMinimumValue(n1);
            //Console.WriteLine(1 > int.MinValue);
            //AverageOfLevels(n1);
            //FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
            //FindTarget(new TreeNode(1), 2);
            //Console.WriteLine(CheckPossibility(new int[] { -1, 4, 2, 3 }));
            //ValidPalindrome("temmeb");
            //string[] strs = { "36", "28", "70", "65", "C", "+", "33", "-46", "84", "C" };
            //CalPoints(strs);
            //HasAlternatingBits(5);
            //int[,] grid = { { 1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 1, 1 } };
            //MaxAreaOfIsland(grid);
            //CountBinarySubstrings("10101");
            //FindShortestSubArray(new int[] { 1, 2, 2, 3, 1 });
            //Console.WriteLine("apple"<"apply");
            //PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 });
            //SubdomainVisits(new string[] { "2777 nak.mkw.co", "654 yaw.lmm.ca", "3528 jyx.arz.us", "3215 bll.hoh.network", "408 tdt.zfz.network", "3322 xhe.team", "8342 srp.team", "9259 bfo.net", "3875 brk.ato.network", "2531 mce.ser.com", "2471 czb.us", "4806 xss.dfa.co", "654 yls.yjt.co", "767 irh.epf.us", "1501 ara.ca", "243 qay.network", "9103 vbo.org", "6890 bfo.network", "4296 xtb.jre.us", "2329 vva.qay.network", "9846 fuw.org", "4681 lwf.ytn.network", "1781 lbk.ksc.co", "7464 jpd.fff.co", "2740 xhe.org", "4602 weq.buf.team", "3055 fdy.jkx.com", "5705 mqa.wsv.net", "6629 vdu.bfo.team", "9897 lra.uyy.org", "8167 ahm.jre.team", "9374 jep.ato.co", "3624 vmv.epf.network", "6865 thk.net", "6920 tlc.dfa.us", "9372 hci.jia.network", "7968 gjf.network", "7292 zbl.ksc.net", "2862 coh.sci.net", "3855 yjt.network", "1387 hju.gbq.org", "817 sgp.htq.co", "2406 hkb.ocf.co", "622 wmt.cwn.net", "9172 zfz.net", "1523 suq.bhp.co", "9581 gqi.team", "2160 hsj.epf.org", "32 ulz.com", "1225 lmm.ca", "1137 ujs.qzi.co", "5041 cdf.hwu.us", "4126 lir.ajl.team", "3111 gdw.team", "8928 arz.org", "9531 hoh.co", "7344 czb.com", "2715 ubt.okv.us", "1110 kdd.znq.us", "5729 srp.com", "6122 nqk.srp.org", "7193 xth.fzx.ca", "3496 ytn.com", "3950 xuf.network", "4521 weh.bfo.us", "3262 mor.ixi.us", "4975 okv.com", "7089 ske.yls.com", "4198 xfs.okv.co", "2444 vks.gxz.team", "1789 xcf.zqy.ca", "7392 uyy.net", "3449 tfm.us", "5907 zfz.us", "9530 omu.network", "3314 ytd.hkt.net", "9523 wyv.cgl.network", "4439 gtu.us", "8390 zqk.network", "1627 bhp.ca", "3609 bhp.team", "8557 uai.lfn.net", "2913 ret.ych.ca", "2447 ksc.com", "7476 cze.yvr.net", "8544 xrj.bhp.com", "6129 hkt.com", "8274 ulz.co", "9219 tfm.ca", "5016 zwv.gqi.co", "5738 lar.bfo.team", "3377 jkx.network", "2979 bhp.org", "8176 ujm.gqs.ca", "84 lmm.network", "3090 ycc.yjt.us", "7042 btv.com", "2965 gxj.org", "8263 cwn.org", "1873 kse.gjf.ca" });
            //MinMoves(new int[] { 5, 6, 8, 8, 5 });

            Console.ReadKey();
        }

        #region 1. Two Sum
        /**
         *Given an array of integers, return indices of the two numbers such that they add up to a specific target.

         You may assume that each input would have exactly one solution, and you may not use the same element twice. 
         */
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int m = target - nums[i];
                if (dic.ContainsKey(m))
                    return new int[] { i, dic[m] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            throw new Exception("No two sum solution");
        }
        #endregion

        #region Add Two Numbers
        /** 
         *  You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

            You may assume the two numbers do not contain any leading zero, except the number 0 itself.

         *  Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            Output: 7 -> 0 -> 8
            Explanation: 342 + 465 = 807.
         * */

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0);
            ListNode tmp = node;
            ListNode lt = l1;
            ListNode lr = l2;
            int i = 0;
            while (lt != null || lr != null || i != 0)
            {
                int k1 = lt == null ? 0 : lt.val;
                int k2 = lr == null ? 0 : lr.val;
                int sum = k1 + k2 + i;
                i = sum / 10;
                tmp.next = new ListNode(sum % 10);
                tmp = tmp.next;
                if (lt != null) lt = lt.next;
                if (lr != null) lr = lr.next;
            }
            return node.next;
        }


        #endregion

        #region Longest Substring Without Repeating Characters
        /**
         * Given a string, find the length of the longest substring without repeating characters.
         * */

        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null)
                return 0;

            if (s.Length <= 1)
                return s.Length;

            int[] mark = new int[128];
            int i = 0, j = 0;
            int max = 0;
            int count = 0;
            while (j < s.Length)
            {
                if (mark[s[j]] != 1)
                {
                    count++;
                    max = max > count ? max : count;
                    mark[s[j]] = 1;
                }
                else
                {
                    while (s[i] != s[j])
                    {
                        mark[s[i++]] = 0;
                    }
                    i++;
                    if (s.Length - i <= max)
                        return max;
                    count = j - i + 1;
                }
                j++;
            }
            return max;
        }
        #endregion

        #region Longest Palindromic Substring 没解决
        /**
         *   Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
         *   Input: "babad"
         *
         *   Output: "bab"
         *
         *   Note: "aba" is also a valid answer.
         * */
        public static string LongestPalindrome(string s)
        {
            if (s == null)
                return null;

            string res = s[0].ToString();
            int i = 0, j = s.Length - 1;
            int star = i, end = j;
            while (i <= j)
            {
                if (s[i] == s[j])
                {
                    star = i;
                    end = j;
                }
                else
                {
                    if (i + 1 <= j && s[i + 1] == s[j])
                        i++;

                }
            }
            return res;
        }
        #endregion

        #region 7. Reverse Integer
        /**Given a 32-bit signed integer, reverse digits of an integer.
         * Example 1:

        Input: 123
        Output:  321
        Example 2:

        Input: -123
        Output: -321
        Example 3:

        Input: 120
        Output: 21
         * */
        public static int Reverse(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res *= 10;
                if (res > int.MaxValue || res < int.MinValue)
                    return 0;
                res = res + x % 10;
                x /= 10;
            }
            return (int)res;
        }
        #endregion

        #region Palindrome Number
        /**
         * Determine whether an integer is a palindrome. Do this without extra space.
         * 
         * */
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int n = (int)Math.Log10(x) + 1;
            if (n == 1)
                return true;
            if (n == 2)
            {
                return x / 10 - x % 10 == 0;
            }
            int res = 0;
            for (int i = 0; i < n / 2; i++)
            {
                res = res * 10 + x % 10;
                x /= 10;
            }
            if (n % 2 == 0)
                x /= 10;

            return x - res == 0;
        }

        public static bool IsPalindrome2(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            if (x == 0)
                return true;
            int r = 0;
            while (x > r)
            {
                r = r * 10 + x % 10;
                x /= 10;
            }
            return x == r || x == r / 10;
        }
        #endregion

        #region 14. Longest Common Prefix   
        //Write a function to find the longest common prefix string amongst an array of strings
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            if (strs.Length == 1)
                return strs[0];

            int min = strs[0].Length;
            StringBuilder sb = new StringBuilder("");

            for (int i = 1; i < strs.Length; i++)
            {
                min = min < strs[i].Length ? min : strs[i].Length;
            }

            for (int i = 0; i < min; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != c)
                        return sb.ToString();
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
        #endregion

        #region 20. Valid Parentheses
        /**
         * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

           The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
         * */
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
                return false;

            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(' || item == '{' || item == '[')
                    stack.Push(item);
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char c = stack.Pop();

                    if (item == ')' && c != '(')
                        return false;

                    else if (item == '}' && c != '{')
                        return false;

                    else if (item == ']' && c != '[')
                        return false;
                }
            }
            return stack.Count == 0;
        }
        #endregion

        #region 21. Merge Two Sorted Lists
        /**
         * Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.
         * */
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode ln1 = l1;
            ListNode ln2 = l2;
            ListNode res = new ListNode(0);
            ListNode head = res;
            while (ln1 != null && ln2 != null)
            {
                if (ln1.val <= ln2.val)
                {
                    res.next = new ListNode(ln1.val);
                    ln1 = ln1.next;
                    res = res.next;
                    if (ln1 == null)
                        break;

                }
                else
                {
                    res.next = new ListNode(ln2.val);
                    ln2 = ln2.next;
                    res = res.next;
                    if (ln2 == null)
                        break;

                }
            }
            if (ln2 != null)
                ln1 = ln2;
            while (ln1 != null)
            {
                res.next = new ListNode(ln1.val);
                ln1 = ln1.next;
                res = res.next;
            }
            return head.next;
        }
        #endregion

        #region 26. Remove Duplicates from Sorted Array
        /**
         * Given a sorted array, remove the duplicates in-place such that each element appear only once and return the new length.
         * Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
         * 
         * Example:
         * Given nums = [1,1,2],
         * Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
         * It doesn't matter what you leave beyond the new length.
         * */
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return nums.Length;

            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                    nums[++j] = nums[i];
            }


            return ++j;
        }
        #endregion

        #region 27. Remove Element
        /**
         * Given an array and a value, remove all instances of that value in-place and return the new length.
         * Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
         * The order of elements can be changed. It doesn't matter what you leave beyond the new length.
         * 
         * Example:
         * Given nums = [3,2,2,3], val = 3,
         * Your function should return length = 2, with the first two elements of nums being 2.
         **/
        public static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[j++] = nums[i];
            }
            return j;
        }
        #endregion

        #region 28. Implement strStr()
        /**
         * Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
         * 
         * Example 1:
         * Input: haystack = "hello", needle = "ll"
         * Output: 2
         * 
         * Example 2:
         * Input: haystack = "aaaaa", needle = "bba"
         * Output: -1
         * */
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
        #endregion

        #region 35. Search Insert Position
        /**
         * Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted 
         * in order.
         * You may assume no duplicates in the array.
         * */
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums[0] >= target)
                return 0;

            if (nums[nums.Length - 1] < target)
                return nums.Length;

            if (nums[nums.Length - 1] == target)
                return nums.Length - 1;

            int left = 0, right = nums.Length - 1;
            while (right - left > 1)
            {
                int mid = (right + left) / 2;
                if (nums[mid] < target)
                    left = mid;
                else if (nums[mid] > target)
                    right = mid;
                else
                    return mid;
            }
            return right;
        }
        #endregion

        #region 38. Count and Say
        /**
         * The count-and-say sequence is the sequence of integers with the first five terms as following:
         * 1.     1
         * 2.     11
         * 3.     21
         * 4.     1211
         * 5.     111221
         * 1 is read off as "one 1" or 11.
         * 11 is read off as "two 1s" or 21.
         * 21 is read off as "one 2, then one 1" or 1211.
         * 
         * Given an integer n, generate the nth term of the count-and-say sequence.
         * Note: Each term of the sequence of integers will be represented as a string.
         * 
         * Example 1:
         * Input: 1
         * Output: "1"
         * 
         * Example 2:
         * Input: 4
         * Output: "1211"
         * */
        public static string CountAndSay(int n)
        {
            string pre = "1";
            for (int i = 1; i < n; i++)
            {
                char tmp = pre[0];
                int count = 0;
                string current = "";
                foreach (var item in pre)
                {
                    if (item == tmp)
                        count++;
                    else
                    {
                        current += count.ToString() + tmp;
                        tmp = item;
                        count = 1;
                    }
                }
                pre = current + count + tmp;
            }
            return pre;
        }
        #endregion

        #region 53. Maximum Subarray
        /**
         * Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
         * For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
         * the contiguous subarray [4,-1,2,1] has the largest sum = 6
         * 
         * 
         * */
        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int max = nums[0];
            int tmp = max;
            for (int i = 1; i < nums.Length; i++)
            {
                if (tmp + nums[i] < nums[i])
                    tmp = nums[i];
                else
                    tmp += nums[i];
                max = max > tmp ? max : tmp;
            }
            return max;
        }
        #endregion

        #region 58. Length of Last Word
        /**
         * Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
         * If the last word does not exist, return 0.
         * */
        public static int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && count != 0)
                    return count;

                else if (s[i] != ' ')
                    count++;
            }
            return count;
        }
        #endregion

        #region 66. Plus One
        /**
         * Given a non-negative integer represented as a non-empty array of digits, plus one to the integer.
         * You may assume the integer do not contain any leading zero, except the number 0 itself.
         * The digits are stored such that the most significant digit is at the head of the list.
         * */
        public static int[] PlusOne(int[] digits)
        {
            int c = 1;
            List<int> list = new List<int>(digits.Length + 1);
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int res = digits[i] + c;
                list.Add(res % 10);
                c = res / 10;
            }
            if (c == 1)
                list.Add(c);
            list.Reverse();
            return list.ToArray();
        }
        #endregion

        #region 67. Add Binary
        /**
         * Given two binary strings, return their sum (also a binary string).
         * For example,
         * a = "11"
         * b = "1"
         * Return "100".
         * */
        public static string AddBinary(string a, string b)
        {
            if (a.Length == 0)
                return b;
            if (b.Length == 0)
                return a;

            string strA = a;
            string strB = b;

            if (a.Length > b.Length)
            {
                strA = b;
                strB = a;
            }

            int d = strB.Length - strA.Length;
            int c = 0;
            string sum = "";
            for (int i = strA.Length - 1; i >= 0; i--)
            {
                int r = strA[i] + strB[i + d] - 96 + c;
                c = r / 2;
                r = r % 2;
                sum = r + sum;
            }
            for (int i = strB.Length - strA.Length - 1; i >= 0; i--)
            {
                if (c == 0)
                {
                    return strB.Substring(0, i + 1) + sum;
                }
                int r = strB[i] - 48 + c;
                c = r / 2;
                r = r % 2;
                sum = r + sum;
            }
            if (c == 1)
                sum = "1" + sum;
            return sum;
        }
        #endregion

        #region 69. Sqrt(x)
        public static int MySqrt(int x)
        {
            if (x < 2)
                return x;

            int left = 1;
            int right = x;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (x / mid >= mid)
                    left = mid + 1;
                else
                    right = mid;
            }
            return right - 1;
        }
        #endregion

        #region 70. Climbing Stairs
        /**
         * You are climbing a stair case. It takes n steps to reach to the top.
         * Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
         * */
        public static int ClimbStairs(int n)
        {
            if (n <= 3)
                return n;

            int a = 2, b = 3;
            for (int i = 0; i < n - 3; i++)
            {
                int tmp = a + b;
                a = b;
                b = tmp;
            }
            return b;
        }
        #endregion

        #region 83. Remove Duplicates from Sorted List
        /**
         * Given a sorted linked list, delete all duplicates such that each element appear only once.
         * For example,
         * Given 1->1->2->3->3, return 1->2->3.
         * */
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = head;
            while (node != null && node.next != null)
            {
                if (node.val == node.next.val)
                    node.next = node.next.next;
                else
                    node = node.next;
            }
            return head;
        }
        #endregion

        #region 88. Merge Sorted Array
        /**
         * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
         * Note:
         * You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2. The 
         * number of elements initialized in nums1 and nums2 are m and n respectively.
         * */
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }
        }
        #endregion

        #region 100. Same Tree
        /**
         * Given two binary trees, write a function to check if they are the same or not.
         * Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
         * */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p == null && q != null) || (p != null && q == null))
                return false;

            if (p == null && q == null)
                return true;

            Queue<TreeNode> queue1 = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            queue1.Enqueue(p);
            queue2.Enqueue(q);
            while (queue1.Count != 0)
            {
                TreeNode qt = queue1.Dequeue();
                TreeNode pt = queue2.Dequeue();
                if (qt.val != pt.val)
                    return false;

                if ((qt.left == null && pt.left != null) || (qt.left != null && pt.left == null) || (qt.right == null && pt.right != null) || (qt.right != null && pt.right == null))
                    return false;

                if (qt.left != null && pt.left != null)
                {
                    queue1.Enqueue(qt.left);
                    queue2.Enqueue(pt.left);
                }
                if (qt.right != null && pt.right != null)
                {
                    queue1.Enqueue(qt.right);
                    queue2.Enqueue(pt.right);
                }
            }
            return queue2.Count == 0;
        }
        #endregion

        #region 101. Symmetric Tree
        /**
         * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
         * For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
         *     1
         *    / \
         *   2   2
         *  / \ / \
         * 3  4 4  3
         */
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();


            q1.Enqueue(root.left);
            q2.Enqueue(root.right);
            TreeNode a = null;
            TreeNode b = null;

            while (q1.Count == q2.Count && q1.Count != 0)
            {
                a = q1.Dequeue();
                b = q2.Dequeue();
                if (a != null && b != null && a.val == b.val)
                {
                    q1.Enqueue(a.left);
                    q1.Enqueue(a.right);
                    q2.Enqueue(b.right);
                    q2.Enqueue(b.left);
                }
                else if (a == null && b == null)
                    continue;
                else
                    return false;
            }
            return q1.Count == q2.Count;
        }
        #endregion

        #region 104. Maximum Depth of Binary Tree
        public static int MaxDepth(TreeNode root)
        {
            return root == null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
        #endregion

        #region 107. Binary Tree Level Order Traversal II
        /** 
         * Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
         * For example:
         * Given binary tree [3,9,20,null,null,15,7],
         *    3
         *   / \
         *  9  20     
         *    /  \
         *   15   7
         * return its bottom-up level order traversal as:
         * [
         *    [15,7],
         *    [9,20],
         *    [3]
         * ]
         * 
         * */
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> qData = new Queue<TreeNode>();
            Queue<int> qMark = new Queue<int>();
            qData.Enqueue(root);
            qMark.Enqueue(0);
            while (qData.Count != 0)
            {
                TreeNode node = qData.Dequeue();
                int index = qMark.Dequeue();
                if (node != null)
                {
                    if (index == list.Count)
                        list.Add(new List<int>());

                    list[index].Add(node.val);
                    qData.Enqueue(node.left);
                    qData.Enqueue(node.right);
                    qMark.Enqueue(index + 1);
                    qMark.Enqueue(index + 1);
                }
            }
            list.Reverse();
            return list;
        }
        #endregion

        #region 108. Convert Sorted Array to Binary Search Tree
        /**
         * Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
         * For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never 
         * differ by more than 1.
         * */
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public static TreeNode SortedArrayToBST(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return new TreeNode(nums[left]);
            }
            else if (left == right - 1)
            {
                TreeNode root = new TreeNode(nums[right]);
                root.left = new TreeNode(nums[left]);
                return root;
            }
            else
            {
                int mid = (left + right) / 2;
                TreeNode root = new TreeNode(nums[mid]);
                root.left = SortedArrayToBST(nums, left, mid - 1);
                root.right = SortedArrayToBST(nums, mid + 1, right);
                return root;
            }
        }
        #endregion

        #region 110. Balanced Binary Tree ***不会
        /**
         * Given a binary tree, determine if it is height-balanced.
         * For this problem, a height-balanced binary tree is defined as:
         * a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
         * */
        public static bool IsBalanced(TreeNode root)
        {
            return Deep(root) != -1;
        }

        public static int Deep(TreeNode node)
        {
            if (node == null)
                return 0;
            int left = Deep(node.left);
            if (left == -1) return -1;

            int right = Deep(node.right);
            if (right == -1) return -1;

            if (Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }
        #endregion

        #region 111. Minimum Depth of Binary Tree
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            Queue<int> qDepth = new Queue<int>();
            Queue<TreeNode> qNode = new Queue<TreeNode>();
            qDepth.Enqueue(1);
            qNode.Enqueue(root);
            int depth = 1;
            while (qNode.Count != 0)
            {
                TreeNode node = qNode.Dequeue();
                depth = qDepth.Dequeue();
                if (node.left == null && node.right == null)
                {
                    return depth;
                }
                if (node.left != null)
                {
                    qDepth.Enqueue(depth + 1);
                    qNode.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    qDepth.Enqueue(depth + 1);
                    qNode.Enqueue(node.right);
                }
            }
            return depth;
        }

        public static int MinDepth2(TreeNode root)
        {
            if (root == null) return 0;
            int L = MinDepth(root.left), R = MinDepth(root.right);
            return L < R && L > 0 || R < 1 ? 1 + L : 1 + R;
        }
        #endregion

        #region 112. Path Sum
        /**
         * Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the 
         * given sum.
         * */
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
                return sum == 0;
            sum -= root.val;
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
        #endregion

        #region 118. Pascal's Triangle
        /**
         * Given numRows, generate the first numRows of Pascal's triangle.
         * For example, given numRows = 5,
         * Return
         * [
         *     [1],
         *    [1,1],
         *   [1,2,1],
         *  [1,3,3,1],
         * [1,4,6,4,1]
         *]
         * */
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (numRows == 0)
                return list;

            list.Add(new List<int>(1));
            list[0].Add(1);

            if (numRows > 1)
            {
                for (int i = 1; i < numRows; i++)
                {
                    list.Add(new List<int>(i + 1));
                    list[i].Add(1);
                    for (int j = 1; j < i; j++)
                    {
                        list[i].Add(list[i - 1][j - 1] + list[i - 1][j]);
                    }
                    list[i].Add(1);
                }
            }
            return list;
        }
        #endregion

        #region 119. Pascal's Triangle II
        /**
         * Given an index k, return the kth row of the Pascal's triangle.
         * For example, given k = 3,
         * Return [1,3,3,1].
         * */
        public static IList<int> GetRow(int rowIndex)
        {
            int[] arr = new int[rowIndex + 1];
            arr[0] = 1;
            long tmp = 1;
            int mid = rowIndex / 2;
            for (int i = 1; i <= mid; i++)
            {
                tmp = tmp * (rowIndex - i + 1) / i;
                arr[i] = (int)tmp;
                arr[rowIndex - i] = arr[i];
            }
            arr[rowIndex] = 1;
            return arr.ToList();
        }
        public static IList<int> GetRow2(int rowIndex)
        {
            int[] arr = new int[rowIndex + 1];
            arr[0] = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    arr[j] += arr[j - 1];
                }
            }
            return arr.ToList();
        }
        #endregion

        #region 121. Best Time to Buy and Sell Stock
        /**
         * Say you have an array for which the ith element is the price of a given stock on day i.
         * If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find 
         * the maximum profit.
         * */
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;
            int buy = prices[0];
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buy < prices[i])
                {
                    int profit = prices[i] - buy;
                    max = max > profit ? max : profit;
                }
                else
                    buy = prices[i];
            }
            return max;
        }
        #endregion

        #region 122. Best Time to Buy and Sell Stock II
        /**
         * Say you have an array for which the ith element is the price of a given stock on day i.
         * Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of 
         * the stock multiple times). However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you 
         * buy again).
         * */
        public static int MaxProfitII(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;

            int buy = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length - 1; i++)
            {
                if (buy >= prices[i])
                    buy = prices[i];

                if (buy < prices[i] && prices[i] > prices[i + 1])
                {
                    profit += prices[i] - buy;
                    buy = prices[++i];
                }
            }
            if (buy < prices[prices.Length - 1])
                profit += prices[prices.Length - 1] - buy;
            return profit;
        }
        #endregion

        #region 125. Valid Palindrome
        /**
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
         * For example,
         * "A man, a plan, a canal: Panama" is a palindrome.
         * "race a car" is not a palindrome.
         * Note:
         * Have you consider that the string might be empty? This is a good question to ask during an interview.
         * For the purpose of this problem, we define empty string as valid palindrome.
         * */
        public static bool IsPalindrome(string s)
        {
            if (s == "" || s == null)
                return true;

            s = s.ToLower();
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (!Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (!Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }
                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                    return false;
                i++;
                j--;
            }
            return true;
        }

        #endregion

        #region 136. Single Number
        /**
         * Given an array of integers, every element appears twice except for one. Find that single one.
         * */
        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length == 1 || nums[0] != nums[1])
                return nums.First();
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] && nums[i] != nums[i - 1])
                    return nums[i];
            }
            return nums.Last();
        }
        #endregion

        #region 141. Linked List Cycle
        /**
         * Given a linked list, determine if it has a cycle in it.
         * Follow up:
         * Can you solve it without using extra space?
         * */
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;
            ListNode a = head;
            ListNode b = head.next;
            while (a != null && b.next != null)
            {
                if (a == b)
                    return true;
                a = a.next;
                b = b.next.next;
            }
            return false;
        }
        #endregion

        #region 155. Min Stack
        /**
         * Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
         * push(x) -- Push element x onto stack.
         * pop() -- Removes the element on top of the stack.
         * top() -- Get the top element.
         * getMin() -- Retrieve the minimum element in the stack.
         * */
        public class MinStack
        {

            /** initialize your data structure here. */
            List<int> list = new List<int>(100);
            int top = 0;
            List<int> listMin = new List<int>(100);
            public MinStack()
            {
                list.Add(0);
                listMin.Add(int.MaxValue);
            }

            public void Push(int x)
            {
                int min = listMin[top] > x ? x : listMin[top];
                if (top < list.Count - 1)
                {
                    list[top + 1] = x;
                    listMin[top + 1] = min;
                }
                else
                {
                    list.Add(x);
                    listMin.Add(min);
                }
                top++;
            }

            public void Pop()
            {
                if (top > 0)
                    top--;
            }

            public int Top()
            {
                if (top > 0)
                    return list[top];
                throw new Exception();
            }

            public int GetMin()
            {
                if (top > 0)
                    return listMin[top];
                throw new Exception();
            }
        }
        #endregion

        #region 160. Intersection of Two Linked Lists
        /**
         * Write a program to find the node at which the intersection of two singly linked lists begins.
         * For example, the following two linked lists:
         * A:         a1 → a2
         *                    ↘
         *                      c1 → c2 → c3
         *                    ↗   
         * B:   b1 → b2 → b3     
         * begin to intersect at node c1.
         * */
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;

            if (headA == headB)
                return headB;

            ListNode a = headA;
            ListNode b = headB;
            int countA = 0;
            int countB = 0;
            while (a != null)
            {
                a = a.next;
                countA++;
            }
            while (b != null)
            {
                b = b.next;
                countB++;
            }
            a = headA;
            b = headB;
            int n = countA - countB;
            if (countA < countB)
            {
                a = headB;
                b = headA;
                n = -n;
            }
            for (int i = 0; i < n; i++)
            {
                a = a.next;
            }
            while (a != null)
            {
                if (a == b)
                    return a;
                a = a.next;
                b = b.next;
            }
            return null;
        }
        public static ListNode GetIntersectionNode2(ListNode headA, ListNode headB)
        {
            ListNode a = headA;
            ListNode b = headB;
            while (a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }
            return a;
        }
        #endregion

        #region 167. Two Sum II - Input array is sorted
        /**
         * Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
         * 
         * The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. 
         * Please note that your returned answers (both index1 and index2) are not zero-based.
         * 
         * You may assume that each input would have exactly one solution and you may not use the same element twice.
         * 
         * Input: numbers={2, 7, 11, 15}, target=9
         * Output: index1=1, index2=2
         * */
        public static int[] TwoSum2(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            int[] res = new int[2];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                res[0] = i + 1;
                int newTarget = target - numbers[i];
                left = i + 1;
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (numbers[mid] == newTarget)
                    {
                        res[1] = mid + 1;
                        return res;
                    }
                    if (numbers[mid] > newTarget)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
            }
            return res;
        }
        #endregion

        #region 168. Excel Sheet Column Title
        /**
         * Given a positive integer, return its corresponding column title as appear in an Excel sheet.
         * For example:
         *   1 -> A
         *   2 -> B
         *   3 -> C
         *   ...
         *   26 -> Z
         *   27 -> AA
         *   28 -> AB 
         * */
        public static string ConvertToTitle(int n)
        {
            string s = "";
            while (n != 0)
            {
                n--;
                s = (char)('A' + (n % 26)) + s;
                n /= 26;
            }
            return s;
        }
        #endregion

        #region 169. Majority Element
        /**
         * Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
         * You may assume that the array is non-empty and the majority element always exist in the array.
         * */
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }

        public static int MajorityElement2(int[] nums)
        {
            int marjor = nums[0], count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    count++;
                    marjor = nums[i];
                }
                else if (marjor == nums[i])
                    count++;
                else
                    count--;
            }
            return marjor;
        }
        #endregion

        #region 171. Excel Sheet Column Number
        /**
         * Given a column title as appear in an Excel sheet, return its corresponding column number.
         * A -> 1
         * B -> 2
         * 。。。
         * Z -> 26
         * AA -> 27
         * */
        public static int TitleToNumber(string s)
        {
            int[] arr = new int[26];
            for (int i = 0; i < 26; i++)
            {
                arr[i] = i + 1;
            }
            int res = 0;
            int c = 'A' - 1;
            foreach (var item in s)
            {
                res = res * 26 + (item - c);
            }
            return res;
        }
        #endregion

        #region 172. Factorial Trailing Zeroes
        /**
         * Given an integer n, return the number of trailing zeroes in n!.
         * */
        public static int TrailingZeroes(int n)
        {
            int count = 0;
            for (int i = 1; n >= 5; i++)
            {
                n /= 5;
                count += n;
            }
            return count;
        }
        #endregion

        #region 189. Rotate Array  
        /**
         * Rotate an array of n elements to the right by k steps.
         * For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].
         * Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
         * */
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            if (nums.Length == 1 || k == 0)
                return;
            int[] tmps = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                tmps[(i + k) % nums.Length] = nums[i];
            }
            tmps.CopyTo(nums, 0);
        }
        public static void Rotate2(int[] nums, int k)
        {
            k %= nums.Length;
            if (nums.Length == 1 || k == 0)
                return;
            int next = k, tmp = nums[0], star = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int r = nums[next];
                nums[next] = tmp;
                if (next == star)
                {
                    star++;
                    tmp = nums[star];
                    next = star + k;
                }
                else
                {
                    next = (next + k) % nums.Length;
                    tmp = r;
                }
            }
        }
        #endregion

        #region 190. Reverse Bits
        /**
         * Reverse bits of a given 32 bits unsigned integer.
         * */
        public static uint reverseBits(uint n)
        {
            uint res = 0;
            int i = 0;
            while (n != 0)
            {
                res = (res << 1) + (n & 1);
                n = n >> 1;
                i++;
            }
            res = res << (31 - i);
            return res;
        }
        #endregion

        #region 191. Number of 1 Bits
        /**
         * Write a function that takes an unsigned integer and returns the number of ’1' bits it has (also known as the Hamming weight).
         * */
        public static int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                    count++;
                n = n >> 1;
            }
            return count;
        }
        #endregion

        #region 198. House Robber
        // You are a professional robber planning to rob houses along a street.Each house has a certain amount of money stashed, the only 
        // constraint stopping you from robbing each of them is that adjacent houses have security system connected and it will automatically
        // contact the police if two adjacent houses were broken into on the same night.

        // Given a list of non-negative integers representing the amount of money of each house, determine the maximum amount of money you can rob tonight without alerting the police.
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            int[] res = new int[nums.Length];
            res[0] = nums[0];
            res[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                res[i] = Math.Max(res[i - 2] + nums[i], res[i - 1]);
            }

            return res.Last();
        }
        #endregion

        #region 202. Happy Number
        // Write an algorithm to determine if a number is "happy".

        // A happy number is a number defined by the following process: Starting with any positive integer, replace the number
        // by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it
        // loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.
        public static bool IsHappy(int n)
        {
            if (n < 7)
                return n == 1;
            int tmp = 0;
            while (n != 0)
            {
                int r = n % 10;
                tmp += r * r;
                n /= 10;
            }
            return IsHappy(tmp);
        }
        #endregion

        #region 203. Remove Linked List Elements
        // Remove all elements from a linked list of integers that have value val.
        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            ListNode node = new ListNode(0);
            node.next = head;
            ListNode tmp = node;
            while (tmp != null && tmp.next != null)
            {
                if (tmp.next.val == val)
                    tmp.next = tmp.next.next;
                else
                    tmp = tmp.next;
            }
            return node.next;
        }
        #endregion

        #region 204. Count Primes
        // Count the number of prime numbers less than a non-negative number, n.
        public static int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;
            if (n <= 3)
                return 1;

            int count = 1;
            for (int i = 3; i < n; i += 2)
            {
                if (IsPrimees(i))
                    count++;
            }
            return count;
        }
        public static bool IsPrimees(int n)
        {
            if (n <= 3)
                return n > 1;
            int length = (int)Math.Sqrt(n);
            for (int i = 3; i <= length; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region 205. Isomorphic Strings
        // Given two strings s and t, determine if they are isomorphic.
        // Two strings are isomorphic if the characters in s can be replaced to get t.
        // All occurrences of a character must be replaced with another character while preserving the order of characters.No two characters may map to the same character but a character may map to itself.

        // For example,
        // Given "egg", "add", return true.
        // Given "foo", "bar", return false.
        // Given "paper", "title", return true.
        public static bool IsIsomorphic(string s, string t)
        {
            if (s == null && t == null)
                return true;
            if (s == null || t == null)
                return false;
            if (s.Length != t.Length)
                return false;
            var dicS = new Dictionary<char, int>();
            var dicT = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dicS.ContainsKey(s[i]) && dicT.ContainsKey(t[i]))
                {
                    if (dicS[s[i]] != dicT[t[i]])
                        return false;
                }
                else if (!dicS.ContainsKey(s[i]) && !dicT.ContainsKey(t[i]))
                {
                    dicS.Add(s[i], i);
                    dicT.Add(t[i], i);
                }
                else
                    return false;
            }
            return true;
        }
        #endregion

        #region 206. Reverse Linked List
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;
            ListNode pre = null;
            while (head != null)
            {
                var next = head.next;
                head.next = pre;
                pre = head;
                head = next;
            }
            return pre;
        }
        #endregion

        #region 217. Contains Duplicate
        // Given an array of integers, find if the array contains any duplicates.Your function should return true
        // if any value appears at least twice in the array, and it should return false if every element is distinct.
        public static bool ContainsDuplicate(int[] nums)
        {
            var hs = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!hs.Add(item))
                    return false;
            }
            return true;
        }


        #endregion

        #region 219. Contains Duplicate II
        // Given an array of integers and an integer k, find out whether there are two distinct indices i and j
        // in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (i - dic[nums[i]] <= k)
                        return true;
                    else
                        dic[nums[i]] = i;
                }
                else
                    dic.Add(nums[i], i);
            }
            return false;
        }


        #endregion

        #region 225. Implement Stack using Queues
        public class MyStack
        {
            Queue<int> queue = new Queue<int>();

            /** Initialize your data structure here. */
            public MyStack()
            {

            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                Queue<int> q = new Queue<int>(queue.Count);
                while (queue.Count != 0)
                    q.Enqueue(queue.Dequeue());

                queue.Enqueue(x);
                while (q.Count != 0)
                    queue.Enqueue(q.Dequeue());
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                return queue.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return queue.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return queue.Count == 0;
            }
        }

        #endregion

        #region 226. Invert Binary Tree
        //Invert a binary tree.
        //     4
        //   /   \
        //  2     7
        // / \   / \
        //1   3 6   9
        //to
        //     4
        //   /   \
        //  7     2
        // / \   / \
        //9   6 3   1
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            var tmp = root.right;
            root.right = root.left;
            root.left = tmp;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
        #endregion

        #region 231. Power of Two
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;
            return (n & (n - 1)) == 0;
        }
        #endregion

        #region 232. Implement Queue using Stacks
        public class MyQueue
        {
            Stack<int> stack = new Stack<int>();
            /** Initialize your data structure here. */
            public MyQueue()
            {

            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                var tmp = new Stack<int>();
                while (stack.Count != 0)
                    tmp.Push(stack.Pop());

                stack.Push(x);
                while (tmp.Count != 0)
                    stack.Push(tmp.Pop());
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                return stack.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                return stack.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return stack.Count == 0;
            }
        }
        #endregion

        #region 234. Palindrome Linked List
        // Given a singly linked list, determine if it is a palindrome
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
                return true;
            var fast = head;
            var slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            fast = head;
            slow = Reverse(slow);
            while (slow != null)
            {
                if (slow.val != fast.val)
                    return false;
                slow = slow.next;
                fast = fast.next;
            }
            return true;
        }

        public static ListNode Reverse(ListNode node)
        {
            if (node == null || node.next == null)
                return node;
            ListNode pre = null;
            while (node != null)
            {
                var tmp = node.next;
                node.next = pre;
                pre = node;
                node = tmp;
            }
            return pre;
        }
        #endregion

        #region 235. Lowest Common Ancestor of a Binary Search Tree ***
        // Given a binary search tree(BST), find the lowest common ancestor(LCA) of two given nodes in the BST.

        // According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two
        // nodes v and w as the lowest node in T that has both v and w as descendants (where we allow a node to be a descendant of itself).”
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while ((root.val - p.val) * (root.val - q.val) > 0)
                root = p.val < root.val ? root.left : root.right;
            return root;
        }
        #endregion

        #region 237. Delete Node in a Linked List
        // Write a function to delete a node(except the tail) in a singly linked list, given only access to that node.

        // Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, the linked
        // list should become 1 -> 2 -> 4 after calling your function.
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        #endregion

        #region 242. Valid Anagram
        //Given two strings s and t, write a function to determine if t is an anagram of s.

        //For example,
        //s = "anagram", t = "nagaram", return true.
        //s = "rat", t = "car", return false.

        //Note:
        //You may assume the string contains only lowercase alphabets.

        //Follow up:
        //What if the inputs contain unicode characters? How would you adapt your solution to such case?
        public static bool IsAnagram(string s, string t)
        {
            if (s == null && t == null)
                return true;
            if (s.Length != t.Length)
                return false;

            int[] arrs = new int[26];
            int[] arrt = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arrs[s[i] - 'a']++;
                arrt[t[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (arrs[i] - arrt[i] != 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region 257. Binary Tree Paths
        // Given a binary tree, return all root-to-leaf paths.
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            var list = new List<string>();
            if (root == null)
                return list;
            BinaryTreePaths(list, root.val.ToString(), root);
            return list;
        }

        public static void BinaryTreePaths(IList<string> list, string s, TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                list.Add(s + root.val);
            }
            if (root.left != null)
            {
                BinaryTreePaths(list, s + root.val + "->", root.left);
            }
            if (root.right != null)
            {
                BinaryTreePaths(list, s + root.val + "->", root.right);
            }
        }
        #endregion

        #region 258. Add Digits
        //Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.
        //For example:
        //Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2. Since 2 has only one digit, return it.

        //Follow up:
        //Could you do it without any loop/recursion in O(1) runtime?
        public static int AddDigits(int num)
        {
            if (num < 10)
                return num;
            int tmp = 0;
            while (num != 0)
            {
                tmp += num % 10;
                num /= 10;
            }
            return AddDigits(tmp);
        }
        public static int AddDigits2(int num)
        {
            if (num < 10)
                return num;
            int tmp = 0;
            while (num != 0)
            {
                tmp += num % 10;
                num /= 10;
            }
            return AddDigits(tmp);
        }
        #endregion

        #region 263. Ugly Number *
        // Write a program to check whether a given number is an ugly number.

        // Ugly numbers are positive numbers whose prime factors only include 2, 3, 5. For example, 6, 8 are ugly
        // while 14 is not ugly since it includes another prime factor 7.
        public static bool IsUgly(int num)
        {
            if (num <= 0)
                return false;
            for (int i = 2; i < 6; i++)
            {
                while (num % i == 0)
                    num /= i;
            }
            return num == 1;
        }
        #endregion

        #region 268. Missing Number**
        // Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

        // Example 1
        // Input: [3,0,1]
        // Output: 2

        // Note:
        // Your algorithm should run in linear runtime complexity.Could you implement it using only constant extra space complexity?
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            n = n * (n + 1) / 2;
            foreach (var item in nums)
            {
                n -= item;
            }
            return n;
        }

        public int MissingNumber2(int[] nums)
        { //xor
            int res = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                res ^= i;
                res ^= nums[i];
            }
            return res;
        }
        #endregion

        #region 278. First Bad Version
        // You are a product manager and currently leading a team to develop a new product.Unfortunately,
        // the latest version of your product fails the quality check.Since each version is developed based
        // on the previous version, all the versions after a bad version are also bad.


        // Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, which
        // causes all the following ones to be bad.

        // You are given an API bool isBadVersion(version) which will return whether version is bad.Implement
        // a function to find the first bad version.You should minimize the number of calls to the API.
        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2; ;
                if (IsBadVersion(mid))
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 283. Move Zeroes
        // Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        // For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be[1, 3, 12, 0, 0].
        // Note:
        // 1. You must do this in-place without making a copy of the array.
        // 2. Minimize the total number of operations.
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1)
                return;
            int i = 0, j = 0;
            while (i < nums.Length)
            {
                while (i < nums.Length && nums[i] != 0)
                    i++;
                j = i + 1;
                while (j < nums.Length && nums[j] == 0)
                    j++;
                if (j >= nums.Length)
                    return;
                nums[i] = nums[j];
                nums[j] = 0;
                i++;
            }
        }
        #endregion

        #region 290. Word Pattern
        //Given a pattern and a string str, find if str follows the same pattern.

        //Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in str.

        //Examples:
        //pattern = "abba", str = "dog cat cat dog" should return true.
        //pattern = "abba", str = "dog cat cat fish" should return false.
        //pattern = "aaaa", str = "dog cat cat dog" should return false.
        //pattern = "abba", str = "dog dog dog dog" should return false.
        //Notes:
        //You may assume pattern contains only lowercase letters, and str contains lowercase letters separated by a single space.
        public static bool WordPattern(string pattern, string str)
        {
            string[] words = str.Split(new char[] { ' ' });
            if (pattern.Length != words.Length)
                return false;
            Dictionary<char, string> dic = new Dictionary<char, string>();
            Dictionary<string, char> dic2 = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dic.ContainsKey(pattern[i]))
                {
                    dic.Add(pattern[i], words[i]);
                    if (dic2.ContainsKey(words[i]))
                        return false;
                    //dic2.Add(words[i], pattern[i]);
                }
                else if (dic[pattern[i]] != words[i])
                    return false;
            }
            return true;
        }
        #endregion

        #region 292. Nim Game
        // You are playing the following Nim Game with your friend: There is a heap of stones on the table, 
        // each time one of you take turns to remove 1 to 3 stones.The one who removes the last stone will
        // be the winner.You will take the first turn to remove the stones.

        // Both of you are very clever and have optimal strategies for the game. Write a function to determine
        // whether you can win the game given the number of stones in the heap.


        // For example, if there are 4 stones in the heap, then you will never win the game: no matter 1, 2, or
        // 3 stones you remove, the last stone will always be removed by your friend.
        public static bool CanWinNim(int n)
        {
            return n % 4 > 0;
        }
        #endregion

        #region 303. Range Sum Query - Immutable
        // Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.
        public class NumArray
        {
            int[] sum;
            public NumArray(int[] nums)
            {
                sum = new int[nums.Length];
                nums.CopyTo(sum, 0);
                for (int i = 1; i < nums.Length; i++)
                {
                    sum[i] += sum[i - 1];
                }
            }

            public int SumRange(int i, int j)
            {
                if (i == 0)
                    return sum[j];
                return sum[j] - sum[i - 1];
            }
        }
        #endregion

        #region 326. Power of Three ***
        public bool IsPowerOfThree(int n)
        {
            int maxPow = (int)(Math.Pow(3, (int)(Math.Log(int.MaxValue) / Math.Log(3))));
            return (n > 0 && maxPow % n == 0);
        }

        #endregion

        #region 342. Power of Four***
        public bool IsPowerOfFour(int num)
        {
            return num > 0 && (num & (num - 1)) == 0 && (num & 0x55555555) != 0;
        }
        #endregion

        #region 344. Reverse String
        public string ReverseString(string s)
        {
            if (s == null)
                return s;

            int n = s.Length - 1;
            char[] tmp = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
                tmp[n - i] = s[i];

            return new string(tmp);
        }
        #endregion

        #region 345. Reverse Vowels of a String
        public static string ReverseVowels(string s)
        {
            if (s.Length <= 1)
                return s;
            char[] tmps = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] res = s.ToCharArray();
            for (int i = 0, j = s.Length - 1; i < j;)
            {
                if (tmps.Contains(s[i]))
                {
                    if (tmps.Contains(s[j]))
                    {
                        char c = res[j];
                        res[j] = res[i];
                        res[i] = c;
                        i++;
                        j--;

                    }
                    else
                        j--;
                }
                else if (tmps.Contains(s[j]))
                {
                    i++;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return new string(res);
        }

        #endregion

        #region 349. Intersection of Two Arrays
        // Given two arrays, write a function to compute their intersection.

        // Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[0];
            var hs = new HashSet<int>();
            var res = new HashSet<int>();
            foreach (var item in nums1)
                hs.Add(item);

            foreach (var item in nums2)
            {
                if (hs.Contains(item))
                    res.Add(item);
            }
            return res.ToArray();
        }
        #endregion

        #region 350. Intersection of Two Arrays II
        // Given two arrays, write a function to compute their intersection.
        // Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

        // Note:
        //    Each element in the result should appear as many times as it shows in both arrays.
        //    The result can be in any order.

        //Follow up:
        //    What if the given array is already sorted? How would you optimize your algorithm?
        //    What if nums1's size is small compared to nums2's size? Which algorithm is better?
        //    What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[0];
            var dic = new Dictionary<int, int>();
            var res = new List<int>();
            int[] tmp = null;
            if (nums1.Length > nums2.Length)
            {
                tmp = nums1;
                nums1 = nums2;
                nums2 = tmp;
            }
            foreach (var item in nums1)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item, 1);
            }

            foreach (var item in nums2)
            {
                if (dic.ContainsKey(item) && dic[item] != 0)
                {
                    res.Add(item);
                    dic[item]--;
                }
            }
            return res.ToArray();
        }
        #endregion

        #region 367. Valid Perfect Square
        // Given a positive integer num, write a function which returns True if num is a perfect square else False.

        // Note: Do not use any built-in library function such as sqrt.
        public static bool IsPerfectSquare(int num)
        {
            if (num <= 9)
                return num == 1 || num == 4 || num == 9;
            int left = 4, right = num >> 2;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int tmp = num / mid;
                if (num % mid == 0 && tmp == mid)
                    return true;
                else if (mid <= tmp)
                    left = mid + 1;
                else
                    right = mid;
            }
            return left * left == num;
        }
        #endregion

        #region 371. Sum of Two Integers *
        // Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.
        public static int GetSum(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
        #endregion

        #region 383. Ransom Note
        //Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

        //Each letter in the magazine string can only be used once in your ransom note.

        //Note:
        //You may assume that both strings contain only lowercase letters.

        //canConstruct("a", "b") -> false
        //canConstruct("aa", "ab") -> false
        //canConstruct("aa", "aab") -> true
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length == 0)
                return true;
            if (magazine.Length == 0)
                return false;

            int[] mark = new int[26];
            foreach (var item in magazine)
                mark[item - 'a']++;

            foreach (var item in ransomNote)
            {
                if (mark[item - 'a'] == 0)
                    return false;
                mark[item - 'a']--;
            }
            return true;
        }
        #endregion

        #region 387. First Unique Character in a String
        //Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

        //Examples:

        //s = "leetcode"
        //return 0.

        //s = "loveleetcode",
        //return 2.
        public static int FirstUniqChar(string s)
        {
            if (s == null)
                return -1;
            int[] mark = new int[128];
            foreach (var item in s)
                mark[item]++;

            for (int i = 0; i < s.Length; i++)
            {
                if (mark[s[i]] == 1)
                    return i;
            }
            return -1;
        }
        #endregion

        #region 389. Find the Difference *
        //Given two strings s and t which consist of only lowercase letters.

        //String t is generated by random shuffling string s and then add one more letter at a random position.

        //Find the letter that was added in t.

        //Example:

        //Input:
        //s = "abcd"
        //t = "abcde"

        //Output:
        //e

        //Explanation:
        //'e' is the letter that was added.
        public static char FindTheDifference(string s, string t)
        {
            if (s == null || s == "")
                return t[0];
            int ret = 0;
            int i = 0;
            for (; i < s.Length; i++)
            {
                ret ^= s[i];
                ret ^= t[i];
            }
            ret ^= t[i];
            return (char)ret;
        }
        #endregion

        #region 400. Nth Digit
        // Find the nth digit of the infinite integer sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, ...
        public static int FindNthDigit(int n)
        {
            if (n < 10)
                return n;
            long a = 9;
            long i = 2;
            long target = n - 9;
            while (true)
            {
                a *= 10;
                long b = a * i;
                if (target - b <= 0)
                    break;
                i++;
                target -= b;
            }
            int tmp = (int)(a / 9 + (target - 1) / i);
            long j = (int)(target - 1) % i;
            int res = 0;
            while (i - j > 0)
            {
                res = tmp % 10;
                tmp /= 10;
                j++;
            }
            return res;
        }
        #endregion

        #region 401. Binary Watch
        // A binary watch has 4 LEDs on the top which represent the hours(0-11), and the 6 LEDs on the bottom represent the minutes(0-59).

        // Each LED represents a zero or one, with the least significant bit on the right.
        public static IList<string> ReadBinaryWatch(int num)
        {
            var resultList = new List<string>(30);
            var hourList = new List<string>();
            var minList = new List<string>();
            for (int i = 0; i <= num && i < 4; i++)
            {
                hourList.Clear();
                minList.Clear();
                GetTime(i, 0, hourList, 0, 4);
                GetTime(num - i, 0, minList, 0, 6);
                foreach (var hour in hourList)
                    foreach (var min in minList)
                        resultList.Add(hour + ":" + min);
            }
            return resultList;
        }

        public static void GetTime(int n, int star, List<string> list, int val, int leds)
        {
            if (n == 0)
            {
                if (leds == 4 && val < 12)
                    list.Add(val.ToString());
                else if (leds == 6)
                {
                    if (val < 10)
                        list.Add("0" + val);
                    else if (val < 60)
                        list.Add(val.ToString());
                }
                return;
            }
            for (int i = star; i <= leds - n && n > 0; i++)
            {
                int tmp = val + (1 << i);
                GetTime(n - 1, i + 1, list, tmp, leds);
            }
        }
        public static IList<string> ReadBinaryWatch3(int num)
        {
            var resultList = new List<string>(30);
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 60; j++)
                {

                }
            }
            return resultList;
        }
        #endregion

        #region 404. Sum of Left Leaves
        //Find the sum of all left leaves in a given binary tree.
        public static int SumOfLeftLeaves(TreeNode root)
        {
            return RecSumOfLeftLeaves(root, false);
        }

        public static int RecSumOfLeftLeaves(TreeNode root, bool bLeft)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
            {
                if (bLeft)
                    return root.val;
                else
                    return 0;
            }
            return RecSumOfLeftLeaves(root.left, true) + RecSumOfLeftLeaves(root.right, false);
        }

        #endregion

        #region 405. Convert a Number to Hexadecimal
        // Given an integer, write an algorithm to convert it to hexadecimal.For negative integer, two’s complement method is used.
        // Note:

        // All letters in hexadecimal(a-f) must be in lowercase.
        // The hexadecimal string must not contain extra leading 0s.If the number is zero, it is represented by a single zero character '0'; otherwise, the first character in the hexadecimal string will not be the zero character.
        // The given number is guaranteed to fit within the range of a 32-bit signed integer.
        // You must not use any method provided by the library which converts/formats the number to hex directly.
        public static string ToHex(int num)
        {
            char[] dic = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            List<char> list = new List<char>();
            if (num == 0)
                return "0";
            if (num > 0)
            {
                while (num != 0)
                {
                    list.Add(dic[num & 15]);
                    num = num >> 4;
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    list.Add(dic[num & 15]);
                    num = num >> 4;
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = list.Count - 1; i >= 0; i--)
                sb.Append(list[i]);

            return sb.ToString();
        }
        #endregion

        #region 409. Longest Palindrome
        // Given a string which consists of lowercase or uppercase letters, find the length of the longest palindromes that can be built with those letters.

        // This is case sensitive, for example "Aa" is not considered a palindrome here.
        public static int LongestPalindrome2(string s)
        {
            int[] mark = new int[128];
            foreach (var item in s)
                mark[item]++;

            int res = 0, m = 0;
            for (int i = 'a'; i <= 'z'; i++)
            {
                if (mark[i] % 2 == 0)
                    res += mark[i];
                else
                {
                    res += mark[i] - 1;
                    m = 1;
                }
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                if (mark[i] % 2 == 0)
                    res += mark[i];
                else
                {
                    res += mark[i] - 1;
                    m = 1;
                }
            }
            return res + m;
        }
        #endregion

        #region 412. Fizz Buzz
        // Write a program that outputs the string representation of numbers from 1 to n.

        // But for multiples of three it should output “Fizz” instead of the number and for the
        // multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        //Example:

        //n = 15,

        //Return:
        //[
        //    "1",
        //    "2",
        //    "Fizz",
        //    "4",
        //    "Buzz",
        //    "Fizz",
        //    "7",
        //    "8",
        //    "Fizz",
        //    "Buzz",
        //    "11",
        //    "Fizz",
        //    "13",
        //    "14",
        //    "FizzBuzz"
        //]
        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        list.Add("FizzBuzz");
                    else
                        list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                    list.Add(i.ToString());
            }
            return list;
        }
        #endregion

        #region 414. Third Maximum Number
        // Given a non-empty array of integers, return the third maximum number in this array.If it does not exist, return the maximum number.The time complexity must be in O(n).

        // Example 1:
        // Input: [3, 2, 1]
        // Output: 1
        // Explanation: The third maximum is 1.

        // Example 2:
        // Input: [1, 2]
        // Output: 2
        // Explanation: The third maximum does not exist, so the maximum(2) is returned instead.

        // Example 3:
        // Input: [2, 2, 3, 1]
        // Output: 1
        // Explanation: Note that the third maximum here means the third maximum distinct number.
        // Both numbers with value 2 are both considered as second maximum.
        public static int ThirdMax(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Max();
            long first = nums[0], second = long.MinValue, third = long.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == first || nums[i] == second || nums[i] == third)
                    continue;
                if (nums[i] > first)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                }
                else if (nums[i] > second)
                {
                    third = second;
                    second = nums[i];
                }
                else if (nums[i] > third)
                    third = nums[i];
            }
            if (third == long.MinValue)
                return (int)first;
            return (int)third;
        }
        #endregion

        #region 415. Add Strings

        //Given two non-negative integers num1 and num2 represented as string, return the sum of num1 and num2.

        //Note:

        //The length of both num1 and num2 is < 5100.
        //Both num1 and num2 contains only digits 0-9.
        //Both num1 and num2 does not contain any leading zero.
        //You must not use any built-in BigInteger library or convert the inputs to integer directly.
        public static string AddStrings(string num1, string num2)
        {
            int c = 0;
            int i = num1.Length - 1, j = num2.Length - 1;
            string result = "";
            while (i >= 0 || j >= 0 || c != 0)
            {
                int sum = 0;
                if (i >= 0) sum += num1[i] - '0';
                if (j >= 0) sum += num2[j] - '0';
                sum += c;
                result = (sum % 10) + result;
                c = sum / 10;
                i--;
                j--;
            }
            return result;
        }

        #endregion

        #region 434. Number of Segments in a String
        //Count the number of segments in a string, where a segment is defined to be a contiguous sequence of non-space characters.
        //Please note that the string does not contain any non-printable characters.

        //Example:
        //Input: "Hello, my name is John"
        //Output: 5
        public static int CountSegments(string s)
        {
            bool b = false;
            int count = 0;
            foreach (var item in s)
            {
                if (item != ' ')
                {
                    if (!b)
                    {
                        count++;
                        b = true;
                    }
                }
                else
                    b = false;
            }
            return count;
        }
        #endregion

        #region 437. Path Sum III ***
        // You are given a binary tree in which each node contains an integer value.
        // Find the number of paths that sum to a given value.
        // The path does not need to start or end at the root or a leaf, but it must go downwards(traveling only from parent nodes to child nodes).
        // The tree has no more than 1,000 nodes and the values are in the range -1,000,000 to 1,000,000.

        // Example:

        //root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

        //      10
        //     /  \
        //    5   -3
        //   / \    \
        //  3   2   11
        // / \   \
        //3  -2   1

        //Return 3. The paths that sum to 8 are:

        //1.  5 -> 3
        //2.  5 -> 2 -> 1
        //3. -3 -> 11
        public static int PathSum(TreeNode root, int sum)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 1);
            return PathSum(root, 0, sum, dic);
        }

        public static int PathSum(TreeNode root, int currSum, int target, Dictionary<int, int> dic)
        {
            if (root == null)
                return 0;
            currSum += root.val;
            int res = 0;
            if (dic.ContainsKey(currSum - target))
                res = dic[currSum - target];
            else
                dic.Add(currSum - target, 0);
            if (dic.ContainsKey(currSum))
                dic[currSum]++;
            else
                dic.Add(currSum, 1);

            res += PathSum(root.left, currSum, target, dic) + PathSum(root.right, currSum, target, dic);
            dic[currSum]--;
            return res;
        }
        #endregion

        #region 438. Find All Anagrams in a String
        //Given a string s and a non-empty string p, find all the start indices of p's anagrams in s.
        //Strings consists of lowercase English letters only and the length of both strings s and p will not be larger than 20,100.
        //The order of output does not matter.

        //Example 1:
        //Input:
        //s: "cbaebabacd" p: "abc"
        //Output:
        //[0, 6]
        // Explanation:
        //The substring with start index = 0 is "cba", which is an anagram of "abc".
        //The substring with start index = 6 is "bac", which is an anagram of "abc".

        //Example 2:
        //Input:
        //s: "abab" p: "ab"
        //Output:
        //[0, 1, 2]
        //Explanation:
        //The substring with start index = 0 is "ab", which is an anagram of "ab".
        //The substring with start index = 1 is "ba", which is an anagram of "ab".
        //The substring with start index = 2 is "ab", which is an anagram of "ab".
        public static IList<int> FindAnagrams(string s, string p)
        {
            var list = new List<int>();
            if (p.Length > s.Length)
                return list;
            int[] mark = new int[26];
            int flag = 0;
            foreach (var item in p)
            {
                flag += item;
                mark[item - 'a']++;
            }

            int current = 0;
            for (int i = 0; i < p.Length; i++)
                current += s[i];
            if (current == flag && IsAnagrams(s, 0, p.Length, mark))
                list.Add(0);
            for (int i = 1; i <= s.Length - p.Length; i++)
            {
                current = current - s[i - 1] + s[i + p.Length - 1];
                if (current == flag && IsAnagrams(s, i, i + p.Length, mark))
                    list.Add(i);
            }
            return list;
        }

        public static bool IsAnagrams(string s, int star, int count, int[] mark)
        {
            for (int i = star; i < count; i++)
                if (mark[s[i] - 'a'] == 0)
                    return false;

            return true; ;
        }
        #endregion

        #region 443. String Compression
        //Given an array of characters, compress it in-place.
        //The length after compression must always be smaller than or equal to the original array.
        //Every element of the array should be a character(not int) of length 1.
        //After you are done modifying the input array in-place, return the new length of the array.


        //Follow up:
        //Could you solve it using only O(1) extra space?


        //Example 1:
        //Input:
        //["a","a","b","b","c","c","c"]
        //Output:
        //Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
        //Explanation:
        //"aa" is replaced by "a2". "bb" is replaced by "b2". "ccc" is replaced by "c3".

        //Example 2:
        //Input:
        //["a"]
        //Output:
        //Return 1, and the first 1 characters of the input array should be: ["a"]
        //Explanation:
        //Nothing is replaced.

        //Example 3:
        //Input:
        //["a","b","b","b","b","b","b","b","b","b","b","b","b"]
        //Output:
        //Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
        //Explanation:
        //Since the character "a" does not repeat, it is not compressed. "bbbbbbbbbbbb" is replaced by "b12".
        //Notice each digit has it's own entry in the array.

        //Note:
        //All characters have an ASCII value in [35, 126].
        //1 <= len(chars) <= 1000.
        public static int Compress(char[] chars)
        {
            if (chars.Length <= 2)
                return chars.Length;

            int count = 0, tmp = 1;
            char flag = chars[0];
            int index = 0;
            for (int i = 1; i < chars.Length; i++)
            {
                if (flag == chars[i])
                    tmp++;
                else
                {
                    int n = Compress(chars, index, tmp, chars[i - 1]);
                    index += n;
                    count += n;
                    flag = chars[i];
                    tmp = 1;
                }
            }

            return count + Compress(chars, index, tmp, chars[chars.Length - 1]);
        }

        public static int Compress(char[] chars, int star, int n, char c)
        {
            chars[star++] = c;
            if (n == 1)
                return 1;

            string str = "";
            while (n != 0)
            {
                str = (char)(n % 10 + '0') + str;
                n /= 10;
            }
            foreach (var item in str)
            {
                chars[star++] = item;
            }
            return str.Length + 1;
        }

        #endregion

        #region 441. Arranging Coins
        // You have a total of n coins that you want to form in a staircase shape, where every k-th row must have exactly k coins.
        // Given n, find the total number of full staircase rows that can be formed.
        // n is a non-negative integer and fits within the range of a 32-bit signed integer.

        //Example 1:
        //n = 5
        //The coins can form the following rows:
        //¤
        //¤ ¤
        //¤ ¤
        //Because the 3rd row is incomplete, we return 2.

        //Example 2:
        //n = 8
        //The coins can form the following rows:
        //¤
        //¤ ¤
        //¤ ¤ ¤
        //¤ ¤
        //Because the 4th row is incomplete, we return 3.
        public static int ArrangeCoins(int n)
        {
            long k = (long)(Math.Sqrt(2) * Math.Sqrt(n));
            long num = 0;
            if (k % 2 == 0)
                num = (k >> 1) + (k >> 1) * k;
            else
                num = ((k + 1) >> 1) * k;
            if (num < n)
            {
                while (num < n)
                {
                    k++;
                    num += k;
                }
                return (int)k - 1;
            }
            else if (num == n)
                return (int)k;
            else
            {
                while (num > n)
                {
                    num -= k;
                    k--;
                }
                return (int)k;
            }
        }
        #endregion

        #region 447. Number of Boomerangs ***
        //Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points(i, j, k) such that the distance between i and j
        //equals the distance between i and k(the order of the tuple matters).
        //Find the number of boomerangs.You may assume that n will be at most 500 and coordinates of points are all in the range[-10000, 10000] (inclusive).

        //Example:
        //Input:
        //[[0,0],[1,0],[2,0]]
        //Output:
        //2
        //Explanation:
        //The two boomerangs are[[1,0],[0,0],[2,0]] and[[1, 0],[2,0],[0,0]]
        public static int NumberOfBoomerangs(int[,] points)
        {
            int n = points.GetLength(0);
            int res = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        int dx = points[i, 0] - points[j, 0];
                        int dy = points[i, 1] - points[j, 1];
                        int dis = dx * dx + dy * dy;
                        if (dic.ContainsKey(dis))
                            dic[dis]++;
                        else
                            dic.Add(dis, 1);
                    }
                }
                foreach (KeyValuePair<int, int> kv in dic)
                {
                    res += kv.Value * (kv.Value - 1);
                }
                dic.Clear();
            }
            return res;
        }
        #endregion

        #region 448. Find All Numbers Disappeared in an Array ***
        //Given an array of integers where 1 ≤ a[i] ≤ n(n = size of array), some elements appear twice and others appear once.
        //Find all the elements of [1, n] inclusive that do not appear in this array.
        //Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.

        //Example:
        //Input:
        //[4,3,2,7,8,2,3,1]
        //Output:
        //[5,6]
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var list = new List<int>(nums.Length);
            foreach (var item in nums)
            {
                int val = Math.Abs(item) - 1;
                if (nums[val] > 0)
                    nums[val] = -nums[val];
            }

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    list.Add(i + 1);

            return list;
        }
        #endregion

        #region 453. Minimum Moves to Equal Array Elements ***
        // Given a non-empty integer array of size n, find the minimum number of moves required to make all array elements equal, where a move is incrementing n - 1 elements by 1.
        public static int MinMoves(int[] nums)
        {
            int res = 0;
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min < nums[i])
                    res += nums[i] - min;
                else
                {
                    res += i * (min - nums[i]);
                    min = nums[i];
                }
            }
            return res;
        }
        #endregion

        #region 455. Assign Cookies
        //Assume you are an awesome parent and want to give your children some cookies.But, you should give each child at most one cookie.Each child 
        //i has a greed factor gi, which is the minimum size of a cookie that the child will be content with; and each cookie j has a size sj.
        //If sj >= gi, we can assign the cookie j to the child i, and the child i will be content.Your goal is to maximize the number of your content children and output the maximum number.

        //Note:
        //You may assume the greed factor is always positive. 
        //You cannot assign more than one cookie to one child.

        //Example 1:
        //Input: [1,2,3], [1,1]
        //Output: 1
        //Explanation: You have 3 children and 2 cookies.The greed factors of 3 children are 1, 2, 3. 
        //And even though you have 2 cookies, since their size is both 1, you could only make the child whose greed factor is 1 content.
        //You need to output 1.

        //Example 2:
        //Input: [1,2], [1,2,3]
        //Output: 2
        //Explanation: You have 2 children and 3 cookies.The greed factors of 2 children are 1, 2. 
        //You have 3 cookies and their sizes are big enough to gratify all of the children,
        //You need to output 2.
        public static int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int count = 0;
            int current = 0;
            for (int i = 0; i < g.Length && current < s.Length; i++)
                for (int j = current; j < s.Length; j++)
                    if (s[j] >= g[i])
                    {
                        count++;
                        current = j + 1;
                        break;
                    }
            return count;
        }
        #endregion

        #region 458. Poor Pigs *****
        //There are 1000 buckets, one and only one of them contains poison, the rest are filled with water.They all look the same.
        //If a pig drinks that poison it will die within 15 minutes.What is the minimum amount of pigs you need to figure out which bucket contains the poison within one hour.

        //Answer this question, and write an algorithm for the follow-up general case.


        //Follow-up:
        //If there are n buckets and a pig drinking poison will die within m minutes, how many pigs (x) you need to figure out the "poison" bucket within p minutes? There is exact one bucket with poison.
        public static int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            return (int)Math.Ceiling(Math.Log(buckets) / Math.Log(minutesToTest / minutesToDie + 1));
        }
        #endregion

        #region 459. Repeated Substring Pattern
        //Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.
        //You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

        //Example 1:
        //Input: "abab"
        //Output: True
        //Explanation: It's the substring "ab" twice.

        //Example 2:
        //Input: "aba"
        //Output: False

        //Example 3:
        //Input: "abcabcabcabc"
        //Output: True
        //Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)
        public static bool RepeatedSubstringPattern(string s)
        {
            int[] sums = new int[s.Length];
            List<int> list = new List<int>(s.Length);
            sums[0] = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                sums[i] = sums[i - 1] + s[i];
                int j = i >> 1;
                if (i % 2 == 1 && sums[i] == (sums[j] << 1) && s.Length % (i - j) == 0)
                    list.Add(i >> 1);
            }
            foreach (var pos in list)
            {
                int length = pos + 1;
                int n = s.Length / length;
                int i = 0;
                for (; i < length; i++)
                {
                    int j = 1;
                    for (; j < n; j++)
                    {
                        if (s[i + j * length] != s[i])
                            break;
                    }
                    if (j != n)
                        break;
                }
                if (i == length)
                    return true;
            }
            return false;
        }
        #endregion

        #region 461. Hamming Distance
        //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        //Given two integers x and y, calculate the Hamming distance.
        //Note:
        //0 <= x, y < 2^31.

        //Example:
        //Input: x = 1, y = 4
        //Output: 2
        //Explanation:
        //1   (0 0 0 1)
        //4   (0 1 0 0)
        //       ↑   ↑
        //The above arrows point to positions where the corresponding bits are different.
        public static int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            int count = 0;
            while (xor != 0)
            {
                if ((xor & 1) == 1)
                    count++;
                xor = xor >> 1;
            }
            return count;
        }
        #endregion

        #region 463. Island Perimeter
        //You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water.
        //Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water,
        //and there is exactly one island (i.e., one or more connected land cells). The island doesn't have "lakes" 
        //(water inside that isn't connected to the water around the island). One cell is a square with side length 1. 
        //The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
        public static int IslandPerimeter(int[,] grid)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            int perimeter = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i, j] == 1)
                        perimeter += Length(grid, row, col, i, j);
                }
            }
            return perimeter;
        }

        public static int Length(int[,] grid, int row, int col, int i, int j)
        {
            int count = 0;
            if (i == 0 || (i - 1 >= 0 && grid[i - 1, j] == 0)) count++;
            if (i == row - 1 || (i + 1 <= row - 1 && grid[i + 1, j] == 0)) count++;
            if (j == 0 || (j - 1 >= 0 && grid[i, j - 1] == 0)) count++;
            if (j == col - 1 || (j + 1 <= col - 1 && grid[i, j + 1] == 0)) count++;
            return count;
        }
        #endregion

        #region 475. Heaters ***
        //Winter is coming! Your first job during the contest is to design a standard heater with fixed warm radius to warm all the houses.
        //Now, you are given positions of houses and heaters on a horizontal line, find out minimum radius of heaters so that all houses could be covered by those heaters.
        //So, your input will be the positions of houses and heaters seperately, and your expected output will be the minimum radius standard of heaters.

        //Note:
        //  Numbers of houses and heaters you are given are non - negative and will not exceed 25000.
        //  Positions of houses and heaters you are given are non - negative and will not exceed 10 ^ 9.
        //  As long as a house is in the heaters' warm radius range, it can be warmed.
        //  All the heaters follow your radius standard and the warm radius will the same.

        //Example 1:
        //Input: [1,2,3],[2]
        //Output: 1
        //Explanation: The only heater was placed in the position 2, and if we use the radius 1 standard, then all the houses can be warmed.

        //Example 2:
        //Input: [1,2,3,4],[1,4]
        //Output: 1
        //Explanation: The two heater was placed in the position 1 and 4. We need to use radius 1 standard, then all the houses can be warmed.
        public static int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(heaters);
            int res = 0;
            int index = 0;
            foreach (var house in houses)
            {
                index = Array.BinarySearch(heaters, house);
                if (index < 0)
                {
                    index = ~index;
                    int dis1 = index - 1 >= 0 ? house - heaters[index - 1] : int.MaxValue;
                    int dis2 = index < heaters.Length ? heaters[index] - house : int.MaxValue;
                    res = Math.Max(res, Math.Min(dis1, dis2));
                }
            }
            return res;
        }
        #endregion

        #region 476. Number Complement
        //Given a positive integer, output its complement number.The complement strategy is to flip the bits of its binary representation.

        //Note:
        //   The given integer is guaranteed to fit within the range of a 32-bit signed integer.
        //   You could assume no leading zero bit in the integer’s binary representation.

        //Example 1:
        //Input: 5
        //Output: 2
        //Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.

        //Example 2:
        //Input: 1
        //Output: 0
        //Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output
        public static int FindComplement(int num)
        {
            int res = num ^ int.MaxValue;
            int n = 0;
            while (num != 0)
            {
                n = (n << 1) + 1;
                num = num >> 1;
            }
            return res & n;
        }
        #endregion

        #region 479. Largest Palindrome Product ***

        //Find the largest palindrome made from the product of two n-digit numbers.
        //Since the result could be very large, you should return the largest palindrome mod 1337.


        //Example:
        //Input: 2
        //Output: 987
        //Explanation: 99 x 91 = 9009, 9009 % 1337 = 987

        //Note:
        //The range of n is [1,8].
        public static int LargestPalindrome(int n)
        {
            if (n == 1)
                return 9;
            if (n % 2 == 0)
            {
                long x = (long)Math.Pow(10, n) + 1 - (long)Math.Pow(10, n / 2);
                long y = (long)Math.Pow(10, n) - 1;
                return (int)((x * y) % 1337);
            }
            long max = (long)Math.Pow(10, n) - 1;
            for (long v = max - 1; v > max / 10; v--)
            {
                var list = v.ToString().ToList();
                list.Reverse();
                long u = long.Parse(v + new string(list.ToArray()));
                for (long i = max; i * i >= u; i--)
                {
                    if (u % i == 0)
                        return (int)(u % 1337);
                }
            }
            return 0;
        }
        #endregion

        #region 482. License Key Formatting

        //You are given a license key represented as a string S which consists only alphanumeric character and dashes.The string is separated into N+1 groups by N dashes.

        //Given a number K, we would want to reformat the strings such that each group contains exactly K characters, except for the first group which could be shorter
        //than K, but still must contain at least one character. Furthermore, there must be a dash inserted between two groups and all lowercase letters should be converted to uppercase.

        //Given a non-empty string S and a number K, format the string according to the rules described above.

        //Example 1:
        //Input: S = "5F3Z-2e-9-w", K = 4
        //Output: "5F3Z-2E9W"
        //Explanation: The string S has been split into two parts, each part has 4 characters.
        //Note that the two extra dashes are not needed and can be removed.

        //Example 2:
        //Input: S = "2-5g-3-J", K = 2
        //Output: "2-5G-3J"
        //Explanation: The string S has been split into three parts, each part has 2 characters except the first part as it could be shorter as mentioned above.

        //Note:
        //  The length of string S will not exceed 12,000, and K is a positive integer.
        //  String S consists only of alphanumerical characters(a-z and/or A-Z and/or 0-9) and dashes(-).
        //  String S is non-empty.
        public static string LicenseKeyFormatting(string S, int K)
        {
            List<char> list = new List<char>(S.Length);
            int count = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] != '-')
                {
                    list.Add(Char.ToUpper(S[i]));
                    count++;
                    if (count == K)
                    {
                        list.Add('-');
                        count = 0;
                    }
                }
            }
            if (list.Count == 0)
                return "";
            if (list.Last() == '-')
                list.RemoveAt(list.Count - 1);
            list.Reverse();
            return new string(list.ToArray());
        }

        #endregion

        #region 485. Max Consecutive Ones
        //Given a binary array, find the maximum number of consecutive 1s in this array.

        //Example 1:
        //Input: [1,1,0,1,1,1]
        //Output: 3
        //Explanation: The first two digits or the last three digits are consecutive 1s.
        //The maximum number of consecutive 1s is 3.

        //Note:
        //The input array will only contain 0 and 1.
        //The length of input array is a positive integer and will not exceed 10,000
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int current = 0;
            foreach (var item in nums)
            {
                if (item == 1)
                    current++;
                else
                {
                    count = count > current ? count : current;
                    current = 0;
                }
            }
            return count = count > current ? count : current;
        }
        #endregion

        #region 492. Construct the Rectangle

        //For a web developer, it is very important to know how to design a web page's size. So, given a specific rectangular web 
        //page’s area, your job by now is to design a rectangular web page, whose length L and width W satisfy the following requirements:

        //1. The area of the rectangular web page you designed must equal to the given target area.
        //2. The width W should not be larger than the length L, which means L >= W.
        //3. The difference between length L and width W should be as small as possible.

        //You need to output the length L and the width W of the web page you designed in sequence.

        //Example:
        //Input: 4
        //Output: [2, 2]
        //Explanation: The target area is 4, and all the possible ways to construct it are[1, 4], [2,2], [4,1]. 
        //But according to requirement 2, [1,4] is illegal; according to requirement 3,  [4,1] is not optimal compared to[2, 2]. So the length L is 2, and the width W is 2.

        //Note:
        //The given area won't exceed 10,000,000 and is a positive integer
        //The web page's width and length you designed must be positive integers.
        public static int[] ConstructRectangle(int area)
        {
            int[] res = new int[2];
            res[1] = (int)Math.Sqrt(area);
            while (res[1] >= 1)
            {
                res[0] = area / res[1];
                if (area % res[1] == 0)
                    return res;
                res[1]--;
            }
            return res;
        }
        #endregion

        #region 496. Next Greater Element I ** 
        //You are given two arrays(without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2.Find all the next greater numbers for nums1's elements in the corresponding places of nums2.
        //The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2.If it does not exist, output -1 for this number.

        //Example 1:
        //Input: nums1 = [4, 1, 2], nums2 = [1, 3, 4, 2].
        //Output: [-1,3,-1]
        //Explanation:
        //For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1.
        //For number 1 in the first array, the next greater number for it in the second array is 3.
        //For number 2 in the first array, there is no next greater number for it in the second array, so output -1.

        //Example 2:
        //Input: nums1 = [2, 4], nums2 = [1, 2, 3, 4].
        //Output: [3,-1]
        //Explanation:
        //For number 2 in the first array, the next greater number for it in the second array is 3.
        //For number 4 in the first array, there is no next greater number for it in the second array, so output -1.

        //Note:
        //All elements in nums1 and nums2 are unique.
        //The length of both nums1 and nums2 would not exceed 1000.
        public static int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                dic.Add(nums[i], i);

            int[] res = new int[findNums.Length];
            for (int i = 0; i < findNums.Length; i++)
            {
                res[i] = -1;
                for (int j = dic[findNums[i]] + 1; j < nums.Length; j++)
                {
                    if (nums[j] > findNums[i])
                    {
                        res[i] = j;
                        break;
                    }
                }
            }
            return res;
        }
        public static int[] NextGreaterElement2(int[] findNums, int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in findNums)
            {
                dic.Add(item, -1);
            }
            Stack<int> stack = new Stack<int>();
            foreach (var item in nums)
            {
                while (stack.Count > 0 && stack.Peek() < item)
                {
                    dic[stack.Pop()] = item;
                }
                if (dic.ContainsKey(item))
                    stack.Push(item);
            }
            int[] res = new int[findNums.Length];
            for (int i = 0; i < findNums.Length; i++)
            {
                res[i] = dic[findNums[i]];
            }
            return res;
        }
        #endregion

        #region 500. Keyboard Row
        //Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
        public static string[] FindWords(string[] words)
        {
            int[] arr = { 1, 2, 2, 1, 0, 1, 1, 1, 0, 1, 1, 1, 2, 2, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 0, 2 };
            List<string> list = new List<string>();
            foreach (string word in words)
            {
                string newWord = word.ToUpper();
                int row = arr[newWord[0] - 'A'];

                bool b = true;
                foreach (var letter in newWord)
                {
                    if (row != arr[letter - 'A'])
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                    list.Add(word);
            }
            return list.ToArray();
        }
        #endregion

        #region 501. Find Mode in Binary Search Tree 
        //Given a binary search tree(BST) with duplicates, find all the mode(s) (the most frequently occurred element) in the given BST.
        //Assume a BST is defined as follows:

        //The left subtree of a node contains only nodes with keys less than or equal to the node's key.
        //The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
        //Both the left and right subtrees must also be binary search trees.

        //For example:
        //Given BST [1,null,2,2],
        //   1
        //    \
        //     2
        //    /
        //   2
        //return [2].

        //Note: If a tree has more than one mode, you can return them in any order.

        //Follow up: Could you do that without using any extra space? (Assume that the implicit stack space incurred due to recursion does not count).
        public static int[] FindMode(TreeNode root)
        {
            if (root == null)
                return new int[0];
            Queue<TreeNode> q = new Queue<TreeNode>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> list = new List<int>(100);
            q.Enqueue(root);
            int max = 1;
            while (q.Count != 0)
            {
                TreeNode node = q.Dequeue();
                if (dic.ContainsKey(node.val))
                {
                    dic[node.val]++;
                    int count = dic[node.val];
                    if (count > max)
                    {
                        list.Clear();
                        list.Add(node.val);
                        max = count;
                    }
                    else if (count == max)
                        list.Add(node.val);
                }
                else
                {
                    dic.Add(node.val, 1);
                    if (max == 1)
                        list.Add(node.val);
                }
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
            return list.ToArray();
        }
        #endregion

        #region 504. Base 7
        //Given an integer, return its base 7 string representation.

        //Example 1:
        //Input: 100
        //Output: "202"

        //Example 2:
        //Input: -7
        //Output: "-10"
        //Note: The input will be in range of[-1e7, 1e7].
        public static string ConvertToBase7(int num)
        {
            if (num == 0)
                return "0";
            string res = "";
            int newNum = Math.Abs(num);
            while (newNum != 0)
            {
                res = (newNum % 7) + res;
                newNum /= 7;
            }
            if (num < 0)
                return "-" + res;
            return res;
        }
        #endregion

        #region 506. Relative Ranks
        //Given scores of N athletes, find their relative ranks and the people with the top three highest scores, who will be awarded medals: "Gold Medal", "Silver Medal" and "Bronze Medal".

        //Example 1:
        //Input: [5, 4, 3, 2, 1]
        //Output: ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
        //Explanation: The first three athletes got the top three highest scores, so they got "Gold Medal", "Silver Medal" and "Bronze Medal". 
        //For the left two athletes, you just need to output their relative ranks according to their scores.

        //Note:
        //N is a positive integer and won't exceed 10,000.
        //All the scores of athletes are guaranteed to be unique.
        public static string[] FindRelativeRanks(int[] nums)
        {
            if (nums.Length == 0)
                return new string[0];
            if (nums.Length == 1)
            {
                return new string[] { "Gold Medal" };
            }
            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                    return new string[] { "Gold Medal", "Silver Medal" };
                else
                    return new string[] { "Silver Medal", "Gold Medal" };
            }
            string[] res = new string[nums.Length];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }
            dic = dic.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            int n = nums.Length;
            foreach (KeyValuePair<int, int> kv in dic)
            {
                if (n > 3)
                    res[kv.Value] = n.ToString();

                else if (n == 3)
                    res[kv.Value] = "Bronze Medal";

                else if (n == 2)
                    res[kv.Value] = "Silver Medal";
                else
                    res[kv.Value] = "Gold Medal";
                n--;
            }
            return res;
        }
        #endregion

        #region 507. Perfect Number
        //We define the Perfect Number is a positive integer that is equal to the sum of all its positive divisors except itself.
        //Now, given an integer n, write a function that returns true when it is a perfect number and false when it is not.

        //Example:
        //Input: 28
        //Output: True
        //Explanation: 28 = 1 + 2 + 4 + 7 + 14
        //Note: The input number n will not exceed 100,000,000. (1e8)
        public static bool CheckPerfectNumber(int num)
        {
            if (num < 6)
                return false;

            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    sum += i + num / i;
            }
            return num == sum;
        }
        #endregion

        #region 520. Detect Capital
        //Given a word, you need to judge whether the usage of capitals in it is right or not.
        //We define the usage of capitals in a word to be right when one of the following cases holds:

        //  All letters in this word are capitals, like "USA".
        //  All letters in this word are not capitals, like "leetcode".
        //  Only the first letter in this word is capital if it has more than one letter, like "Google".
        //  Otherwise, we define that this word doesn't use capitals in a right way.

        //Example 1:
        //Input: "USA"
        //Output: True

        //Example 2:
        //Input: "FlaG"
        //Output: False

        //Note: The input will be a non-empty word consisting of uppercase and lowercase latin letters.
        public static bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
                return true;

            if (word[1] >= 'A' && word[1] <= 'Z' && word[0] >= 'a' && word[0] <= 'z')
                return false;

            char left = 'a', right = 'z';
            if (word[1] >= 'A' && word[1] <= 'Z' && word[0] >= 'A' && word[0] <= 'Z')
            {
                left = 'A';
                right = 'Z';
            }
            for (int i = 2; i < word.Length; i++)
            {
                if (!(word[i] >= left && word[i] <= right))
                    return false;
            }
            return true;
        }


        #endregion

        #region 521. Longest Uncommon Subsequence I 
        //Given a group of two strings, you need to find the longest uncommon subsequence of this group of two strings.
        //The longest uncommon subsequence is defined as the longest subsequence of one of these strings and this 
        //subsequence should not be any subsequence of the other strings.

        //A subsequence is a sequence that can be derived from one sequence by deleting some characters without changing 
        //the order of the remaining elements.Trivially, any string is a subsequence of itself and an empty string is a
        //subsequence of any string.


        //The input will be two strings, and the output needs to be the length of the longest uncommon subsequence.
        //If the longest uncommon subsequence doesn't exist, return -1.

        //Example 1:
        //Input: "aba", "cdc"
        //Output: 3
        //Explanation: The longest uncommon subsequence is "aba" (or "cdc"), 
        //because "aba" is a subsequence of "aba", 
        //but not a subsequence of any other strings in the group of two strings.

        //Note:
        //  Both strings' lengths will not exceed 100.
        //  Only letters from a ~z will appear in input strings.
        public static int FindLUSlength(string a, string b)
        {
            return a == b ? -1 : Math.Max(a.Length, b.Length);
        }

        #endregion

        #region 530. Minimum Absolute Difference in BST
        //Given a binary search tree with non-negative values, find the minimum absolute difference between values of any two nodes.
        public static int GetMinimumDifference(TreeNode root)
        {
            List<int> list = new List<int>(100);
            GetNode(root, list);
            int min = list[1] - list[0];
            for (int i = 2; i < list.Count; i++)
            {
                int tmp = list[i] - list[i - 1];
                min = min < tmp ? min : tmp;
            }
            return min;
        }

        public static void GetNode(TreeNode node, List<int> list)
        {
            if (node == null)
                return;
            if (node.left != null)
                GetNode(node.left, list);
            list.Add(node.val);
            if (node.right != null)
                GetNode(node.right, list);
        }
        #endregion

        #region 532. K-diff Pairs in an Array **
        //Given an array of integers and an integer k, you need to find the number of unique k-diff pairs in the array.
        //Here a k-diff pair is defined as an integer pair (i, j), where i and j are both numbers in the array and their absolute difference is k.

        //Example 1:
        //Input: [3, 1, 4, 1, 5], k = 2
        //Output: 2
        //Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        //Although we have two 1s in the input, we should only return the number of unique pairs.

        //Example 2:
        //Input:[1, 2, 3, 4, 5], k = 1
        //Output: 4
        //Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and(4, 5).

        //Example 3:
        //Input: [1, 3, 1, 5, 4], k = 0
        //Output: 1
        //Explanation: There is one 0-diff pair in the array, (1, 1).

        //Note:
        //The pairs(i, j) and(j, i) count as the same pair.
        //The length of the array won't exceed 10,000.
        //All the integers in the given input belong to the range: [-1e7, 1e7].
        public static int FindPairs(int[] nums, int k)
        {
            if (nums.Length <= 1)
                return 0;
            Array.Sort(nums);
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int tmp = nums[j] - nums[i];
                    if (tmp == k)
                        hs.Add(nums[j]);
                    else if (tmp > k)
                        break;
                }
            }
            return hs.Count;
        }
        public static int FindPairs2(int[] nums, int k)
        {
            if (nums.Length <= 1)
                return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            HashSet<int> hs = new HashSet<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
                else
                    hs.Add(nums[i]);
            }
            if (k == 0)
                return hs.Count;
            foreach (KeyValuePair<int, int> kv in dic)
            {
                if (dic.ContainsKey(kv.Value + k))
                    count++;
            }
            return count;
        }
        #endregion

        #region 538. Convert BST to Greater Tree ***
        //Given a Binary Search Tree(BST), convert it to a Greater Tree such that every key of the original BST is 
        //changed to the original key plus sum of all keys greater than the original key in BST.

        //Example:
        //Input: The root of a Binary Search Tree like this:
        //              5
        //            /   \
        //           2     13

        //Output: The root of a Greater Tree like this:
        //             18
        //            /   \
        //          20     13
        public static TreeNode ConvertBST(TreeNode root)
        {
            int sum = 0;
            ConvertBST(root, ref sum);
            return root;
        }

        public static void ConvertBST(TreeNode root, ref int sum)
        {
            if (root == null)
                return;
            ConvertBST(root.right, ref sum);
            root.val += sum;
            sum = root.val;
            ConvertBST(root.left, ref sum);
        }
        #endregion

        #region 541. Reverse String II
        //Given a string and an integer k, you need to reverse the first k characters for every 2k characters counting from the start of the string. If there are less than k characters left, reverse all of them.If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and left the other as original.
        //Example:
        //Input: s = "abcdefg", k = 2
        //Output: "bacdfeg"
        //Restrictions:
        //The string consists of lower English letters only.
        //Length of the given string and k will in the range[1, 10000]
        public static string ReverseStr(string s, int k)
        {
            char[] arr = s.ToCharArray();
            if (s.Length <= k)
            {
                Array.Reverse(arr);
                return new string(arr);
            }
            int n = k << 1;
            int count = s.Length / n;
            if (s.Length % n >= k)
                count++;
            int i = 0;
            while (i < count)
            {
                int star = i * n;
                int end = star + k - 1;
                for (int j = 0; j < k / 2; j++)
                {
                    char tmp = arr[j + star];
                    arr[j + star] = arr[end - j];
                    arr[end - j] = tmp;
                }
                i++;
            }
            if (s.Length % n < k)
            {
                int star = i * n;
                int length = (arr.Length - star) >> 1;
                for (int j = 0; j < length; j++)
                {
                    char tmp = arr[j + star];
                    arr[j + star] = arr[arr.Length - j - 1];
                    arr[arr.Length - j - 1] = tmp;
                }
            }
            return new string(arr);
        }

        #endregion

        #region 543. Diameter of Binary Tree ***
        //Given a binary tree, you need to compute the length of the diameter of the tree.The diameter of a binary tree is the length of the longest 
        //path between any two nodes in a tree.This path may or may not pass through the root.

        //Example:
        //Given a binary tree 
        //          1
        //         / \
        //        2   3
        //       / \     
        //      4   5    
        //Return 3, which is the length of the path[4, 2, 1, 3] or [5,2,1,3].

        //Note: The length of path between two nodes is represented by the number of edges between them.
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int r = 0;
            MaxDeep(root, ref r);
            return r;
        }

        public static int MaxDeep(TreeNode root, ref int r)
        {
            if (root == null)
                return 0;
            int left = MaxDeep(root.left, ref r);
            int right = MaxDeep(root.right, ref r);
            r = Math.Max(r, left + right);
            return Math.Max(left, right) + 1;
        }
        #endregion

        #region 551. Student Attendance Record I
        //You are given a string representing an attendance record for a student.The record only contains the following three characters:
        //'A' : Absent.
        //'L' : Late.
        //'P' : Present.
        //A student could be rewarded if his attendance record doesn't contain more than one 'A' (absent) or more than two continuous 'L' (late).

        //You need to return whether the student could be rewarded according to his attendance record.

        //Example 1:
        //Input: "PPALLP"
        //Output: True

        //Example 2:
        //Input: "PPALLL"
        //Output: False
        public static bool CheckRecord(string s)
        {
            if (s.Length <= 2)
                return !(s == "AA");
            int a = 0, l = 0;
            foreach (var item in s)
            {
                if (item == 'A')
                {
                    a++;
                    l = 0;
                    if (a >= 2)
                        return false;
                }
                else if (item == 'L')
                {
                    l++;
                    if (l >= 3)
                        return false;
                }
                else
                    l = 0;
            }
            return true;
        }
        #endregion

        #region 557. Reverse Words in a String III
        //Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

        //Example 1:
        //Input: "Let's take LeetCode contest"
        //Output: "s'teL ekat edoCteeL tsetnoc"
        //Note: In the string, each word is separated by single space and there will not be any extra space in the string.
        public static string ReverseWords(string s)
        {
            if (s.Length <= 1 || s == null)
                return s;
            int flag = -1;
            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    for (int j = i - 1; j > flag; j--)
                        sb.Append(s[j]);
                    sb.Append(' ');
                    flag = i;
                }
                else if (i == s.Length - 1)
                {
                    for (int j = i; j > flag; j--)
                        sb.Append(s[j]);
                }
            }
            return sb.ToString();
        }
        #endregion

        #region 561. Array Partition I
        //Given an array of 2n integers, your task is to group these integers into n pairs of integer, say(a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.

        //Example 1:
        //Input: [1,4,3,2]
        //Output: 4
        //Explanation: n is 2, and the maximum sum of pairs is 4 = min(1, 2) + min(3, 4).

        //Note:
        //n is a positive integer, which is in the range of[1, 10000].
        //All the integers in the array will be in the range of[-10000, 10000].
        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }
            return sum;
        }
        #endregion

        #region 563. Binary Tree Tilt **
        //Given a binary tree, return the tilt of the whole tree.

        //The tilt of a tree node is defined as the absolute difference between the sum of all left subtree node values and the sum of all right subtree node values.Null node has tilt 0.


        //The tilt of the whole tree is defined as the sum of all nodes' tilt.

        //Example:
        //Input: 
        //         1
        //       /   \
        //      2     3
        //Output: 1
        //Explanation: 
        //Tilt of node 2 : 0
        //Tilt of node 3 : 0
        //Tilt of node 1 : |2-3| = 1
        //Tilt of binary tree : 0 + 0 + 1 = 1

        //Note:
        //  The sum of node values in any subtree won't exceed the range of 32-bit integer.
        //  All the tilt values won't exceed the range of 32-bit integer.
        public static int FindTilt(TreeNode root)
        {
            int sum = 0;
            FindTilt(root, ref sum);
            return sum;
        }

        public static int FindTilt(TreeNode root, ref int sum)
        {
            if (root == null)
                return 0;
            int left = FindTilt(root.left, ref sum);
            int right = FindTilt(root.right, ref sum);
            root.val += left + right;
            sum += Math.Abs(left - right);
            return root.val;
        }
        #endregion

        #region 566. Reshape the Matrix
        //In MATLAB, there is a very useful function called 'reshape', which can reshape a matrix into a new one with different size but keep its original data.

        //You're given a matrix represented by a two-dimensional array, and two positive integers r and c representing the row number and column number of the wanted reshaped matrix, respectively.

        //The reshaped matrix need to be filled with all the elements of the original matrix in the same row-traversing order as they were.

        //If the 'reshape' operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

        //Example 1:
        //Input: 
        //nums =
        //[[1, 2],
        // [3,4]]
        //r = 1, c = 4
        //Output: 
        //[[1,2,3,4]]
        //Explanation:
        //The row-traversing of nums is [1,2,3,4]. The new reshaped matrix is a 1 * 4 matrix, fill it row by row by using the previous list.

        //Example 2:
        //Input: 
        //nums =
        //[[1, 2],
        //[3,4]]
        //r = 2, c = 4
        //Output: 
        //[[1,2],
        // [3,4]]
        //Explanation:
        //There is no way to reshape a 2 * 2 matrix to a 2 * 4 matrix.So output the original matrix.

        //Note:
        //  The height and width of the given matrix is in range[1, 100].
        //  The given r and c are all positive.
        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int n = nums.GetLength(0), m = nums.GetLength(1);
            if (n * m != r * c)
                return nums;
            int[,] res = new int[r, c];
            int i = 0, j = 0;
            foreach (var item in nums)
            {
                if (j < c)
                    res[i, j++] = item;
                else
                {
                    i++;
                    j = 0;
                    res[i, j++] = item;
                }
            }
            return res;
        }
        #endregion

        #region 572. Subtree of Another Tree
        //Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with a subtree of s.
        //A subtree of s is a tree consists of a node in s and all of this node's descendants. The tree s could also be considered as a subtree of itself.

        //Example 1:
        //Given tree s:
        //     3
        //    / \
        //   4   5
        //  / \
        // 1   2
        //Given tree t:
        //   4 
        //  / \
        // 1   2
        //Return true, because t has the same structure and node values with a subtree of s.

        //Example 2:
        //Given tree s:
        //     3
        //    / \
        //   4   5
        //  / \
        // 1   2
        //    /
        //   0
        //Given tree t:
        //   4
        //  / \
        // 1   2
        //Return false.
        public static bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
                return t == null;
            if (t == null)
                return true;
            if (s.val == t.val && WhetherSameTree(s, t))
                return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
        public static bool WhetherSameTree(TreeNode s, TreeNode t)
        {
            if (s == null)
                return t == null;
            if (t == null)
                return s == null;
            if (s.val != t.val)
                return false;
            return WhetherSameTree(s.left, t.left) && WhetherSameTree(s.right, t.right);
        }
        #endregion

        #region 575. Distribute Candies
        //Given an integer array with even length, where different numbers in this array represent different kinds of candies.
        //Each number means one candy of the corresponding kind. You need to distribute these candies equally in number to 
        //brother and sister.Return the maximum number of kinds of candies the sister could gain.

        //Example 1:
        //Input: candies = [1, 1, 2, 2, 3, 3]
        //Output: 3
        //Explanation:
        //There are three different kinds of candies (1, 2 and 3), and two candies for each kind.
        //Optimal distribution: The sister has candies [1,2,3] and the brother has candies[1, 2, 3], too.
        //The sister has three different kinds of candies. 

        //Example 2:
        //Input: candies = [1, 1, 2, 3]
        //Output: 2
        //Explanation: For example, the sister has candies [2,3] and the brother has candies[1, 1]. 
        //The sister has two different kinds of candies, the brother has only one kind of candies. 

        //Note:
        //  The length of the given array is in range[2, 10, 000], and will be even.
        //  The number in given array is in range[-100, 000, 100, 000].
        public static int DistributeCandies(int[] candies)
        {
            HashSet<int> hs = new HashSet<int>();
            foreach (var item in candies)
            {
                hs.Add(item);
                if (hs.Count == candies.Length / 2)
                    break;
            }
            return hs.Count;
        }
        #endregion

        #region 581. Shortest Unsorted Continuous Subarray
        //Given an integer array, you need to find one continuous subarray that if you only sort this subarray in ascending order, then the whole array will be sorted in ascending order, too.

        //You need to find the shortest such subarray and output its length.


        //Example 1:
        //Input: [2, 6, 4, 8, 10, 9, 15]
        //Output: 5
        //Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to make the whole array sorted in ascending order.

        //Note:
        //  Then length of the input array is in range[1, 10, 000].
        //  The input array may contain duplicates, so ascending order here means <=.
        public static int FindUnsortedSubarray(int[] nums)
        {
            List<int> list = nums.ToList();
            list.Sort();
            int i = 0, j = nums.Length - 1;
            while (i < nums.Length)
            {
                if (nums[i] != list[i])
                    break;
                i++;
            }
            while (j > i)
            {
                if (nums[j] != list[j])
                    break;
                j--;
            }
            return j - i + 1;
        }
        #endregion

        #region 594. Longest Harmonious Subsequence
        //We define a harmonious array is an array where the difference between its maximum value and its minimum value is exactly 1.

        //Now, given an integer array, you need to find the length of its longest harmonious subsequence among all its possible subsequences.

        //Example 1:
        //Input: [1,3,2,2,5,2,3,7]
        //Output: 5
        //Explanation: The longest harmonious subsequence is [3,2,2,2,3].
        //Note: The length of the input array will not exceed 20,000.
        public static int FindLHS(int[] nums)
        {
            if (nums.Length <= 1)
                return 0;
            Array.Sort(nums);
            if (nums.Last() - nums.First() == 0)
                return 0;
            if (nums.Last() - nums.First() == 1)
                return nums.Length;
            Queue<int> q = new Queue<int>();
            q.Enqueue(nums[0]);
            int max = 0;
            bool b = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - q.Peek() > 1)
                {
                    if (!b)
                        max = max > q.Count ? max : q.Count;
                    while (q.Count != 0 && nums[i] - q.Peek() > 1)
                        q.Dequeue();
                }
                else if (nums[i] - q.Peek() == 0)
                {
                    b = true;
                }
                else
                    b = false;
                q.Enqueue(nums[i]);
            }

            if (q.Count == 1 && max <= 1)
                return 0;
            return max > q.Count ? max : q.Count;
        }

        public static int FindLHS2(int[] nums)
        {
            if (nums.Length <= 1)
                return 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item, 1);
            }
            int max = 0;
            foreach (KeyValuePair<int, int> kv in dic)
            {
                if (dic.ContainsKey(kv.Key + 1))
                {
                    int tmp = kv.Value + dic[kv.Key + 1];
                    max = max > tmp ? max : tmp;
                }
            }
            return max;
        }


        #endregion

        #region 598. Range Addition II
        //Given an m* n matrix M initialized with all 0's and several update operations.

        //Operations are represented by a 2D array, and each operation is represented by an array with two positive integers a and b, which means M[i][j] should be added by one for all 0 <= i<a and 0 <= j<b.

        //You need to count and return the number of maximum integers in the matrix after performing all the operations.

        //Example 1:
        //Input: 
        //m = 3, n = 3
        //operations = [[2, 2],[3,3]]
        //Output: 4
        //Explanation: 
        //Initially, M = 
        //[[0, 0, 0],
        // [0, 0, 0],
        // [0, 0, 0]]

        //After performing[2, 2], M =
        //[[1, 1, 0],
        // [1, 1, 0],
        // [0, 0, 0]]

        //After performing[3, 3], M =
        //[[2, 2, 1],
        // [2, 2, 1],
        // [1, 1, 1]]

        //So the maximum integer in M is 2, and there are four of it in M.So return 4.

        //Note:
        //  The range of m and n is [1,40000].
        //  The range of a is [1, m], and the range of b is [1, n].
        //  The range of operations size won't exceed 10,000.
        public static int MaxCount(int m, int n, int[,] ops)
        {
            int row = ops.GetLength(0);
            int x = m, y = n;
            for (int i = 0; i < row; i++)
            {
                x = Math.Min(x, ops[i, 0]);
                y = Math.Min(y, ops[i, 1]);
            }
            return x * y;
        }
        #endregion

        #region 599. Minimum Index Sum of Two Lists
        //Suppose Andy and Doris want to choose a restaurant for dinner, and they both have a list of favorite restaurants represented by strings.

        //You need to help them find out their common interest with the least list index sum.If there is a choice tie between answers, output all 
        //of them with no order requirement. You could assume there always exists an answer.

        //Example 1:
        //Input:
        //["Shogun", "Tapioca Express", "Burger King", "KFC"]
        //["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
        //Output: ["Shogun"]
        //Explanation: The only restaurant they both like is "Shogun".

        //Example 2:
        //Input:
        //["Shogun", "Tapioca Express", "Burger King", "KFC"]
        //["KFC", "Shogun", "Burger King"]
        //Output: ["Shogun"]
        //Explanation: The restaurant they both like and have the least index sum is "Shogun" with index sum 1 (0+1).

        //Note:
        //  The length of both lists will be in the range of[1, 1000].
        //  The length of strings in both lists will be in the range of[1, 30].
        //  The index is starting from 0 to the list length minus 1.
        //  No duplicates in both lists.
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            string[] str1 = list1, str2 = list2;
            if (list1.Length > list2.Length)
            {
                str1 = list2;
                str2 = list1;
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> res = new List<string>(str1.Length);
            int min = int.MaxValue;
            for (int i = 0; i < str1.Length; i++)
            {
                dic.Add(str1[i], i);
            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (dic.ContainsKey(str2[i]))
                {
                    int tmp = dic[str2[i]] + i;
                    if (tmp < min)
                    {
                        res.Clear();
                        min = tmp;
                        res.Add(str2[i]);
                    }
                    else if (tmp == min)
                        res.Add(str2[i]);
                }
            }
            return res.ToArray();
        }
        #endregion

        #region 605. Can Place Flowers
        //Suppose you have a long flowerbed in which some of the plots are planted and some are not.However, flowers cannot 
        //be planted in adjacent plots - they would compete for water and both would die.

        //Given a flowerbed(represented as an array containing 0 and 1, where 0 means empty and 1 means not empty), and a 
        //number n, return if n new flowers can be planted in it without violating the no-adjacent-flowers rule.

        //Example 1:
        //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //Output: True

        //Example 2:
        //Input: flowerbed = [1, 0, 0, 0, 1], n = 2
        //Output: False

        //Note:
        //  The input array won't violate no-adjacent-flowers rule.
        //  The input array size is in the range of[1, 20000].
        //  n is a non-negative integer which won't exceed the input array size.
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;
            if (flowerbed.Length == 1)
                return flowerbed[0] == 0;
            int pre = 0;
            for (int i = 0; i < flowerbed.Length - n; i++)
            {
                if (pre == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                {
                    n--;
                    flowerbed[i] = 1;
                }
                if (n == 0)
                    return true;
                pre = flowerbed[i];
            }
            if (n == 1 && flowerbed[flowerbed.Length - 2] == 0 && flowerbed.Last() == 0)
                return true;
            return n == 0;
        }
        #endregion

        #region 606. Construct String from Binary Tree
        //You need to construct a string consists of parenthesis and integers from a binary tree with the preorder traversing way.

        //The null node needs to be represented by empty parenthesis pair "()". And you need to omit all the empty parenthesis pairs 
        //that don't affect the one-to-one mapping relationship between the string and the original binary tree.

        //Example 1:
        //Input: Binary tree: [1,2,3,4]
        //       1
        //     /   \
        //    2     3
        //   /    
        //  4     

        //Output: "1(2(4))(3)"

        //Explanation: Originallay it needs to be "1(2(4)())(3()())", 
        //but you need to omit all the unnecessary empty parenthesis pairs.
        //And it will be "1(2(4))(3)".

        //Example 2:
        //Input: Binary tree: [1,2,3,null,4]
        //       1
        //     /   \
        //    2     3
        //     \  
        //      4 

        //Output: "1(2()(4))(3)"

        //Explanation: Almost the same as the first example, 
        //except we can't omit the first parenthesis pair to break the one-to-one mapping relationship between the input and the outp
        public static string Tree2str(TreeNode t)
        {
            if (t == null)
                return "";
            StringBuilder sb = new StringBuilder();
            Tree2str(t, sb);
            if (sb.Length == 3)
                return t.val.ToString();
            return sb.ToString(1, sb.Length - 2);
        }
        public static void Tree2str(TreeNode t, StringBuilder sb)
        {
            sb.Append("(" + t.val);
            if (t.left != null)
                Tree2str(t.left, sb);
            else if (t.left == null && t.right != null)
                sb.Append("()");
            if (t.right != null)
                Tree2str(t.right, sb);
            sb.Append(")");
        }
        #endregion

        #region 617. Merge Two Binary Trees
        //Given two binary trees and imagine that when you put one of them to cover the other, some nodes of the two
        //trees are overlapped while the others are not.

        //You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, then sum node 
        //values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.

        //Example 1:
        //Input: 
        //	Tree 1                     Tree 2                  
        //          1                         2                             
        //         / \                       / \                            
        //        3   2                     1   3                        
        //       /                           \   \                      
        //      5                             4   7                  
        //Output: 
        //Merged tree:
        //	     3
        //	    / \
        //	   4   5
        //	  / \   \ 
        //	 5   4   7
        //Note: The merging process must start from the root nodes of both trees.
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;
            TreeNode node = new TreeNode(t1.val + t2.val);
            node.left = MergeTrees(t1.left, t2.left);
            node.right = MergeTrees(t1.right, t2.right);
            return node; ;
        }



        #endregion

        #region 628. Maximum Product of Three Numbers
        //Given an integer array, find three numbers whose product is maximum and output the maximum product.

        //Note:
        //  The length of the given array will be in range[3, 104] and all elements are in the range[-1000, 1000].
        //  Multiplication of any three numbers in the input won't exceed the range of 32-bit signed integer.
        public static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int tmp1 = nums.Last() * nums[nums.Length - 2] * nums[nums.Length - 3];
            if (nums[0] < 0 && nums[1] < 0)
            {
                int tmp2 = nums[0] * nums[1] * nums.Last();
                return tmp2 > tmp1 ? tmp2 : tmp1;
            }
            return tmp1;
        }
        #endregion

        #region 633. Sum of Square Numbers *
        //Given a non-negative integer c, your task is to decide whether there're two integers a and b such that a^2 + b^2 = c.

        //Example 1:
        //Input: 5
        //Output: True
        //Explanation: 1 * 1 + 2 * 2 = 5

        //Example 2:
        //Input: 3
        //Output: False
        public static bool JudgeSquareSum(int c)
        {
            if (c < 0)
                return false;
            int n = (int)Math.Sqrt(c) + 1;
            for (int i = 0; i <= n; i++)
            {
                int y = c - i * i;
                int x = (int)Math.Sqrt(y);
                if (x * x == y)
                    return true;
            }
            return false;
        }
        public static bool JudgeSquareSum2(int c)
        {
            int n1 = 0, n2 = (int)Math.Sqrt(c);
            while (n1 <= n2)
            {
                int cur = n1 * n1 + n2 * n2;
                if (cur == c) return true;
                if (cur < c) n1++;
                else n2--;
            }
            return false;
        }
        #endregion

        #region 637. Average of Levels in Binary Tree
        //Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.

        //xample 1:
        //Input:
        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //Output: [3, 14.5, 11]
        //Explanation:
        //The average value of nodes on level 0 is 3,  on level 1 is 14.5, and on level 2 is 11. Hence return [3, 14.5, 11].

        //Note:
        //  The range of node's value is in the range of 32-bit signed integer.
        public static IList<double> AverageOfLevels(TreeNode root)
        {
            List<double> list = new List<double>(100);
            if (root == null)
                return list;
            Queue<TreeNode> qTree = new Queue<TreeNode>();
            qTree.Enqueue(root);
            while (qTree.Count != 0)
            {
                int n = qTree.Count;
                double sum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    TreeNode node = qTree.Dequeue();
                    sum += node.val;
                    if (node.left != null) qTree.Enqueue(node.left);
                    if (node.right != null) qTree.Enqueue(node.right);
                }
                list.Add(sum / n);
            }
            return list;
        }
        #endregion

        #region 643. Maximum Average Subarray I
        //Given an array consisting of n integers, find the contiguous subarray of given length k that has the maximum average value.And you need to output the maximum average value.

        //Example 1:
        //Input: [1,12,-5,-6,50,3], k = 4
        //Output: 12.75
        //Explanation: Maximum average is (12-5-6+50)/4 = 51/4 = 12.75

        //Note:
        //  1 <= k <= n <= 30,000.
        //  Elements of the given array will be in the range[-10, 000, 10, 000].
        public static double FindMaxAverage(int[] nums, int k)
        {
            if (nums.Length < k)
                return nums.Average();
            int max = 0;
            for (int i = 0; i < k; i++)
            {
                max += nums[i];
            }
            int sum = max;
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i - k] + nums[i];
                max = Math.Max(sum, max);
            }
            return max / k;
        }
        #endregion

        #region  645.Set Mismatch
        //The set S originally contains numbers from 1 to n.But unfortunately, due to the data error, one of the numbers in the set got duplicated 
        //to another number in the set, which results in repetition of one number and loss of another number.

        //Given an array nums representing the data status of this set after the error. Your task is to firstly find the number occurs twice and 
        //then find the number that is missing.Return them in the form of an array.

        //Example 1:
        //Input: nums = [1, 2, 2, 4]
        //Output: [2,3]

        //Note:
        //  The given array size will in the range [2, 10000].
        //  The given array's numbers won't have any order.
        public static int[] FindErrorNums(int[] nums)
        {
            int[] flag = new int[nums.Length + 1];
            int[] res = new int[2];
            int sum = 0, current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += i + 1;
                current += nums[i];
                if (flag[nums[i]] == 1)
                    res[0] = nums[i];
                else
                    flag[nums[i]] = 1;
            }
            res[1] = sum - (current - res[0]);
            return res;
        }
        #endregion

        #region 653. Two Sum IV - Input is a BST
        //Given a Binary Search Tree and a target number, return true if there exist two elements in the BST such that their sum is equal to the given target.

        //Example 1:
        //Input: 
        //    5
        //   / \
        //  3   6
        // / \   \
        //2   4   7
        //Target = 9
        //Output: True

        //Example 2:
        //Input: 
        //    5
        //   / \
        //  3   6
        // / \   \
        //2   4   7
        //Target = 28
        //Output: False
        public static bool FindTarget(TreeNode root, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            SaveTreeToDic(root, dic);
            foreach (KeyValuePair<int, int> kv in dic)
            {
                int tmp = k - kv.Key;
                if (tmp == kv.Key && kv.Value > 1)
                    return true;
                else if (tmp != kv.Key && dic.ContainsKey(tmp))
                    return true;
            }
            return false;
        }

        public static void SaveTreeToDic(TreeNode node, Dictionary<int, int> dic)
        {
            if (node == null)
                return;
            if (!dic.ContainsKey(node.val))
                dic.Add(node.val, 1);
            else
                dic[node.val]++;
            SaveTreeToDic(node.left, dic);
            SaveTreeToDic(node.right, dic);
        }
        #endregion

        #region 657. Judge Route Circle
        //Initially, there is a Robot at position(0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.

        //The move sequence is represented by a string. And each move is represent by a character. The valid robot moves are R (Right), L (Left), U (Up) and D (down). 
        //The output should be true or false representing whether the robot makes a circle.

        //Example 1:
        //Input: "UD"
        //Output: true

        //Example 2:
        //Input: "LL"
        //Output: false
        public static bool JudgeCircle(string moves)
        {
            if (moves.Length % 2 != 0)
                return false;
            int[] res = new int[26];
            foreach (var item in moves)
                res[item - 'A']++;

            return res['R' - 'A'] == res['L' - 'A'] && res['U' - 'A'] == res['D' - 'A'];
        }
        #endregion

        #region 661. Image Smoother
        //Given a 2D integer matrix M representing the gray scale of an image, you need to design a smoother to make the gray scale of each cell becomes the 
        //average gray scale (rounding down) of all the 8 surrounding cells and itself. If a cell has less than 8 surrounding cells, then use as many as you can.

        //Example 1:
        //Input:
        //[[1,1,1],
        // [1,0,1],
        // [1,1,1]]
        //Output:
        //[[0, 0, 0],
        // [0, 0, 0],
        // [0, 0, 0]]
        //Explanation:
        //For the point (0,0), (0,2), (2,0), (2,2): floor(3/4) = floor(0.75) = 0
        //For the point (0,1), (1,0), (1,2), (2,1): floor(5/6) = floor(0.83333333) = 0
        //For the point (1,1): floor(8/9) = floor(0.88888889) = 0

        //Note:
        //  The value in the given matrix is in the range of [0, 255].
        //  The length and width of the given matrix are in the range of [1, 150].
        public static int[,] ImageSmoother(int[,] M)
        {
            int row = M.GetLength(0), col = M.GetLength(1);
            int[,] res = new int[row, col];
            int[] dir = { -1, 0, 1 };
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    int sum = M[i, j], count = 1;
                    foreach (var r in dir)
                    {
                        int ii = i + r;
                        if (ii >= 0 && ii < row)
                        {
                            foreach (var c in dir)
                            {
                                int jj = c + j;
                                if (jj >= 0 && jj < col)
                                {
                                    sum += M[ii, jj];
                                    count++;
                                }
                            }
                        }
                    }
                    res[i, j] = sum / count;
                }
            return res;
        }
        #endregion

        #region 665. Non-decreasing Array
        //Given an array with n integers, your task is to check if it could become non-decreasing by modifying at most 1 element.

        //We define an array is non-decreasing if array[i] <= array[i + 1] holds for every i (1 <= i < n).

        //Example 1:
        //Input: [4,2,3]
        //Output: True
        //Explanation: You could modify the first 4 to 1 to get a non-decreasing array.

        //Example 2:
        //Input: [4,2,1]
        //Output: False
        //Explanation: You can't get a non-decreasing array by modify at most one element.

        //Note: The n belongs to [1, 10,000].
        public static bool CheckPossibility(int[] nums)
        {
            if (nums.Length <= 2)
                return true;
            int count = 0, pre = int.MinValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int next = nums[i + 1];
                    if (pre > next)
                    {
                        if (i + 2 < nums.Length && nums[i] > nums[i + 2])
                            return false;
                    }
                    count++;
                    if (count == 2)
                        return false;
                }
                pre = nums[i];
            }
            return true;
        }
        #endregion

        #region 669. Trim a Binary Search Tree
        //Given a binary search tree and the lowest and highest boundaries as L and R, trim the tree so that all its elements lies in 
        //[L, R] (R >= L). You might need to change the root of the tree, so the result should return the new root of the trimmed binary search tree.

        //Example 1:
        //Input: 
        //    1
        //   / \
        //  0   2

        //  L = 1
        //  R = 2

        //Output: 
        //    1
        //      \
        //       2

        //Example 2:
        //Input: 
        //    3
        //   / \
        //  0   4
        //   \
        //    2
        //   /
        //  1

        //  L = 1
        //  R = 3

        //Output: 
        //      3
        //     / 
        //   2   
        //  /
        // 1
        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            if (root.val < L)
                return TrimBST(root.right, L, R);
            if (root.val > R)
                return TrimBST(root.left, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);

            return root;
        }
        #endregion

        #region 671. Second Minimum Node In a Binary Tree
        //Given a non-empty special binary tree consisting of nodes with the non-negative value, where each node in this 
        //tree has exactly two or zero sub-node. If the node has two sub-nodes, then this node's value is the smaller value among its two sub-nodes.

        //Given such a binary tree, you need to output the second minimum value in the set made of all the nodes' value in the whole tree.

        //If no such second minimum value exists, output -1 instead.

        //Example 1:
        //Input: 
        //    2
        //   / \
        //  2   5
        //     / \
        //    5   7

        //Output: 5
        //Explanation: The smallest value is 2, the second smallest value is 5.

        //Example 2:
        //Input: 
        //    2
        //   / \
        //  2   2

        //Output: -1
        //Explanation: The smallest value is 2, but there isn't any second smallest value.
        public static int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null)
                return -1;
            long[] res = { long.MaxValue, long.MaxValue };
            FindSecondMinimumValue(root, res);
            if (res[1] == long.MaxValue)
                return -1;
            return (int)res[1];
        }
        public static void FindSecondMinimumValue(TreeNode root, long[] res)
        {
            if (root == null)
                return;
            if (root.val < res[0])
            {
                res[1] = res[0];
                res[0] = root.val;
            }
            else if (root.val < res[1] && root.val != res[0])
            {
                res[1] = root.val;
            }
            FindSecondMinimumValue(root.left, res);
            FindSecondMinimumValue(root.right, res);
        }
        #endregion

        #region 674. Longest Continuous Increasing Subsequence
        //Given an unsorted array of integers, find the length of longest continuous increasing subsequence (subarray).

        //Example 1:
        //Input: [1,3,5,4,7]
        //Output: 3
        //Explanation: The longest continuous increasing subsequence is [1,3,5], its length is 3. 
        //Even though [1,3,5,7] is also an increasing subsequence, it's not a continuous one where 5 and 7 are separated by 4. 

        //Example 2:
        //Input: [2,2,2,2,2]
        //Output: 1
        //Explanation: The longest continuous increasing subsequence is [2], its length is 1. 
        public static int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;
            int count = 0, max = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    count++;
                else if (nums[i] <= nums[i - 1])
                {
                    max = Math.Max(max, count + 1);
                    if (i > nums.Length - max)
                        return max;
                    count = 0;
                }
            }
            return Math.Max(max, count + 1);
        }
        #endregion

        #region 680. Valid Palindrome II **逻辑比较复杂
        //Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.

        //Example 1:
        //Input: "aba"
        //Output: True

        //Example 2:
        //Input: "abca"
        //Output: True
        //Explanation: You could delete the character 'c'.

        //Note:
        //  The string will only contain lowercase characters a-z. The maximum length of the string is 50000.
        public static bool ValidPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            bool bDel = false;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    if (bDel)
                        return false;
                    if (j == i + 1)
                        return true;
                    else if (j == i + 2)
                    {
                        if ((s[j] == s[i + 1] || s[i] == s[j - 1]))
                            return true;
                        else return false;
                    }
                    else if (j > i + 2)
                    {
                        if (s[j - 1] == s[i + 2] && s[j] == s[i + 1])
                            i++;
                        else if (s[i] == s[j - 1] && s[j - 2] == s[i + 1])
                            j--;
                        else
                            return false;
                    }
                    bDel = true;
                }
                i++;
                j--;
            }
            return true;
        }
        public static bool ValidPalindrome2(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return IsValidPalindrome(s, i + 1, j) || IsValidPalindrome(s, i, j - 1);
                }
                i++;
                j--;
            }
            return true;
        }

        public static bool IsValidPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
        #endregion

        #region 682. Baseball Game
        //You're now a baseball game point recorder.

        //Given a list of strings, each string can be one of the 4 following types:

        //Integer (one round's score): Directly represents the number of points you get in this round.
        //"+" (one round's score): Represents that the points you get in this round are the sum of the last two valid round's points.
        //"D" (one round's score): Represents that the points you get in this round are the doubled data of the last valid round's points.
        //"C" (an operation, which isn't a round's score): Represents the last valid round's points you get were invalid and should be removed.
        //Each round's operation is permanent and could have an impact on the round before and the round after.

        //You need to return the sum of the points you could get in all the rounds.

        //Example 1:
        //Input: ["5","2","C","D","+"]
        //Output: 30
        //Explanation: 
        //Round 1: You could get 5 points. The sum is: 5.
        //Round 2: You could get 2 points. The sum is: 7.
        //Operation 1: The round 2's data was invalid. The sum is: 5.  
        //Round 3: You could get 10 points (the round 2's data has been removed). The sum is: 15.
        //Round 4: You could get 5 + 10 = 15 points. The sum is: 30.
        //Example 2:
        //Input: ["5","-2","4","C","D","9","+","+"]
        //Output: 27
        //Explanation: 
        //Round 1: You could get 5 points. The sum is: 5.
        //Round 2: You could get -2 points. The sum is: 3.
        //Round 3: You could get 4 points. The sum is: 7.
        //Operation 1: The round 3's data is invalid. The sum is: 3.  
        //Round 4: You could get -4 points (the round 3's data has been removed). The sum is: -1.
        //Round 5: You could get 9 points. The sum is: 8.
        //Round 6: You could get -4 + 9 = 5 points. The sum is 13.
        //Round 7: You could get 9 + 5 = 14 points. The sum is 27.
        //Note:
        //  The size of the input list will be between 1 and 1000.
        //  Every integer represented in the list will be between -30000 and 30000.
        public static int CalPoints(string[] ops)
        {
            int[] res = new int[ops.Length];
            int i = -1;
            foreach (var item in ops)
            {
                if (item == "D") res[++i] = res[i - 1] << 1;

                else if (item == "+") res[++i] = res[i - 1] + res[i - 2];

                else if (item == "C")
                    res[i--] = 0;
                else
                    res[++i] = int.Parse(item);
            }
            return res.Sum();
        }
        #endregion

        #region 686. Repeated String Match *暂时放一边
        //Given two strings A and B, find the minimum number of times A has to be repeated such that B is a substring of it. If no such solution, return -1.

        //For example, with A = "abcd" and B = "cdabcdab".

        //Return 3, because by repeating A three times (“abcdabcdabcd”), B is a substring of it; and B is not a substring of A repeated two times ("abcdabcd").

        //Note:
        //  The length of A and B will be between 1 and 10000.
        public static int RepeatedStringMatch(string A, string B)
        {
            int count = 1;
            StringBuilder sb = new StringBuilder(A);
            while (sb.Length < B.Length)
            {
                sb.Append(A);
                count++;
            }
            if (sb.ToString().Contains(B)) return count;
            if (sb.Append(A).ToString().Contains(B)) return ++count;
            return -1;
        }
        #endregion

        #region 687. Longest Univalue Path  ***
        //Given a binary tree, find the length of the longest path where each node in the path has the same value. This path may or may not pass through the root.

        //Note: The length of path between two nodes is represented by the number of edges between them.

        //Example 1:

        //Input:

        //              5
        //             / \
        //            4   5
        //           / \   \
        //          1   1   5
        //Output:

        //2
        //Example 2:

        //Input:

        //              1
        //             / \
        //            4   5
        //           / \   \
        //          4   4   5
        //Output:

        //2
        //Note: The given binary tree has not more than 10000 nodes. The height of the tree is not more than 1000.
        public static int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;
            int length = 0;
            LongestUnivaluePath(root, root.val, ref length);
            return length;
        }
        public static int LongestUnivaluePath(TreeNode root, int val, ref int length)
        {
            if (root == null) return 0;
            int left = LongestUnivaluePath(root.left, root.val, ref length);
            int right = LongestUnivaluePath(root.right, root.val, ref length);
            length = Math.Max(length, left + right);
            if (val == root.val) return Math.Max(left, right) + 1;
            return 0;
        }
        #endregion

        #region 690. Employee Importance
        //You are given a data structure of employee information, which includes the employee's unique id, 
        //his importance value and his direct subordinates' id.

        //For example, employee 1 is the leader of employee 2, and employee 2 is the leader of employee 3. They have 
        //importance value 15, 10 and 5, respectively. Then employee 1 has a data structure like [1, 15, [2]], and 
        //employee 2 has [2, 10, [3]], and employee 3 has [3, 5, []]. Note that although employee 3 is also a 
        //subordinate of employee 1, the relationship is not direct.

        //Now given the employee information of a company, and an employee id, you need to return the total importance 
        //value of this employee and all his subordinates.

        //Example 1:
        //Input: [[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
        //Output: 11
        //Explanation:
        //Employee 1 has importance value 5, and he has two direct subordinates: employee 2 and employee 3. 
        //They both have importance value 3. So the total importance value of employee 1 is 5 + 3 + 3 = 11.

        //Note:
        //  One employee has at most one direct leader and may have several subordinates.
        //  The maximum number of employees won't exceed 2000.
        public class Employee
        {
            // It's the unique id of each node;
            // unique id of this employee
            public int id = 0;
            // the importance value of this employee
            public int importance = 0;
            // the id of direct subordinates
            public List<int> subordinates = new List<int>();
        }
        public static int GetImportance(List<Employee> employees, int id)
        {
            Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            int sum = 0;
            foreach (var item in employees)
            {
                dic.Add(item.id, item);
            }
            Queue<Employee> q = new Queue<Employee>();
            q.Enqueue(dic[id]);
            while (q.Count != 0)
            {
                Employee e = q.Dequeue();
                sum += e.importance;
                foreach (var item in e.subordinates)
                {
                    q.Enqueue(dic[item]);
                }
            }
            return sum;
        }
        #endregion

        #region 693. Binary Number with Alternating Bits
        //Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.

        //Example 1:
        //Input: 5
        //Output: True
        //Explanation:
        //The binary representation of 5 is: 101

        //Example 2:
        //Input: 7
        //Output: False
        //Explanation:
        //The binary representation of 7 is: 111.

        //Example 3:
        //Input: 11
        //Output: False
        //Explanation:
        //The binary representation of 11 is: 1011.
        //Example 4:

        //Input: 10
        //Output: True
        //Explanation:
        //The binary representation of 10 is: 1010.
        public static bool HasAlternatingBits(int n)
        {
            int pre = n & 1;
            n = n >> 1;
            while (n != 0)
            {
                int t = n & 1;
                n = n >> 1;
                if (t == pre)
                    return false;
                pre = t;
            }
            return true;
        }
        #endregion

        #region 695. Max Area of Island
        //Given a non-empty 2D array grid of 0's and 1's, an island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) 
        //You may assume all four edges of the grid are surrounded by water.

        //Find the maximum area of an island in the given 2D array. (If there is no island, the maximum area is 0.)

        //Example 1:
        //[[0,0,1,0,0,0,0,1,0,0,0,0,0],
        // [0,0,0,0,0,0,0,1,1,1,0,0,0],
        // [0,1,1,0,1,0,0,0,0,0,0,0,0],
        // [0,1,0,0,1,1,0,0,1,0,1,0,0],
        // [0,1,0,0,1,1,0,0,1,1,1,0,0],
        // [0,0,0,0,0,0,0,0,0,0,1,0,0],
        // [0,0,0,0,0,0,0,1,1,1,0,0,0],
        // [0,0,0,0,0,0,0,1,1,0,0,0,0]]
        //Given the above grid, return 6. Note the answer is not 11, because the island must be connected 4-directionally.
        //Example 2:
        //[[0,0,0,0,0,0,0,0]]
        //Given the above grid, return 0.
        //Note: The length of each dimension in the given grid does not exceed 50.
        public static int MaxAreaOfIsland(int[,] grid)
        {
            int res = 0;
            int row = grid.GetLength(0), col = grid.GetLength(1);
            int[,] flag = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (flag[i, j] == 0 && grid[i, j] == 1)
                    {
                        int current = 0;
                        Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
                        q.Enqueue(new KeyValuePair<int, int>(i, j));
                        flag[i, j] = 1;
                        while (q.Count != 0)
                        {
                            KeyValuePair<int, int> kv = q.Dequeue();
                            int x = kv.Key, y = kv.Value;
                            current++;
                            if (x - 1 >= 0 && grid[x - 1, y] == 1 && flag[x - 1, y] == 0)
                            {
                                flag[x - 1, y] = 1;
                                q.Enqueue(new KeyValuePair<int, int>(x - 1, y));
                            }
                            if (x + 1 < row && grid[x + 1, y] == 1 && flag[x + 1, y] == 0)
                            {
                                flag[x + 1, y] = 1;
                                q.Enqueue(new KeyValuePair<int, int>(x + 1, y));
                            }
                            if (y - 1 >= 0 && grid[x, y - 1] == 1 && flag[x, y - 1] == 0)
                            {
                                flag[x, y - 1] = 1;
                                q.Enqueue(new KeyValuePair<int, int>(x, y - 1));
                            }
                            if (y + 1 < col && grid[x, y + 1] == 1 && flag[x, y + 1] == 0)
                            {
                                flag[x, y + 1] = 1;
                                q.Enqueue(new KeyValuePair<int, int>(x, y + 1));
                            }
                        }
                        res = Math.Max(current, res);
                    }
                }
            }
            return res;
        }
        #endregion

        #region 696. Count Binary Substrings
        //Give a string s, count the number of non-empty (contiguous) substrings that have the same number of 0's and 1's, 
        //and all the 0's and all the 1's in these substrings are grouped consecutively.

        //Substrings that occur multiple times are counted the number of times they occur.

        //Example 1:
        //Input: "00110011"
        //Output: 6
        //Explanation: There are 6 substrings that have equal number of consecutive 1's and 0's: "0011", "01", "1100", "10", "0011", and "01".

        //Notice that some of these substrings repeat and are counted the number of times they occur.

        //Also, "00110011" is not a valid substring because all the 0's (and 1's) are not grouped together.

        //Example 2:
        //Input: "10101"
        //Output: 4
        //Explanation: There are 4 substrings: "10", "01", "10", "01" that have equal number of consecutive 1's and 0's.

        //Note:
        //  s.length will be between 1 and 50,000.
        //  s will only consist of "0" or "1" characters.
        public static int CountBinarySubstrings(string s)
        {
            if (s.Length <= 1)
                return 0;
            int pre = 0, current = 0, res = 0;
            char flag = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == flag)
                {
                    current++;
                }
                else
                {
                    res += Math.Min(current, pre);
                    pre = current;
                    current = 1;
                    flag = s[i];
                }
            }
            return res + Math.Min(pre, current);
        }

        #endregion

        #region 697. Degree of an Array
        //Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.

        //Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.

        //Example 1:
        //Input: [1, 2, 2, 3, 1]
        //Output: 2
        //Explanation: 
        //The input array has a degree of 2 because both elements 1 and 2 appear twice.
        //Of the subarrays that have the same degree:
        //[1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
        //The shortest length is 2. So return 2.
        //Example 2:
        //Input: [1,2,2,3,1,4,2]
        //Output: 6
        //Note:

        //  nums.length will be between 1 and 50,000.
        //  nums[i] will be an integer between 0 and 49,999.
        public static int FindShortestSubArray(int[] nums)
        {
            int[] count = new int[50000];
            List<int> list = new List<int>();
            int max = 0;
            foreach (var item in nums)
            {
                count[item]++;
                if (count[item] == max)
                {
                    list.Add(item);
                }
                else if (count[item] > max)
                {
                    list.Clear();
                    list.Add(item);
                    max = count[item];
                }
            }
            if (max == 1)
                return 1;
            int res = int.MaxValue;
            foreach (var item in list)
            {
                int i = 0, j = nums.Length - 1;
                while (nums[i] != item)
                    i++;
                while (nums[j] != item)
                    j--;
                res = Math.Min(res, j - i + 1);
            }
            return res;
        }
        #endregion

        #region 717. 1-bit and 2-bit Characters
        //We have two special characters. The first character can be represented by one bit 0. The second character can be represented by two bits (10 or 11).

        //Now given a string represented by several bits. Return whether the last character must be a one-bit character or not. The given string will always end with a zero.

        //Example 1:
        //Input: 
        //bits = [1, 0, 0]
        //Output: True
        //Explanation: 
        //The only way to decode it is two-bit character and one-bit character. So the last character is one-bit character.
        //Example 2:
        //Input: 
        //bits = [1, 1, 1, 0]
        //Output: False
        //Explanation: 
        //The only way to decode it is two-bit character and two-bit character. So the last character is NOT one-bit character.
        //Note:

        //1 <= len(bits) <= 1000.
        //bits[i] is always 0 or 1.
        public static bool IsOneBitCharacter(int[] bits)
        {
            if (bits[bits.Length - 1] == 1)
                return false;
            if (bits.Length == 1)
                return bits[0] == 0;
            for (int i = 0; i < bits.Length;)
            {
                if (bits[i] == 1)
                    i += 2;
                else if (i == bits.Length - 1)
                    return true;
                else
                    i++;
            }
            return false;
        }
        #endregion

        #region 720. Longest Word in Dictionary ***
        //Given a list of strings words representing an English Dictionary, find the longest word in words that can be built
        //one character at a time by other words in words. If there is more than one possible answer, return the longest word with the smallest lexicographical order.

        //If there is no answer, return the empty string.
        //Example 1:
        //Input: 
        //words = ["w","wo","wor","worl", "world"]
        //Output: "world"
        //Explanation: 
        //The word "world" can be built one character at a time by "w", "wo", "wor", and "worl".
        //Example 2:
        //Input: 
        //words = ["a", "banana", "app", "appl", "ap", "apply", "apple"]
        //Output: "apple"
        //Explanation: 
        //Both "apply" and "apple" can be built from other words in the dictionary. However, "apple" is lexicographically smaller than "apply".

        //Note:
        //  All the strings in the input will only contain lowercase letters.
        //  The length of words will be in the range [1, 1000].
        //  The length of words[i] will be in the range [1, 30].
        public static string LongestWord(string[] words)
        {
            Array.Sort(words);
            HashSet<string> set = new HashSet<string>();
            string res = "";
            foreach (var word in words)
            {
                if (word.Length == 1 || set.Contains(word.Substring(0, word.Length - 1)))
                {
                    res = word.Length > res.Length ? word : res;
                    set.Add(word);
                }
            }
            return res;
        }
        #endregion

        #region 724. Find Pivot Index
        //Given an array of integers nums, write a method that returns the "pivot" index of this array.

        //We define the pivot index as the index where the sum of the numbers to the left of the index is equal to the sum of the numbers to the right of the index.

        //If no such index exists, we should return -1. If there are multiple pivot indexes, you should return the left-most pivot index.

        //Example 1:
        //Input: 
        //nums = [1, 7, 3, 6, 5, 6]
        //Output: 3
        //Explanation: 
        //The sum of the numbers to the left of index 3 (nums[3] = 6) is equal to the sum of numbers to the right of index 3.
        //Also, 3 is the first index where this occurs.
        //Example 2:
        //Input: 
        //nums = [1, 2, 3]
        //Output: -1
        //Explanation: 
        //There is no index that satisfies the conditions in the problem statement.
        //Note:

        //The length of nums will be in the range [0, 10000].
        //Each element nums[i] will be an integer in the range [-1000, 1000].
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length == 0)
                return -1;
            int[] sums = new int[nums.Length];
            sums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
                sums[i] = sums[i - 1] + nums[i];

            int preSum = 0;
            for (int i = 0; i < sums.Length; i++)
            {
                if (preSum == sums.Last() - sums[i])
                    return i;
                preSum = sums[i];
            }
            return -1;
        }
        #endregion

        #region 728. Self Dividing Numbers
        //A self-dividing number is a number that is divisible by every digit it contains.

        //For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.

        //Also, a self-dividing number is not allowed to contain the digit zero.

        //Given a lower and upper number bound, output a list of every possible self dividing number, including the bounds if possible.

        //Example 1:
        //Input: 
        //left = 1, right = 22
        //Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22]
        //Note:

        //The boundaries of each input argument are 1 <= left <= right <= 10000.
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (i < 10)
                    list.Add(i);
                else
                {
                    int tmp = i;
                    bool b = true;
                    while (tmp != 0)
                    {
                        int r = tmp % 10;
                        if (r == 0 || i % r != 0)
                        {
                            b = false;
                            break;
                        }
                        tmp /= 10;
                    }
                    if (b)
                        list.Add(i);
                }
            }
            return list;
        }

        #endregion

        #region 733. Flood Fill
        //An image is represented by a 2-D array of integers, each integer representing the pixel value of the image (from 0 to 65535).

        //Given a coordinate (sr, sc) representing the starting pixel (row and column) of the flood fill, and a pixel value newColor, "flood fill" the image.

        //To perform a "flood fill", consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the 
        //starting pixel, plus any pixels connected 4-directionally to those pixels (also with the same color as the starting pixel), and so on. Replace 
        //the color of all of the aforementioned pixels with the newColor.

        //At the end, return the modified image.

        //Example 1:
        //Input: 
        //image = [[1,1,1],[1,1,0],[1,0,1]]
        //sr = 1, sc = 1, newColor = 2
        //Output: [[2,2,2],[2,2,0],[2,0,1]]
        //Explanation: 
        //From the center of the image (with position (sr, sc) = (1, 1)), all pixels connected 
        //by a path of the same color as the starting pixel are colored with the new color.
        //Note the bottom corner is not colored 2, because it is not 4-directionally connected
        //to the starting pixel.
        //Note:

        //The length of image and image[0] will be in the range [1, 50].
        //The given starting pixel will satisfy 0 <= sr < image.length and 0 <= sc < image[0].length.
        //The value of each color in image[i][j] and newColor will be an integer in [0, 65535].
        public static int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            int oldColor = image[sr, sc];
            int row = image.GetLength(0), col = image.GetLength(1);
            int[,] flag = new int[row, col];
            Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
            q.Enqueue(new KeyValuePair<int, int>(sr, sc));
            flag[sr, sc] = 1;
            while (q.Count != 0)
            {
                KeyValuePair<int, int> kv = q.Dequeue();
                int x = kv.Key, y = kv.Value;
                image[x, y] = newColor;
                if (x - 1 >= 0 && flag[x - 1, y] == 0 && image[x - 1, y] == oldColor)
                {
                    q.Enqueue(new KeyValuePair<int, int>(x - 1, y));
                    flag[x - 1, y] = 1;
                }
                if (x + 1 < row && flag[x + 1, y] == 0 && image[x + 1, y] == oldColor)
                {
                    q.Enqueue(new KeyValuePair<int, int>(x + 1, y));
                    flag[x + 1, y] = 1;
                }
                if (y - 1 >= 0 && flag[x, y - 1] == 0 && image[x, y - 1] == oldColor)
                {
                    q.Enqueue(new KeyValuePair<int, int>(x, y - 1));
                    flag[x, y - 1] = 1;
                }
                if (y + 1 < col && flag[x, y + 1] == 0 && image[x, y + 1] == oldColor)
                {
                    q.Enqueue(new KeyValuePair<int, int>(x, y + 1));
                    flag[x, y + 1] = 1;
                }
            }
            return image;
        }
        #endregion

        #region 744. Find Smallest Letter Greater Than Target
        //Given a list of sorted characters letters containing only lowercase letters, and given a target letter 
        //target, find the smallest element in the list that is larger than the given target.

        //Letters also wrap around. For example, if the target is target = 'z' and letters = ['a', 'b'], the answer is 'a'.

        //Examples:
        //Input:
        //letters = ["c", "f", "j"]
        //target = "a"
        //Output: "c"

        //Input:
        //letters = ["c", "f", "j"]
        //target = "c"
        //Output: "f"

        //Input:
        //letters = ["c", "f", "j"]
        //target = "d"
        //Output: "f"

        //Input:
        //letters = ["c", "f", "j"]
        //target = "g"
        //Output: "j"

        //Input:
        //letters = ["c", "f", "j"]
        //target = "j"
        //Output: "c"

        //Input:
        //letters = ["c", "f", "j"]
        //target = "k"
        //Output: "c"
        //Note:
        //letters has a length in range [2, 10000].
        //letters consists of lowercase letters, and contains at least 2 unique letters.
        //target is a lowercase letter.
        public static char NextGreatestLetter(char[] letters, char target)
        {
            if (letters.Last() - target <= 0)
                return letters.First();
            int i = 0, j = letters.Length - 1;
            while (i < j)
            {
                int mid = i + (j - i) / 2;
                if (letters[mid] <= target)
                    i = mid + 1;
                else
                    j = mid;
            }
            return letters[j];
        }
        #endregion

        #region 746. Min Cost Climbing Stairs
        //On a staircase, the i-th step has some non-negative cost cost[i] assigned (0 indexed).

        //Once you pay the cost, you can either climb one or two steps. You need to find minimum cost to 
        //reach the top of the floor, and you can either start from the step with index 0, or the step with index 1.

        //Example 1:
        //Input: cost = [10, 15, 20]
        //Output: 15
        //Explanation: Cheapest is start on cost[1], pay that cost and go to the top.
        //Example 2:
        //Input: cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1]
        //Output: 6
        //Explanation: Cheapest is start on cost[0], and only step on 1s, skipping cost[3].
        //Note:
        //cost will have a length in the range [2, 1000].
        //Every cost[i] will be an integer in the range [0, 999].
        public static int MinCostClimbingStairs(int[] cost)
        {
            int[] arr = new int[cost.Length];
            arr[0] = cost[0];
            arr[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                arr[i] = Math.Min(arr[i - 1] + cost[i], arr[i - 2] + cost[i]);
            }
            return Math.Min(arr[arr.Length - 2], arr.Last());
        }
        #endregion

        #region 747. Largest Number At Least Twice of Others
        //In a given integer array nums, there is always exactly one largest element.

        //Find whether the largest element in the array is at least twice as much as every other number in the array.

        //If it is, return the index of the largest element, otherwise return -1.

        //Example 1:

        //Input: nums = [3, 6, 1, 0]
        //Output: 1
        //Explanation: 6 is the largest integer, and for every other number in the array x,
        //6 is more than twice as big as x.  The index of value 6 is 1, so we return 1.


        //Example 2:

        //Input: nums = [1, 2, 3, 4]
        //Output: -1
        //Explanation: 4 isn't at least as big as twice the value of 3, so we return -1.
        //Note:

        //nums will have a length in the range [1, 50].
        //Every nums[i] will be an integer in the range [0, 99].
        public static int DominantIndex(int[] nums)
        {
            if (nums.Length == 1)
                return 0;
            int first = nums[0], second = -1, index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > first)
                {
                    second = first;
                    first = nums[i];
                    index = i;
                }
                else if (nums[i] > second)
                {
                    second = nums[i];
                }
            }
            if (first > second * 2)
                return index;
            else
                return -1;
        }
        #endregion

        #region 762. Prime Number of Set Bits in Binary Representation **不会，二进制
        //Given two integers L and R, find the count of numbers in the range [L, R] (inclusive) having a prime number of set bits in their binary representation.

        //(Recall that the number of set bits an integer has is the number of 1s present when written in binary. For example, 21 written in binary is 10101 which has 3 set bits. Also, 1 is not a prime.)

        //Example 1:

        //Input: L = 6, R = 10
        //Output: 4
        //Explanation:
        //6 -> 110 (2 set bits, 2 is prime)
        //7 -> 111 (3 set bits, 3 is prime)
        //9 -> 1001 (2 set bits , 2 is prime)
        //10->1010 (2 set bits , 2 is prime)
        //Example 2:

        //Input: L = 10, R = 15
        //Output: 5
        //Explanation:
        //10 -> 1010 (2 set bits, 2 is prime)
        //11 -> 1011 (3 set bits, 3 is prime)
        //12 -> 1100 (2 set bits, 2 is prime)
        //13 -> 1101 (3 set bits, 3 is prime)
        //14 -> 1110 (3 set bits, 3 is prime)
        //15 -> 1111 (4 set bits, 4 is not prime)
        //Note:

        //L, R will be integers L <= R in the range [1, 10^6].
        //R - L will be at most 10000.
        public static int CountPrimeSetBits(int L, int R)
        {
            return 0;
        }

        public static int CountPrimeSetBitsNumber(int n)
        {
            HashSet<int> hs = new HashSet<int> {2,3,5,7,11,13,17,19 };
            int numBitsRight =(int)(Math.Log(n) / Math.Log(2));
            int b = 1 << numBitsRight, numOnesLeft = 0, ans = 0;
            while (b > 0)
            {
                if ((n & b) != 0)
                {
                    int nChoosek = 1;
                    for (int i = 0; i <= numBitsRight; i++)
                    {
                        //if()
                    }
                }
            }
            return 0;
        }
        #endregion

        #region 766. Toeplitz Matrix
        //A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same element.

        //Now given an M x N matrix, return True if and only if the matrix is Toeplitz.

        //Example 1:

        //Input: matrix = [[1,2,3,4],[5,1,2,3],[9,5,1,2]]
        //Output: True
        //Explanation:
        //1234
        //5123
        //9512

        //In the above grid, the diagonals are "[9]", "[5, 5]", "[1, 1, 1]", "[2, 2, 2]", "[3, 3]", "[4]", and in each diagonal all elements are the same, so the answer is True.
        //Example 2:

        //Input: matrix = [[1,2],[2,2]]
        //Output: False
        //Explanation:
        //The diagonal "[1, 2]" has different elements.
        //Note:

        //matrix will be a 2D array of integers.
        //matrix will have a number of rows and columns in range [1, 20].
        //matrix[i][j] will be integers in range [0, 99].
        public static bool IsToeplitzMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0), col = matrix.GetLength(1);
            for (int i = 0; i < row - 1; i++)
                for (int j = 0; j < col - 1; j++)
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                        return false;
            return true;
        }
        #endregion

        #region 771. Jewels and Stones
        //You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  
        //Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

        //The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is 
        //considered a different type of stone from "A".

        //Example 1:

        //Input: J = "aA", S = "aAAbbbb"
        //Output: 3
        //Example 2:

        //Input: J = "z", S = "ZZ"
        //Output: 0
        //Note:

        //S and J will consist of letters and have length at most 50.
        //The characters in J are distinct.
        public static int NumJewelsInStones(string J, string S)
        {
            int[] arr = new int[128];
            foreach (var item in J)
                arr[item] = 1;

            int sum = 0;
            foreach (var item in S)
                if (arr[item] != 0)
                    sum++;
            return sum;
        }
        #endregion

        #region 783. Minimum Distance Between BST Nodes ***
        //Given a Binary Search Tree (BST) with the root node root, return the minimum difference between the values of any two different nodes in the tree.

        //Example :

        //Input: root = [4,2,6,1,3,null,null]
        //Output: 1
        //Explanation:
        //Note that root is a TreeNode object, not an array.

        //The given tree [4,2,6,1,3,null,null] is represented by the following diagram:

        //          4
        //        /   \
        //      2      6
        //     / \    
        //    1   3  

        //while the minimum difference in this tree is 1, it occurs between node 1 and node 2, also between node 3 and node 2.
        //Note:

        //The size of the BST will be between 2 and 100.
        //The BST is always valid, each node's value is an integer, and each node's value is different.
        public static int MinDiffInBST(TreeNode root)
        {
            int[] res = { int.MaxValue };
            MinDiffInBST(root, res);
            return res[0];
        }
        public static void MinDiffInBST(TreeNode root, int[] res)
        {
            if (root.left != null)
            {
                res[0] = Math.Min(root.val - root.left.val, res[0]);
                MinDiffInBST(root.left, res);
            }
            if (root.right != null)
            {
                res[0] = Math.Min(root.right.val - root.val, res[0]);
                MinDiffInBST(root.right, res);
            }
        }
        public static void MinDiffInBST(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            MinDiffInBST(root.left, list);
            MinDiffInBST(root.right, list);
        }
        #endregion

        #region 784. Letter Case Permutation
        //Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.  Return a list of all possible strings we could create.

        //Examples:
        //Input: S = "a1b2"
        //Output: ["a1b2", "a1B2", "A1b2", "A1B2"]

        //Input: S = "3z4"
        //Output: ["3z4", "3Z4"]

        //Input: S = "12345"
        //Output: ["12345"]
        //Note:

        //S will be a string with length at most 12.
        //S will consist only of letters or digits.
        public static IList<string> LetterCasePermutation(string S)
        {
            List<string> list = new List<string>(100);
            LetterCasePermutation(S, 0, list, "");
            return list;
        }

        public static void LetterCasePermutation(string s, int i, List<string> list, string t)
        {
            if (i < s.Length)
            {
                if (char.IsDigit(s[i]))
                    LetterCasePermutation(s, i + 1, list, t + s[i]);
                else
                {
                    LetterCasePermutation(s, i + 1, list, t + char.ToUpper(s[i]));
                    LetterCasePermutation(s, i + 1, list, t + char.ToLower(s[i]));
                }
            }
            else if (i == s.Length)
                list.Add(t);
        }
        #endregion

        #region 788. Rotated Digits 不会
        //X is a good number if after rotating each digit individually by 180 degrees, we get a valid number
        //that is different from X.  Each digit must be rotated - we cannot choose to leave it alone.

        //A number is valid if each digit remains a digit after rotation. 0, 1, and 8 rotate to themselves; 
        //2 and 5 rotate to each other; 6 and 9 rotate to each other, and the rest of the numbers do not 
        //rotate to any other number and become invalid.

        //Now given a positive number N, how many numbers X from 1 to N are good?

        //Example:
        //Input: 10
        //Output: 4
        //Explanation: 
        //There are four good numbers in the range [1, 10] : 2, 5, 6, 9.
        //Note that 1 and 10 are not good numbers, since they remain unchanged after rotating.
        //Note:

        //N  will be in range [1, 10000].
        public int RotatedDigits(int N)
        {
            return 0;
        }

        #endregion

        #region 796. Rotate String

        //We are given two strings, A and B.

        //A shift on A consists of taking string A and moving the leftmost character to the rightmost position. For example, if A = 'abcde', then it will be 'bcdea' after one shift on A. Return True if and only if A can become B after some number of shifts on A.

        //Example 1:
        //Input: A = 'abcde', B = 'cdeab'
        //Output: true

        //Example 2:
        //Input: A = 'abcde', B = 'abced'
        //Output: false
        //Note:

        //A and B will have length at most 100.
        public static bool RotateString(string A, string B)
        {
            return false;
        }
        #endregion

        #region 804. Unique Morse Code Words
        //International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

        //For convenience, the full table for the 26 letters of the English alphabet is given below:

        //[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        //Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.
        // For example, "cab" can be written as "-.-.-....-", (which is the concatenation "-.-." + "-..." + ".-"). We'll call such a concatenation, the transformation of a word.

        //Return the number of different transformations among all words we have.

        //Example:
        //Input: words = ["gin", "zen", "gig", "msg"]
        //Output: 2
        //Explanation: 
        //The transformation of each word is:
        //"gin" -> "--...-."
        //"zen" -> "--...-."
        //"gig" -> "--...--."
        //"msg" -> "--...--."

        //There are 2 different transformations, "--...-." and "--...--.".


        //Note:

        //The length of words will be at most 100.
        //Each words[i] will have length in range [1, 12].
        //words[i] will only consist of lowercase letters.
        public static int UniqueMorseRepresentations(string[] words)
        {
            string[] strs = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            HashSet<string> hs = new HashSet<string>();
            foreach (var item in words)
            {
                string s = "";
                foreach (var c in item)
                {
                    s += strs[c - 'a'];
                }
                hs.Add(s);
            }
            return hs.Count;
        }

        #endregion

        #region 806. Number of Lines To Write String
        //We are to write the letters of a given string S, from left to right into lines. Each line has maximum 
        //width 100 units, and if writing a letter would cause the width of the line to exceed 100 units, it is 
        //written on the next line. We are given an array widths, an array where widths[0] is the width of 'a', 
        //widths[1] is the width of 'b', ..., and widths[25] is the width of 'z'.

        //Now answer two questions: how many lines have at least one character from S, and what is the width used 
        //by the last such line? Return your answer as an integer list of length 2.

        //Example :
        //Input: 
        //widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
        //S = "abcdefghijklmnopqrstuvwxyz"
        //Output: [3, 60]
        //Explanation: 
        //All letters have the same length of 10. To write all 26 letters,
        //we need two full lines and one line with 60 units.
        //Example :
        //Input: 
        //widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
        //S = "bbbcccdddaaa"
        //Output: [2, 4]
        //Explanation: 
        //All letters except 'a' have the same length of 10, and 
        //"bbbcccdddaa" will cover 9 * 10 + 2 * 4 = 98 units.
        //For the last 'a', it is written on the second line because
        //there is only 2 units left in the first line.
        //So the answer is 2 lines, plus 4 units in the second line.

        //Note:

        //The length of S will be in the range [1, 1000].
        //S will only contain lowercase letters.
        //widths is an array of length 26.
        //widths[i] will be in the range of [2, 10].
        public static int[] NumberOfLines(int[] widths, string S)
        {
            int[] res = new int[2];
            foreach (var c in S)
            {
                res[1] += widths[c - 'a'];
                if (res[1] > 100)
                {
                    res[1] = widths[c - 'a'];
                    res[0]++;
                }
                else if (res[1] == 100)
                {
                    res[1] = 0;
                    res[0]++;
                }
            }
            if (res[1] != 0)
                res[0]++;
            return res;
        }

        #endregion

        #region 811. Subdomain Visit Count
        //A website domain like "discuss.leetcode.com" consists of various subdomains. At the top level, we have "com", 
        //at the next level, we have "leetcode.com", and at the lowest level, "discuss.leetcode.com". When we visit a 
        //domain like "discuss.leetcode.com", we will also visit the parent domains "leetcode.com" and "com" implicitly.

        //Now, call a "count-paired domain" to be a count (representing the number of visits this domain received), 
        //followed by a space, followed by the address. An example of a count-paired domain might be "9001 discuss.leetcode.com".

        //We are given a list cpdomains of count-paired domains. We would like a list of count-paired domains, (in the 
        //same format as the input, and in any order), that explicitly counts the number of visits to each subdomain.

        //Example 1:
        //Input: 
        //["9001 discuss.leetcode.com"]
        //Output: 
        //["9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"]
        //Explanation: 
        //We only have one website domain: "discuss.leetcode.com". As discussed above, the subdomain "leetcode.com" and "com" will also be visited. So they will all be visited 9001 times.

        //Example 2:
        //Input: 
        //["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"]
        //Output: 
        //["901 mail.com","50 yahoo.com","900 google.mail.com","5 wiki.org","5 org","1 intel.mail.com","951 com"]
        //Explanation: 
        //We will visit "google.mail.com" 900 times, "yahoo.com" 50 times, "intel.mail.com" once and "wiki.org" 5 times. For the subdomains, we will visit "mail.com" 900 + 1 = 901 times, "com" 900 + 50 + 1 = 951 times, and "org" 5 times.

        //Notes:

        //The length of cpdomains will not exceed 100. 
        //The length of each domain name will not exceed 100.
        //Each address will have either 1 or 2 "." characters.
        //The input count in any count-paired domain will not exceed 10000.
        //The answer output can be returned in any order.
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> list = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            char[] flag = new char[] { ' ' };
            foreach (var item in cpdomains)
            {
                string[] strs = item.Split(flag);
                int n = int.Parse(strs[0]);
                if (dic.ContainsKey(strs[1]))
                    dic[strs[1]] += n;
                else
                    dic.Add(strs[1], n);
                int index = strs[1].IndexOf('.');
                while (index != -1)
                {
                    strs[1] = strs[1].Substring(index + 1);
                    if (dic.ContainsKey(strs[1]))
                        dic[strs[1]] += n;
                    else
                        dic.Add(strs[1], n);
                    index = strs[1].IndexOf('.');
                }
            }
            foreach (KeyValuePair<string, int> kv in dic)
            {
                list.Add(kv.Value + " " + kv.Key);
            }
            return list;
        }

        #endregion

        #region 812. Largest Triangle Area 新
        //You have a list of points in the plane. Return the area of the largest triangle that can be formed by any 3 of the points.

        //Example:
        //Input: points = [[0,0],[0,1],[1,0],[0,2],[2,0]]
        //Output: 2
        //Explanation: 
        //The five points are show in the figure below. The red triangle is the largest.
        //Notes:

        //3 <= points.length <= 50.
        //No points will be duplicated.
        // -50 <= points[i][j] <= 50.
        //Answers within 10^-6 of the true value will be accepted as correct.
        public static double LargestTriangleArea(int[][] points)
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
    }

}
