using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace ImdbWebApp.services
{
    public static class ApiConnection<T>
    {

        public static async Task<T> getData(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsAsync<T>();
        }
    }
}
