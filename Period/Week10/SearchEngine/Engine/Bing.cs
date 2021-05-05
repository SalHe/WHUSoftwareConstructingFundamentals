using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace SearchEngine.Engine
{
    public class Bing : ISearchEngine
    {

        private static Bing _default = null;
        public static Bing Default
        {
            get
            {
                if (_default == null)
                    _default = new Bing();
                return _default;
            }
        }
        public string Name => "Bing";

        private HttpClient client;

        public Bing()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", HttpConstants.UserAgent);
        }

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
                    HtmlNodeCollection nodes = htmlDocument.DocumentNode.SelectNodes("//ol[@id='b_results']//li[@class='b_algo']");
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
            return "https://cn.bing.com/search?q=" + HttpUtility.UrlEncode(query);
        }
    }
}
