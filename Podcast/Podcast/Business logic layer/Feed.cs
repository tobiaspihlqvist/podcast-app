using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Podcast.Data_Access_Layer;

namespace Podcast.Business_logic_layer
{
    public class Feed: IListable
    {
        Serializer serializer = new Serializer();

        List<Feed> FeedList = new List<Feed>();

        
        
        
         
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        

        public void AddFeed(string name, string url, int updateFreq, string category)
        {
            var newFeed = new Feed { Title = name, FeedUrl = url, UpdateFrequency = updateFreq,
                Category = category };

                FeedList.Add(newFeed);
                serializer.SerializeXml(FeedList, "fList");
            
        }
        public void UpdateFeed(string name, string url, int updateFreq, string category)
        {
            if (Validation.OnlyLetters(name))
            {
                FeedList.Where(f => f.Title == name)
                .Select(f => { f.Title = f.Title.Replace(f.Title, name); return f; })
                .Select(f => { f.FeedUrl = f.Title.Replace(f.FeedUrl, url); return f; })
                .Select(f => { f.UpdateFrequency = f.Title.Replace(f.UpdateFrequency, updateFreq); return f; })
                .Select(f => { f.Title = f.Title.Replace(f.Category, category); return f; })

                .ToList();
                serializer.SerializeXml(FeedList, "FList");

            }
        }

        public void DeleteFeed(string chosenFeed)
        {
            
            FeedList.Remove(FeedList.Find(P => P.Title == chosenFeed));
            serializer.SerializeXml(FeedList, "fList");

        }


        public void LoadXml(string fileName) // ska flyttas till validation eller till serializer
        {
            if (Validation.XmlExists("fList"))
            {
                FeedList = serializer.GetListFromXml<List<Feed>>(fileName);
            }
        }

        public List<Feed> GetList()
        {
            return FeedList;
        }

        
        protected virtual List<string> PrepareListViewItem()
        {       var list = FeedList;

            return new List<string>
                {
                    Title,
                    UpdateFrequency.ToString() + "Minutes",
                    Category
                };
            }

        public virtual ListViewItem ToListViewItem()
        {
            return new ListViewItem(PrepareListViewItem().ToArray());
        }

        /*      public List<ListViewItem> ToListViewItem()
            {
            var list = FeedList;
            var lvList = new List<ListViewItem>();
            foreach (var feed in list)
            {
                string[] row =
                {
                    feed.Title,
                    feed.UpdateFrequency.ToString() + "Minutes",
                    feed.Category
                };
                ListViewItem item = new ListViewItem(row);
                lvList.Add(item);
            }
            return lvList;
            } */

        //public async Task EpisodeUpdater(string url, int interval)
        //{
        //    Episodes.Clear();
        //    var intervalTime = Convert.ToDouble(interval);
        //    while (true)
        //    {
        //        await Task.Run(() =>
        //        {
        //            XmlReader reader = XmlReader.Create(url);
        //            SyndicationFeed sFeed = SyndicationFeed.Load(reader);
        //            foreach (SyndicationItem si in sFeed.Items)
        //            {
        //                Episodes.Add(si);
        //            }

        //        });
        //        await Task.Delay(TimeSpan.FromMinutes(intervalTime));
        //    }
        //}
        


    }
}
