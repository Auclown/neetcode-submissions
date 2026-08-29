public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 0)
        {
            return false;
        }

        HashSet<int> numHashSet = new HashSet<int>(nums.Length + 1);
        for (int i = 0; i < nums.Length; i++)
        {
            if (!numHashSet.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}