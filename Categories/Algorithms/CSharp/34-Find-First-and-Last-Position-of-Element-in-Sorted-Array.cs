public class Solution
{
  public int[] SearchRange(int[] nums, int target)
  {
    int[] solution = { -1, -1 };

    var left = 0;
    var right = nums.Length - 1;

    while (left <= right)
    {
      var mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        solution[0] = mid;
      }

      if (nums[mid] >= target)
      {
        right = mid - 1;
      }

      if (nums[mid] < target)
      {
        left = mid + 1;
      }
    }

    left = 0;
    right = nums.Length - 1;

    while (left <= right)
    {
      var mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        solution[1] = mid;
      }

      if (nums[mid] > target)
      {
        right = mid - 1;
      }

      if (nums[mid] <= target)
      {
        left = mid + 1;
      }
    }

    return solution;
  }
}