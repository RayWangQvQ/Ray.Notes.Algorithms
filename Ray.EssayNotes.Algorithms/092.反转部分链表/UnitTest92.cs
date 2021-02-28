using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest92
    {
        [Fact]
        public void Test1()
        {
            //ListNode ln = new ListNode(new List<int> { 1, 2, 3, 4, 5 });
            ListNode ln = new ListNode(new List<int> { 3, 5 });

            var result = ReverseBetween(ln, 1, 2);

            Debug.WriteLine(result);
        }

        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n) return head;
            int index = 1;
            ListNode pre = null, current = head;

            ListNode nodeM = null;//开始反转节点的前一个节点
            ListNode nodePreM = null;//开始反转节点的前一个节点

            while (current != null)
            {
                var temp = current.next;

                if (index == m)
                {
                    nodePreM = pre;
                    nodeM = current;
                }

                //需要反转
                if (index > m && index <= n)
                {
                    current.next = pre;
                }

                if (index > n) break;

                pre = current;
                current = temp;

                index++;
            }

            if (nodePreM != null)
                nodePreM.next = pre;
            nodeM.next = current;

            if (m == 1) return pre;
            return head;
        }
    }
}
