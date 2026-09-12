public class TimeMap
{
    private readonly Dictionary<string, List<(int Timestamp, string Value)>> store;

    public TimeMap()
    {
        store = new Dictionary<string, List<(int Timestamp, string Value)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            store[key] = new List<(int Timestamp, string Value)>();
        }

        store[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!store.TryGetValue(key, out var records) || records.Count == 0)
        {
            return "";
        }

        string result = "";
        int left = 0;
        int right = records.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (records[mid].Timestamp <= timestamp)
            {
                result = records[mid].Value;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
