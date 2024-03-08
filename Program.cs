using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsert
{
    internal class Program
    {
        //https://leetcode.com/problems/search-insert-position/description/
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 4;
            Console.WriteLine(SearchInsertPos(nums, target));
            Console.ReadKey();
        }

        static int SearchInsertPos(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;
            while(low <= high)
            {
                mid = (low + high) / 2;
                if (nums[mid] > target)
                    high = mid - 1;
                else if(nums[mid] < target)
                    low = mid + 1;
                else return mid;
            }
            if (target > nums[mid]) return mid + 1;
            else return mid;
        }
    }
}
