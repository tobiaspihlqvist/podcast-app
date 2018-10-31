using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class Feed: ISerializeable, IListable
    {
        Data_Access_Layer.Serializer serializer = new Data_Access_Layer.Serializer();

         List<Feed> FeedList = new List<Feed>();


        
        
         
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }


        public void AddFeed(string name, string url, int updateFreq, string category)
        {
            var newFeed = new Feed { Title = name, FeedUrl = url, UpdateFrequency = updateFreq, Category = category };
            FeedList.Add(newFeed);
            serializer.SerializeXml(FeedList, "fList");
            
        }

        

        public void LoadXml(string fileName) // ska flyttas till validation eller till serializer
        {
            if (File.Exists(fileName+".xml"))
            {
                FeedList = serializer.GetListFromXml<List<Feed>>(fileName);
            }
        }

        public List<Feed> GetList()
        {
            return FeedList;
        }

        public List<string> PrepareListViewItem()
        {
            return new List<string> { 
                
                    Title,
                    UpdateFrequency.ToString() + "Minutes",
                    Category
                };
        }


        public virtual ListViewItem ToListViewItem()
        {
            return new ListViewItem(PrepareListViewItem().ToArray());
        }

        public void FilterByCategory(ListView lv)
        {
            String chosenCat = lv.SelectedItems[0].Text;
            var FilteredList = GetList().Where(x => x.Category == chosenCat).ToList();

            
        }

        public string GetRssLink(string title)
        {
            Feed selectedFeed = FeedList.Find((f) => f.Title == title);
            string url = selectedFeed.FeedUrl;
            return url;
        }
    }
}
