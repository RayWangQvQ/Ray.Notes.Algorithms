using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.EssayNotes.Algorithms
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(List<int> list)
        {
            this.val = list[0];
            list.RemoveAt(0);
            this.next = list.Count == 0
                ? null
                : new ListNode(list);
        }

        public override string ToString()
        {
            var ln = this;
            List<int> list = new List<int> { ln.val };

            while (ln.next != null)
            {
                list.Add(ln.next.val);
                ln = ln.next;
            }

            return string.Join(',', list);
        }
    }
}
