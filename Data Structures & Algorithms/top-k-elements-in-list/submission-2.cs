public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach (int num in nums) {
            countMap[num] = countMap.GetValueOrDefault(num, 0) + 1;
        }

        // Bucket array where index = frequency
        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (var kvp in countMap) {
            int frequency = kvp.Value;
            if (bucket[frequency] == null) {
                bucket[frequency] = new List<int>();
            }
            bucket[frequency].Add(kvp.Key);
        }

        // Gather top K elements from highest frequency to lowest
        int[] result = new int[k];
        int resultIndex = 0;

        for (int i = bucket.Length - 1; i >= 0 && resultIndex < k; i--) {
            if (bucket[i] != null) {
                foreach (int num in bucket[i]) {
                    result[resultIndex++] = num;
                    if (resultIndex == k) return result;
                }
            }
        }

        return result;
    }
}