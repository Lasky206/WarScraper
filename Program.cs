using System;
<<<<<<< HEAD
using System.Linq;
using HtmlAgilityPack;
=======
using System.Net.Http;
>>>>>>> 7ff60de341667229943f22af2d49802155cae629

namespace WarScraper
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.blacklibrary.com/default.aspx");

            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a").ToArray();
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }
=======
            var url = "https://www.warhammer-community.com/";
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url);

            Console.WriteLine(html.Result);
            Console.ReadLine();
>>>>>>> 7ff60de341667229943f22af2d49802155cae629
        }
    }
}
