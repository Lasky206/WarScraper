using System;
using System.Net.Http;

namespace WarScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.warhammer-community.com/";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url);

            Console.WriteLine(html.Result);
            Console.ReadLine();
        }
    }
}
