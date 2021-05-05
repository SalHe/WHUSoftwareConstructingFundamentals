using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace SearchEngine.Engine
{
    public class Baidu : ISearchEngine
    {

        private static Baidu _default = null;
        public static Baidu Default
        {

            get
            {
                if (_default == null)
                    _default = new Baidu();
                return _default;
            }
        }

        private HttpClient client;

        public Baidu()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", HttpConstants.UserAgent);
        }

        public string Name => "百度";

        public Task<IList<SearchResult>> SearchAsync(string query)
        {
            return Task.Run(async () =>
            {
                IList<SearchResult> searchResults = new List<SearchResult>();
                HttpResponseMessage response = await client.GetAsync(BuildUrl(query));
                if (response.IsSuccessStatusCode)
                {
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(await response.Content.ReadAsStringAsync());
                    HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//div[@id='content_left']/div[contains(@class, 'result')]");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            string url = node.SelectSingleNode(node.XPath + "//a").GetAttributeValue("href", "");
                            searchResults.Add(new SearchResult(url, node.InnerText.Trim()));
                        }
                    }
                }
                return searchResults;
            });
        }

        private static string BuildUrl(string query)
        {
            return "https://www.baidu.com/s?wd=" + HttpUtility.UrlEncode(query);
        }
    }
}
