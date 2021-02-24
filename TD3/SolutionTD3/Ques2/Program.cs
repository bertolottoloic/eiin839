using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Ques2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient http = new HttpClient();
            try
            {

                System.Collections.Generic.List<Station> stations = await http.GetFromJsonAsync<System.Collections.Generic.List<Station>>("https://api.jcdecaux.com/vls/v3/stations?apiKey=bcf8e0014e5509ec4e4238d062207b525253b599");
                stations.ForEach(station => Console.WriteLine(station));
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
