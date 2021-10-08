using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    // https://leetcode-cn.com/problems/remove-linked-list-elements/

    public class UnitTest203
    {
        [Fact]
        public void Test1()
        {
            ListNode head = new ListNode(new List<int> { 1, 2, 3, 4, 5 });

            var re = new Solution().RemoveElements(head, 1);

            Debug.WriteLine(re.ToString());
        }







        public class Solution
        {
            public ListNode RemoveElements(ListNode head, int val)
            {
                //新增一个新的头
                ListNode newHead = new ListNode();
                newHead.next = head;

                ListNode cur = newHead;
                while (cur.next != null)
                {
                    if (cur.next.val == val)
                    {
                        cur.next = cur.next.next;
                    }
                    else
                    {
                        cur = cur.next;
                    }
                }

                return newHead.next;
            }
        }
    }
}
