﻿using System;
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
    public class Feed
    {
        Serializer serializer = new Serializer();

        List<Feed> FeedList = new List<Feed>();

        List<ListViewItem> LvList = new List<ListViewItem>();
        

        
        
         
        public string Title { get; set; }
        public string FeedUrl { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        public List<SyndicationItem> Episodes { get; set; }

        public void AddFeed(string name, string url, int updateFreq, string category, List<SyndicationItem> feedEpisodes)
        {
            var newFeed = new Feed { Title = name, FeedUrl = url, UpdateFrequency = updateFreq,
                Category = category, Episodes = feedEpisodes  };
            FeedList.Add(newFeed);
            serializer.SerializeXml(FeedList, "fList");
            
        }

        public void DeleteFeed(string chosenFeed)
        {
            var feedToRemove = FeedList.Single(f => f.Title == chosenFeed);
 
                FeedList.Remove(feedToRemove);

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

        public List<SyndicationItem> GetEpisodes()
        {
            return Episodes;
        }

        public List<ListViewItem> PrepareListView()
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
        }

        public async Task EpisodeUpdater(string url, int interval)
        {
            Episodes.Clear();
            var intervalTime = Convert.ToDouble(interval);
            while (true)
            {
                await Task.Run(() =>
                {
                    XmlReader reader = XmlReader.Create(url);
                    SyndicationFeed sFeed = SyndicationFeed.Load(reader);
                    foreach (SyndicationItem si in sFeed.Items)
                    {
                        Episodes.Add(si);
                    }

                });
                await Task.Delay(TimeSpan.FromMinutes(intervalTime));
            }
        }
        


    }
}
