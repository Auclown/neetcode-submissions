public class Solution {
    public string Encode(IList<string> strs) {
        if (strs.Count == 0)
        {
            return "EMPTY_LIST";
        }

        string concat = string.Join("😀", strs);
        byte[] textBytes = Encoding.UTF8.GetBytes(concat);
        string base64String = Convert.ToBase64String(textBytes);

        return base64String;
    }

    public List<string> Decode(string s) {
        if (s == "EMPTY_LIST")
        {
            return new List<string> {};
        }

        byte[] rawBytes = Convert.FromBase64String(s);
        string decodedText = Encoding.UTF8.GetString(rawBytes);

        return decodedText.Split("😀").ToList();
    }
}
