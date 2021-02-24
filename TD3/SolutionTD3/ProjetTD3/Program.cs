using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using ProjetTD3;

namespace Ques1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient http = new HttpClient();
            try
            {

                System.Collections.Generic.List < Contract > contracts = await http.GetFromJsonAsync<System.Collections.Generic.List<Contract>>("https://api.jcdecaux.com/vls/v3/contracts?apiKey=bcf8e0014e5509ec4e4238d062207b525253b599");
                contracts.ForEach(contract => Console.WriteLine(contract));
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
