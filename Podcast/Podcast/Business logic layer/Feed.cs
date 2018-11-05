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
    public class Feed : Entities<Feed>, IListable
    {
        Serializer serializer = new Serializer();

        private List<Feed> FeedList = new List<Feed>();

        
        
        
         
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        

        public override void AddToList(Feed f)
        {
            //var newFeed = new Feed { Title = name, FeedUrl = url, UpdateFrequency = updateFreq,
            //    Category = category };

                FeedList.Add(f);
                serializer.SerializeXml(FeedList, "fList");
            
        }
        public void UpdateFeed(string name, string url, int updateFreq, string category, string changeName)
        {   
            if (Validation.OnlyLetters(name))
            {
                var obj = FeedList.FirstOrDefault(f => f.Title == name);
                if (obj != null)
                {
                    obj.Title = changeName;
                    obj.FeedUrl = url;
                    obj.UpdateFrequency = updateFreq;
                    obj.Category = category;
                    serializer.SerializeXml(FeedList, "FList");
                }
                //FeedList.Where(f => f.Title == name)
                //.Select(f => { f.Title = f.Title.Replace(f.Title, name); return f; })
                //.Select(f => { f.FeedUrl = f.FeedUrl.Replace(f.FeedUrl, url); return f; })
                //.Select(f => { f.UpdateFrequency = f.UpdateFrequency.Replace(f.UpdateFrequency, updateFreq); return f; })
                //.Select(f => { f.Category = f.Category.Replace(f.Category, category); return f; })
                //.ToList();
                //serializer.SerializeXml(FeedList, "FList");
                

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

        public override List<Feed> GetList()
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
            }  */

        
    }
}
