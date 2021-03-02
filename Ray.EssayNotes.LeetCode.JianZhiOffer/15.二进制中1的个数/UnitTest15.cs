using System;
using System.Collections.Generic;
using System.Linq;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest15
    {
        [Fact]
        public void Test1()
        {
            var re = new Solution().HammingWeight2(00000000000000000000000000001011);
        }

        public class Solution
        {
            public int HammingWeight(uint n)
            {
                //思路：转成字符串
                var s = n.ToString();
                return s.Count(x => x == '1');
            }

            public int HammingWeight2(uint n)
            {
                //位运算
                uint result = 0;
                while (n > 0)
                {
                    result += n & 1;
                    n = n >> 1;
                }
                return Convert.ToInt32(result);
            }
        }
    }
}
