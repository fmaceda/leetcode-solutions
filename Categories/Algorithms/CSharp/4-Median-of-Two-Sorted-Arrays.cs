public class Solution
{
  public double FindMedianSortedArrays(int[] nums1, int[] nums2)
  {
    if (nums1.Length > nums2.Length)
    {
      return FindMedianSortedArrays(nums2, nums1);
    }
    // Only case: nums1 < nums2

    int nums1Count = nums1.Length;
    int nums2Count = nums2.Length;
    int totalCount = nums1Count + nums2Count;

    var low = 0;
    var high = nums1Count;

    var leftPartition = (totalCount + 1) / 2;

    while (low <= high)
    {
      var mid1 = (low + high) / 2;
      var mid2 = leftPartition - mid1;

      var left1 = int.MinValue;
      var right1 = int.MaxValue;

      var left2 = int.MinValue;
      var right2 = int.MaxValue;

      // Find the two mid elements in nums1
      if (mid1 < nums1Count)
      {
        right1 = nums1[mid1];
      }

      if (mid1 - 1 >= 0)
      {
        left1 = nums1[mid1 - 1];
      }

      // Find the two mid elements in nums2
      if (mid2 < nums2Count)
      {
        right2 = nums2[mid2];
      }

      if (mid2 - 1 >= 0)
      {
        left2 = nums2[mid2 - 1];
      }

      if (left1 <= right2 && left2 <= right1)
      {
        if (totalCount % 2 == 0) // Even count
        {
          return (double)((Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0);
        }
        else
        {
          return Math.Max(left1, left2);
        }
      }
      else if (left1 > right2)
      {
        high = mid1 - 1;
      }
      else
      {
        low = mid1 + 1;
      }
    }

    return 0; // Default output to cover the case where arrays were not sorted.

  }
}