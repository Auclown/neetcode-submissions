public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        // Index represents the road position, value represents car's speed
        int[] road = new int[target];
        for (int i = 0; i < position.Length; i++) 
        {
            road[position[i]] = speed[i];
        }

        int fleets = 0;
        double maxTime = 0.0;

        // Iterate backwards from the finish line to the start (descending position)
        for (int p = target - 1; p >= 0; p--) 
        {
            if (road[p] == 0)
            {
                // No car at this mile marker
                continue;
            }

            double time = (double)(target - p) / road[p];
            if (time > maxTime) 
            {
                maxTime = time;
                fleets++;
            }
        }

        return fleets;
    }
}
