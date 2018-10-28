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
        FeedList ListOfFeeds { get; set; }
        Data_Access_Layer.Serializer serializer = new Data_Access_Layer.Serializer();
        public List<ListViewItem> ListViewList = new List<ListViewItem>();

        public void AddToList(Feed newFeed)
        {
            var list = new FeedList();
            ListOfFeeds = list;
            ListOfFeeds.Add(newFeed);
            serializer.SerializeXml(ListOfFeeds);
        }

        public FeedList GetList()
        {
            return ListOfFeeds;
        }

        public void LoadFromXml()
        {
            var listFromXml = serializer.GetListFromXml();
            ListOfFeeds = listFromXml;
            PrepareListView();
        }

        public void PrepareListView()
        {
            var list = ListOfFeeds;
            foreach(var feed in list)
            {
                string[] row =
                {
                    feed.FeedUrl,
                    feed.UpdateFrequency.ToString() + "Minutes",
                    feed.Category
                };
                ListViewItem item = new ListViewItem(row);
                ListViewList.Add(item);
            }
        }

        

        public List<ListViewItem> GetListItems()
        {
            return ListViewList;
        }
    }
}
