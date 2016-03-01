using System;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace iBookie.Features.Repository
{
    public class FdRemoteRepository<T> : IRepository<T> where T : class
    {
        private const string BaseUrl = "http://api.football-data.org";
        private const string Token = "1a765b18dff34b5bb131b37b5708f03c";
        private const string Version = "/v1";
        private readonly IMemoryCache _cache;

        public FdRemoteRepository(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T Search(string searchUrl)
        {
            object cachedObj;
            if (_cache.TryGetValue(searchUrl, out cachedObj))
            {
                return (T) cachedObj;
            }

            var sourceUrl = $"{Version}{searchUrl}";
            var result = FetchJsonFromUrl(sourceUrl);
            _cache.Set(searchUrl, result.Result);
            return result.Result;
        }

        private static async Task<T> FetchJsonFromUrl(string searchUrl)
        {
            T json = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Auth-Token", Token);

                // New code:
                var response = await client.GetAsync(searchUrl);
                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    var serialzier = new JsonSerializer();
                    using (var reader = new StreamReader(stream))
                    {
                        json = (T)serialzier.Deserialize(reader, typeof(T));
                    }
                }
            }

            return json;
        }
    }
}
