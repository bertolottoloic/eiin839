using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Ques1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient http = new HttpClient();
            try
            {
                HttpResponseMessage response = await http.GetAsync("https://api.jcdecaux.com/vls/v3/stations?apiKey=bcf8e0014e5509ec4e4238d062207b525253b599");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
                Console.ReadLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

        }

    }
}
