namespace Utils.Extensions
{
    public static class DictionaryExtensions
    {
        public static IOrderedEnumerable<KeyValuePair<T, Y>> GetOrderedTeamBy<T, Y, X>(this Dictionary<T, Y> dic, Func<KeyValuePair<T, Y>, X> func)
        {
            return dic.OrderBy(func);
        }

        public static Dictionary<T, Y> InitializeDictionary<T, Y>()
        {
            return new();
        }

        public static Dictionary<int, Y> Fillictionary<Y>(this Dictionary<int, Y> dic, int capacity) where Y : class, new()
        {
            for (int i = 0; i < capacity; i++)
            {
                dic.Add(i, new());
            }

            return dic;
        }
    }
}