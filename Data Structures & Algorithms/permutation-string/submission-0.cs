public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        int windowSize = s1.Length;

        // Add each character's count
        for (int i = 0; i < windowSize; i++)
        {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        // Slide the window!
        for (int i = windowSize; i < s2.Length; i++)
        {
            if (Matches(s1Count, s2Count))
            {
                return true;
            }

            s2Count[s2[i] - 'a']++;
            s2Count[s2[i - windowSize] - 'a']--;
        }

        return Matches(s1Count, s2Count);
    }

    private bool Matches(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }
}
