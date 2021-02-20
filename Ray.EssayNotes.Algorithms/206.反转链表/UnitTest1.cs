using System;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest206

    {
        [Fact]
        public void Test1()
        {

        }

        /// <summary>
        /// 反转链表（递归）
        /// </summary>
        /// <param name="head"></param>
        /// <returns>返回头结点</returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;

            //1.反转当前结点之后的所有结点
            var last = ReverseList(head.next);

            //2.将当前结点调整到最后
            head.next.next = head;
            head.next = null;

            return last;
        }

        /// <summary>
        /// 反转链表（双指针迭代）
        /// </summary>
        /// <param name="head"></param>
        /// <returns>返回头结点</returns>
        public ListNode ReverseList2(ListNode head)
        {
            ListNode pre = null, current = head;
            while (current != null)
            {
                ListNode temp = current.next;//这儿其实还需要第3个指针，用来暂时缓存
                current.next = pre;
                pre = current;
                current = temp;
            }
            return pre;
        }
    }
}
