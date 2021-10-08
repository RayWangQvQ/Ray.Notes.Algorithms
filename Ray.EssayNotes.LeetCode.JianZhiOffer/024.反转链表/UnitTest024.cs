using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    //https://leetcode-cn.com/problems/UHnkqh/

    public class UnitTest024
    {
        [Fact]
        public void Test1()
        {
            //与206相同
        }


        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                ListNode fir = null;
                ListNode next = head;
                while (next != null)
                {
                    ListNode temp = next.next;//临时缓存
                    next.next = fir;

                    fir = next;
                    next = temp;
                }
                return fir;
            }
        }

        public class Solution2
        {
            public ListNode ReverseList(ListNode head)
            {
                if (head == null || head.next == null) return head;

                var next = ReverseList(head.next);

                head.next.next = head;
                head.next = null;

                return next;
            }
        }
    }
}
