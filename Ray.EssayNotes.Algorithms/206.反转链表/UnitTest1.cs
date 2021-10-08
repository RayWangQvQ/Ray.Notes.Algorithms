using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    //https://leetcode-cn.com/problems/reverse-linked-list/

    public class UnitTest206
    {
        [Fact]
        public void Test1()
        {
            ListNode head = new ListNode(new List<int> { 1, 2, 3, 4, 5 });

            var re = ReverseList(head);

            Debug.WriteLine(re.ToString());
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
            ListNode fir = null, next = head;//next指针要从头开始，不要从第二个开始
            while (next != null)
            {
                ListNode temp = next.next;//这儿其实还需要第3个指针，用来暂时缓存
                next.next = fir;
                fir = next;
                next = temp;
            }
            return fir;
        }
    }
}
