public class Solution
{

  static void Reverse(int[] nums, int startIdx, int endIdx)
  {
    while (startIdx < endIdx)
    {
      (nums[startIdx], nums[endIdx]) = (nums[endIdx], nums[startIdx]);
      startIdx++;
      endIdx--;
    }
  }

  public void Rotate(int[] nums, int k)
  {
    var steps = k % nums.Length;

    Reverse(nums, 0, nums.Length - 1);
    Reverse(nums, 0, steps - 1);
    Reverse(nums, steps, nums.Length - 1);
  }
}