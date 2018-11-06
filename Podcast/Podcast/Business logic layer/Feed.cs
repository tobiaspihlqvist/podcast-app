using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Podcast.Data_Access_Layer;

namespace Podcast.Business_logic_layer
{
    public class Feed : Entities<Feed>, IListable
    {
        private Serializer serializer = new Serializer();

        private List<Feed> FeedList = new List<Feed>();

        
        
        
         
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        

        public override void AddToList(Feed f)
        {
                FeedList.Add(f);
                serializer.SerializeXml(FeedList, "fList"); 
        }
        public void UpdateFeed(string name, string url, int updateFreq, string category, string changeName)
        {   
            try 
            {
                Validation.OnlyLetters(name);
                var obj = FeedList.FirstOrDefault(f => f.Title == name);
                if (obj != null)
                {
                    obj.Title = changeName;
                    obj.FeedUrl = url;
                    obj.UpdateFrequency = updateFreq;
                    obj.Category = category;
                    serializer.SerializeXml(FeedList, "FList");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
  
    }
}
