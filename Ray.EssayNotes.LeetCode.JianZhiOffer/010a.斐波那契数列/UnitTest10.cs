using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest10
    {
        [Fact]
        public void Test1()
        {
            Solution s = new Solution();
            var r = s.Fib(5);
        }
    }

    public class Solution
    {
        private static List<int> _list = new List<int>() { 0, 1 };

        public int Fib(int n)
        {
            if (n < _list.Count) return _list[n];

            while (_list.Count - 1 < n)
            {
                int last = _list.Count - 1;
                _list.Add((_list[last] + _list[last - 1]) % 1000000007);
            }
            return Fib(n);
        }
    }
}
