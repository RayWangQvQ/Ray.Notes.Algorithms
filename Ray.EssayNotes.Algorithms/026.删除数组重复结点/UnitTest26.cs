using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    public class UnitTest26
    {
        [Fact]
        public void Test1()
        {
            var nums = new[] { 1, 2, 2 };
            var count = RemoveDuplicates(nums);
        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int pre = nums[0];
            int count = 1;
            int next = 2;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > pre)
                {
                    count++;
                    next++;
                    pre = nums[i];
                    continue;
                }

                while (next < nums.Length)
                {
                    if (nums[next] > nums[i] && nums[next] > pre)
                    {
                        pre = nums[i] = nums[next];
                        count++;
                        next++;
                        break;
                    }

                    next++;
                }
            }

            return count;
        }
    }
}
