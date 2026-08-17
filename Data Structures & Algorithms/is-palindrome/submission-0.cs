public class Solution {
    public bool IsPalindrome(string s) {
        string cleanString = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLowerInvariant();
        string reversed = "";

        for (int i = cleanString.Length - 1; i >= 0; i--)
        {
            reversed += cleanString[i];
        }

        return reversed == cleanString;
    }
}
