using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.Business_logic_layer
{
    public class Feed
    {
        public List<Feed> ListOfFeeds { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        public string FeedUrl { get; set; }

        public Feed() { }

        public Feed (string _title, string _category, int _frequency, string _url)
        {
            Title = _title;
            Category = _category;
            UpdateFrequency = _frequency;
            FeedUrl = _url;
        }

        
    }
}
