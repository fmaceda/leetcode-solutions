public class Solution
{
  public int[] SortArrayByParity(int[] nums)
  {
    int evenIdx = 0;
    int oddIdx = nums.Length - 1;

    while (evenIdx < oddIdx)
    {
      if (nums[evenIdx] % 2 == 1 && nums[oddIdx] % 2 == 0)
      {
        int tmp = nums[evenIdx];
        nums[evenIdx] = nums[oddIdx];
        nums[oddIdx] = tmp;
        evenIdx++;
        oddIdx--;
      }
      else
      {
        if (nums[evenIdx] % 2 == 0)
        {
          evenIdx++;
        }

        if (nums[oddIdx] % 2 == 1)
        {
          Console.WriteLine("VAL2");
          oddIdx--;
        }
      }
    }

    return nums;
  }
}