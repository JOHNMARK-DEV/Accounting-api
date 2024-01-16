using System.Collections; 

namespace accounting_api.Cache
{
    public static class CacheData
    {
        public static Dictionary<string, IList> Data { get; set; } = new Dictionary<string, IList>();
         
    }


}
