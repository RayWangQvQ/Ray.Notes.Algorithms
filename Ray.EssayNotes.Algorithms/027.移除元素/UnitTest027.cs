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
            /* ��˫ָ�뷨��
             ˼·�ǣ��������������ų�������õ�����
             ��һ��ָ������ָ���������ֵ����һ���±��ڶ���ָ�������������α������飬����val���������������õģ����丳ֵ��idx
             */

            public int RemoveElement(int[] nums, int val)
            {
                int idx = 0;
                for (int search = 0; search < nums.Length; search++)
                {
                    //�����val����������������������
                    if (nums[search] == val) continue;

                    //�������val���ͽ�����ֵ��idxλ��
                    nums[idx] = nums[search];
                    idx++;
                }
                return idx;
            }
        }

        public class Solution2
        {
            /*
             * ˫ָ���Ż�����βָ�뷨��
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
