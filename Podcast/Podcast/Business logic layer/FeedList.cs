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
        public FeedList ListOfFeeds = new FeedList();

        public void AddToList(Feed newFeed)
        {
            ListOfFeeds.Add(newFeed);
        }

        public

        public ListViewItem GetListItems()
        {

        }
    }
}
