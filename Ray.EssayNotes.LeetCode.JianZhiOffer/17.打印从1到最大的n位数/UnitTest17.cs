using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest17
    {
        [Fact]
        public void Test1()
        {

        }

        public class Solution
        {
            public int[] PrintNumbers(int n)
            {
                return Do(n);
            }

            public int[] Do(int n)
            {
                //˼·���ȼ��������������Ȼ�����
                int max = int.Parse(new string('9', n));
                List<int> list = new List<int>();
                for (int i = 1; i <= max; i++)
                {
                    list.Add(i);
                }

                return list.ToArray();
            }
        }
    }
}
