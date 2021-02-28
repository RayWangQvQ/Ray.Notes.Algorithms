using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest9
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class CQueue
    {
        private Stack<int> _insert;
        private Stack<int> _delete;

        public CQueue()
        {
            //思路：一个用来插入，一个用来删除
            _insert = new Stack<int>();
            _delete = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            _insert.Push(value);
        }

        public int DeleteHead()
        {
            int head = 0;

            //如果有，则直接出栈，如果没有，则将_insert栈都转到_delete栈，再出栈
            if (_delete.Count > 0)
            {
                head = _delete.Peek();
                _delete.Pop();
            }
            else if (_insert.Count == 0)
            {
                return -1;
            }
            else
            {
                InsertToDelete();
                return DeleteHead();
            }

            return head;
        }

        private void InsertToDelete()
        {
            while (_insert.Count > 0)
            {
                _delete.Push(_insert.Pop());
            }
        }
    }
}
