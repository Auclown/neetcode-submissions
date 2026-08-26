public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] frequencyMap = new int[26];
        int left = 0;
        int maxFrequency = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            // Count each alphabet character
            frequencyMap[s[right] - 'A']++;

            // Update the max frequency
            maxFrequency = Math.Max(maxFrequency, frequencyMap[s[right] - 'A']);

            // Shrink left
            if ((right - left + 1) - maxFrequency > k)
            {
                frequencyMap[s[left] - 'A']--;
                left++;
            }

            // Update the max length
            maxLength = Math.Max(maxLength, (right - left + 1));
        }

        return maxLength;
    }
}
