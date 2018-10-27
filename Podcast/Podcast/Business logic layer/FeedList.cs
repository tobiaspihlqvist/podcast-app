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
        Data_Access_Layer.Serializer serializer = new Data_Access_Layer.Serializer();

        public void AddToList(Feed newFeed)
        {
            ListOfFeeds.Add(newFeed);
            serializer.SerializeXml(ListOfFeeds);
        }

        public void LoadFromXml()
        {
            var listFromXml = serializer.GetListFromXml();
            ListOfFeeds = listFromXml;
        }

        

        public ListViewItem GetListItems()
        {

        }
    }
}
