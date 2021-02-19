using System;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        /// <summary>
        /// 反转所给链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns>返回头结点</returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            //1.反转当前结点之后的所有结点
            var last = ReverseList(head.next);

            //2.将当前结点调整到最后
            head.next.next = head;
            head.next = null;

            return last;
        }
    }
}
