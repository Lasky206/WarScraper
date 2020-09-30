using System;
using System.Linq;
using HtmlAgilityPack;

namespace WarScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.blacklibrary.com/default.aspx");

            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//a").ToArray();
            foreach (HtmlNode item in nodes)
            {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }
}
