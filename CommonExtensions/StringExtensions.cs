using System;
using Newtonsoft.Json;

namespace CommonExtensions
{
    public static class StringExtensions
    {
        public static bool TryDeserialize<T>(this string value, out T obj)
        {
            try
            {
                obj = JsonConvert.DeserializeObject<T>(value);
                return true;
            }
            catch (Exception)
            {
                obj = default;
                return false;
            }
        }
    }
}
