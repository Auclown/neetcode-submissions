public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == 0 || k == 0)
        {
            return new int[] {};
        }

        int[] result = new int[] {};
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!numDict.ContainsKey(num))
            {
                numDict.Add(num, 1);
            }
            else
            {
                numDict[num] += 1;
            }
        }

        var sorted = numDict
            .OrderByDescending(kvp => kvp.Value)
            .Select(kvp => kvp.Key)
            .ToArray();

        return sorted[0..k];
    }
}
