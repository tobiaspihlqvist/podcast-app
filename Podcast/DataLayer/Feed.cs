using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataLayer
{
    public class Feed
    {
        private List<Feed> ListOfFeeds = new List<Feed>();
        public string Title { get; set; }
        public string Category { get; set; }
        public int UpdateFrequency { get; set; }
        public string FeedUrl { get; set; }

        public void AddPodToFeed(string _category, int _updateFreq, string _podUrl)
        {
            XmlReader reader = XmlReader.Create(_podUrl);
            SyndicationFeed sFeed = SyndicationFeed.Load(reader);

            string podTitle = sFeed.Title.Text;

            var pod = new Feed { Title = podTitle, Category = _category, UpdateFrequency = _updateFreq, FeedUrl = _podUrl };
            ListOfFeeds.Add(pod);
        }

        public List<Feed> GetList()
        {
            return ListOfFeeds;
        }
    }
}
