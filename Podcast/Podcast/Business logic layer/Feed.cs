using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.Business_logic_layer
{
    public class Feed
    {
        FeedList feeds = new FeedList();
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }


        public void AddFeed(string name, string url, int updateFreq, string category)
        {
            var newFeed = new Feed { Title = name, FeedUrl = url, UpdateFrequency = updateFreq, Category = category };
            feeds.AddToList(newFeed);
        }

        
    }
}
