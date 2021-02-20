using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest21
    {
        [Fact]
        public void Test1()
        {

        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode newHead = new ListNode(-1, null);
            ListNode result = newHead;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    var temp = l1.next;
                    newHead.next = l1;
                    l1.next = null;
                    l1 = temp;
                }
                else
                {
                    var temp = l2.next;
                    newHead.next = l2;
                    l2.next = null;
                    l2 = temp;
                }

                newHead = newHead.next;
            }

            newHead.next = l1 ?? l2;

            return result.next;
        }
    }
}
