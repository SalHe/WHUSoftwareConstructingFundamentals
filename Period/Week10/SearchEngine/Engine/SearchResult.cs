using System;
using System.Collections.Generic;
using System.Text;

namespace SearchEngine.Engine
{
    public class SearchResult
    {

        public string URL { get; private set; }
        public string Preview { get; private set; }

        public SearchResult(string url, string preview)
        {
            URL = url;
            Preview = preview;
        }
    }
}
