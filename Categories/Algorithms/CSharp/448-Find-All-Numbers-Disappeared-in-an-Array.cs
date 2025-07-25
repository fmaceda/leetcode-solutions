public class Solution
{
  public IList<int> FindDisappearedNumbers(int[] nums)
  {
    int idx1 = 0;

    while (idx1 < nums.Length)
    {
      int val = nums[idx1];

      if (idx1 + 1 == val || nums[val - 1] == val)
      {
        idx1++;
      }
      else
      {
        (nums[idx1], nums[val - 1]) = (nums[val - 1], nums[idx1]);
      }
    }

    var missingNumbers = new List<int>();

    for (int idx2 = 0; idx2 < nums.Length; idx2++)
    {
      if (idx2 + 1 != nums[idx2])
      {
        missingNumbers.Add(idx2 + 1);
      }
    }

    return missingNumbers;
  }
}