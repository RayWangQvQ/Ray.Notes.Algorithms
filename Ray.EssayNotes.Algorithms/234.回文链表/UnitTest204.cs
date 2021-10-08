using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    // https://leetcode-cn.com/problems/palindrome-linked-list/

    public class UnitTest204
    {
        [Fact]
        public void Test1()
        {
            ListNode head = new ListNode(new List<int> { 1, 1, 2, 1 });

            var re = new Solution().IsPalindrome(head);

            Debug.WriteLine(re.ToString());
        }







        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                ListNode fir = null;
                ListNode next = head;

                if (next == null || next.next == null) return true;

                while (next != null)
                {
                    ListNode temp = next.next;
                    if (temp == null) return false;

                    if (fir != null && fir.val == temp.val)
                    {
                        if (IsPalindrome(fir, temp)) return true;
                    }

                    next.next = fir;

                    if (next.val == temp.val)
                    {
                        if (IsPalindrome(next, temp)) return true;
                    }

                    fir = next;
                    next = temp;
                }

                return false;
            }

            private bool IsPalindrome(ListNode a, ListNode b)
            {
                while (a != null)
                {
                    if (b == null) return false;
                    if (a.val != b.val) return false;

                    a = a.next;
                    b = b.next;
                }

                if (b != null) return false;
                return true;
            }
        }
    }
}
