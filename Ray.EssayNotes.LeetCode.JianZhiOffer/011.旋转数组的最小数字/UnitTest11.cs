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
            int[] num = new[] { 2, 2, 2, 0, 1 };
            var re = new Solution().MinArray2(num);
        }

        public class Solution
        {
            public int MinArray(int[] numbers)
            {
                //思路：遍历
                if (numbers == null) return 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i + 1] < numbers[i]) return numbers[i + 1];
                }
                return numbers[0];
            }

            public int MinArray2(int[] numbers)
            {
                //思路：二分查找
                if (numbers == null) return 0;

                int left = 0;
                int right = numbers.Length - 1;
                while (left < right)
                {
                    int pivot = left + (right - left) / 2;
                    if (numbers[pivot] < numbers[right])//说明在最小值右边
                    {
                        right = pivot;
                    }
                    else if (numbers[pivot] > numbers[right]) //说明在最小值左边
                    {
                        left = pivot + 1;
                    }
                    else
                    {
                        right--;
                    }
                }

                return numbers[right];
            }
        }
    }
}
