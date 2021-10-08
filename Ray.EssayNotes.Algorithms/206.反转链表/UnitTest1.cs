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
        /// ��ת�����ݹ飩
        /// </summary>
        /// <param name="head"></param>
        /// <returns>����ͷ���</returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;

            //1.��ת��ǰ���֮������н��
            var last = ReverseList(head.next);

            //2.����ǰ�����������
            head.next.next = head;
            head.next = null;

            return last;
        }

        /// <summary>
        /// ��ת����˫ָ�������
        /// </summary>
        /// <param name="head"></param>
        /// <returns>����ͷ���</returns>
        public ListNode ReverseList2(ListNode head)
        {
            ListNode fir = null, next = head;//nextָ��Ҫ��ͷ��ʼ����Ҫ�ӵڶ�����ʼ
            while (next != null)
            {
                ListNode temp = next.next;//�����ʵ����Ҫ��3��ָ�룬������ʱ����
                next.next = fir;
                fir = next;
                next = temp;
            }
            return fir;
        }
    }
}
