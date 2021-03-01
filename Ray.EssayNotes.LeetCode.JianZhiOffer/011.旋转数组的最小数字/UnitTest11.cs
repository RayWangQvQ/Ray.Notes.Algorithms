using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.LeetCode.JianZhiOffer
{
    public class UnitTest11
    {
        [Fact]
        public void Test1()
        {

        }

        public class Solution
        {
            public int MinArray(int[] numbers)
            {
                if (numbers == null) return 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i + 1] < numbers[i]) return numbers[i + 1];
                }
                return numbers[0];
            }
        }
    }
}
