using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class FeedList : List<Feed>
    {
        public static FeedList ListOfFeeds { get; set; }

        public static Feed getFeed (string _url)
        {
            var selectedFeed = ListOfFeeds.Where((f) => f.FeedUrl.Equals(_url));
            return selectedFeed as Feed;
        }




        public static void AddFeed(FeedList fL, Feed f)
        {
            ListOfFeeds = fL;

            fL.Add(f);
        }

        public static FeedList ReturnList ()
        {
            return ListOfFeeds;
        }

        



    }

   
}
