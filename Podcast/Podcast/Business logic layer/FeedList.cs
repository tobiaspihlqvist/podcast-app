using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast.Business_logic_layer
{
    public  class FeedList : List<Feed>
    {
        static FeedList ListOfFeeds { get; set; }
        public static void AddFeed(Feed f)
        {
            ListOfFeeds.Add(f);
        }



    }

   
}
