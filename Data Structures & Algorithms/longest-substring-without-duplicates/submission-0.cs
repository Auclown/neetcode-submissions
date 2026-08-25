public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charHashSet = new HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (charHashSet.Contains(s[right]))
            {
                charHashSet.Remove(s[left]);
                left++;
            }

            charHashSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
