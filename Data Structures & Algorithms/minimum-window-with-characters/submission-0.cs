public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length)
        {
            return "";
        }

        int[] sChars = new int[128];
        int[] tChars = new int[128];

        // Populate the target frequency
        foreach (char c in t)
        {
            tChars[c]++;
        }

        int need = 0; // The total number of unique characters required from string t.
        for (int i = 0; i < 128; i++)
        {
            if (tChars[i] > 0)
            {
                need++;
            }
        }

        int have = 0; // The number of unique required characters in the current window meet the target frequency.
        int left = 0;

        // Sliding
        int minLen = int.MaxValue; // The shortest valid window length found so far.
        int startIndex = 0; // The left index where that shortest window began.

        for (int right = 0; right < s.Length; right++)
        {
            char rightChar = s[right];
            sChars[rightChar]++;

            // Check if rightChar satisfies the requirement.
            // then shrink left while have == need
            if (tChars[rightChar] > 0 && sChars[rightChar] == tChars[rightChar])
            {
                have++;
            }
            while (have == need)
            {
                if (right - left + 1 < minLen)
                {
                    minLen = right - left + 1;
                    startIndex = left;
                }

                char leftChar = s[left];
                sChars[leftChar]--;

                if (tChars[leftChar] > 0 && sChars[leftChar] < tChars[leftChar])
                {
                    have--;
                }

                left++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
    }
}
