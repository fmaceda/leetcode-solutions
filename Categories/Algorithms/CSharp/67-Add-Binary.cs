public class Solution
{
  public string AddBinary(string a, string b)
  {
    var aIdx = a.Length - 1;
    var bIdx = b.Length - 1;

    var maxLength = Math.Max(aIdx, bIdx);

    var sum = new char[maxLength + 1];

    int sumIdx = maxLength;
    int currSum = 0;
    int remainder = 0;

    while (sumIdx >= 0)
    {
      int currA = aIdx >= 0 ? (int)a[aIdx] - '0' : 0;
      int currB = bIdx >= 0 ? (int)b[bIdx] - '0' : 0;
      (currSum, remainder) = ((currA + currB + remainder) % 2, (currA + currB + remainder) / 2);

      sum[sumIdx] = (char)(currSum + '0');

      aIdx--;
      bIdx--;
      sumIdx--;
    }



    if (remainder > 0)
    {
      return (char)(remainder + '0') + new string(sum);
    }

    return new string(sum);
  }
}