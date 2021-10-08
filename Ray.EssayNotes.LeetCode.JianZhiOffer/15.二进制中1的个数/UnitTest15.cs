using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            int i = 3;
            i = i >> 1;
            Debug.WriteLine(i);

            var re = new Solution().HammingWeight(11);
        }

        public class Solution
        {
            public int HammingWeight(uint n)
            {
                //思路：转为字符串
                string s = Convert.ToString(n, 2);
                return s.Count(x => x == '1');
            }
            public int HammingWeight2(uint n)
            {
                //思路：位运算
                uint result = 0;
                while (n > 0)
                {
                    result += n & 1;
                    n >>= 1;
                }
                return Convert.ToInt32(result);
            }
            public int HammingWeight3(uint n)
            {
                //思路：n&(n-1)
                int result = 0;
                while (n > 0)
                {
                    n &= (n - 1);
                    result++;
                }
                return result;
            }
        }
    }
}
