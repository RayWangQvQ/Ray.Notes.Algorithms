using System;
using System.Collections.Generic;
using Ray.EssayNotes.Algorithms;
using Xunit;

namespace Ray.EssayNotes.Algorithms
{
    // https://leetcode-cn.com/problems/remove-element/

    public class UnitTest027
    {
        [Fact]
        public void Test1()
        {

        }


        public class Solution
        {
            /* 用双指针法，
             思路是，最后数组左边是排出后的有用的数字
             第一个指针用来指向有用数字的最后一个下表，第二个指针用来向右依次遍历数组，遇到val就跳过，遇到有用的，则将其赋值到idx
             */

            public int RemoveElement(int[] nums, int val)
            {
                int idx = 0;
                for (int search = 0; search < nums.Length; search++)
                {
                    //如果是val，就跳过，继续向右搜索
                    if (nums[search] == val) continue;

                    //如果不是val，就将它赋值到idx位置
                    nums[idx] = nums[search];
                    idx++;
                }
                return idx;
            }
        }

        public class Solution2
        {
            /*
             * 双指针优化（首尾指针法）
             *
             */

            public int RemoveElement(int[] nums, int val)
            {
                int idx = 0;
                int search = nums.Length;
                while (idx != search)
                {
                    if (nums[idx] == val)
                    {
                        nums[idx] = nums[search];
                        search--;
                    }
                    else
                    {
                        idx++;
                    }
                }

                if (nums[idx] == val) return idx;
                else return idx++;
            }
        }
    }
}
