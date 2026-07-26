public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs) 
        {
            // 1. Convert string to character array and sort it to form the key
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // 2. Add key to dictionary if it doesn't exist yet
            if (!map.ContainsKey(key)) 
            {
                map[key] = new List<string>();
            }

            // 3. Append the original string to its matching anagram list
            map[key].Add(s);
        }

        // 4. Return all collected lists
        return new List<List<string>>(map.Values);
    }
}
