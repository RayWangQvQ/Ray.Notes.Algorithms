using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest10b
    {
        [Fact]
        public void Test1()
        {

        }

        public class Solution
        {
            //经过推演，发现符合斐波那契数列特征
            private static List<int> _list = new List<int>() { 1, 1 };

            public int NumWays(int n)
            {
                if (n < _list.Count) return _list[n];

                while (_list.Count - 1 < n)
                {
                    _list.Add((_list[_list.Count - 1] + _list[_list.Count - 2]) % 1000000007);
                }
                return NumWays(n);
            }
        }
    }
}
