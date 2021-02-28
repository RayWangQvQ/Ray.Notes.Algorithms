using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest6
    {
        [Fact]
        public void Test1()
        {

        }

        public int[] ReversePrint(ListNode head)
        {
            //思路:循环链表，添加到栈中，然后转换为数组返回

            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            return stack.ToArray();
        }
    }
}
