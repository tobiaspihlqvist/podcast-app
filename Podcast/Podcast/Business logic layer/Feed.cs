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
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }


        public void AddFeed(string url, int updateFreq, string category)
        {
            var newFeed = new Feed { FeedUrl = url, UpdateFrequency = updateFreq, Category = category };
            feeds.AddToList(newFeed);
        }

        
    }
}
