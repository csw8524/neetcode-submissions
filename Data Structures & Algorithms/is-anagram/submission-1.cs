public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var charsCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charsCount.ContainsKey(c))
            {
                charsCount[c]++;
            }
            else
            {
                charsCount[c] = 1;
            }
        }
        foreach (char c in t)
        {
            if (!charsCount.ContainsKey(c) || charsCount[c] == 0)
            {
                return false;  
            }
            charsCount[c]--;
        }
        return true;
    }
}
