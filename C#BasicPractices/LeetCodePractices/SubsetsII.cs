using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodePractices
{
    /* 
    //Subsets II https://leetcode.com/problems/subsets-ii/
    Given an integer array nums that may contain duplicates, return all possible subsets(the power set).
    The solution set must not contain duplicate subsets.Return the solution in any order.

    Example 1:
    Input: nums = [1, 2, 2]
    Output: [[], [1], [1,2], [1,2,2], [2], [2,2]]

    Example 2:
    Input: nums = [0]
    Output: [[],[0]]
    */
    public class SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(nums, 0, new List<int>(), result);
            return result;
        }
        private void Backtrack(int[] nums, int start, List<int> current, IList<IList<int>> result)
        {
            result.Add(new List<int>(current));

            for (int i = start; i < nums.Length; i++)
            {
                // Skip duplicates
                if (i > start && nums[i] == nums[i - 1])
                    continue;

                current.Add(nums[i]);
                Backtrack(nums, i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
