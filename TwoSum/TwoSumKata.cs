using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace TwoSum
{
    public class TwoSumKata

    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };

            for (var i = 0; i < nums.Length; i++)
            {
                var remains = target - nums[i];
                var range = nums.ToList().GetRange(i + 1, nums.Length - (i + 1));
                if (range.Contains(remains))
                {
                    result = new int[] { i, range.IndexOf(remains) + (i + 1) };
                }
            }

            return result;
        }
    }
}