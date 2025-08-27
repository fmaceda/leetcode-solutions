public class Solution
{
  public int Search(int[] nums, int target)
  {
    var left = 0;
    var right = nums.Length - 1;

    while (left <= right)
    {
      var mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        return mid;
      }

      if (nums[left] <= nums[mid])
      {
        // Sorted from left to mid
        if (nums[left] <= target && target <= nums[mid])
        {
          right = mid - 1;
        }
        else
        {
          left = mid + 1;
        }
      }
      else
      {
        // Sorted from mid to right
        if (nums[mid] <= target && target <= nums[right])
        {
          left = mid + 1;
        }
        else
        {
          right = mid - 1;
        }
      }
    }

    return -1;
  }
}