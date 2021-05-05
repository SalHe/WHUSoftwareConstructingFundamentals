using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Engine
{
    public interface ISearchEngine
    {
        public string Name { get; }

        public IList<SearchResult> Search(string query)
        {
            return SearchAsync(query).Result;
        }

        public Task<IList<SearchResult>> SearchAsync(string query);

    }
}
