public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, bool>();

        foreach (int num in nums)
        {
            var tryAdd = dict.TryAdd(num, true);
            if (!tryAdd)
            {
                return true;
            }
        }

        return false;
    }
}