public class Solution
{
  public void Merge(int[] nums1, int m, int[] nums2, int n)
  {
    int idx1 = m;
    int idx2 = n;

    while (idx1 > 0 && idx2 > 0)
    {
      if (nums2[idx2 - 1] > nums1[idx1 - 1])
      {
        nums1[idx1 + idx2 - 1] = nums2[idx2 - 1];
        idx2--;
      }
      else
      {
        nums1[idx1 + idx2 - 1] = nums1[idx1 - 1];
        idx1--;
      }
    }

    while (idx2 > 0)
    {
      nums1[idx2 - 1] = nums2[idx2 - 1];
      idx2--;
    }
  }
}