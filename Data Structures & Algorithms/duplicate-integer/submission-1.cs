public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var numsCount = new Dictionary<int, int>();
        
        foreach (int num in nums)
        {
            if (numsCount.ContainsKey(num))
            {
                return true;
            }
            else
            {
                numsCount[num] = 1;
            }
        }
        return false;
    }
}