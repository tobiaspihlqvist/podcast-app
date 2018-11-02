using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using Podcast.Data_Access_Layer;

namespace Podcast.Business_logic_layer
{

    public class Episode : Feed
    {
        XmlHandler handler = new XmlHandler();
        
        private List<Episode> Episodes = new List<Episode>();
        private string Title { get; set; }
        private string FeedUrl { get; set; }
        private int UpdateFrequency { get; set; }
        private List<SyndicationItem> PodEpisodes { get; set; }

        public void AddEpisode(string title, string url, int upFreq)
        {
            var newEp = new Episode { Title = title, FeedUrl = url, UpdateFrequency = upFreq, PodEpisodes = new List<SyndicationItem>() };
            Episodes.Add(newEp);

        }
        public List<SyndicationItem> GetEpisodes()
        {
            return PodEpisodes;
        }

        public async Task CheckForEpisodes(string feedUrl, int tid)
        {
            string url = feedUrl;
            double intervalTime = Convert.ToDouble(tid);
            while (true)
            {
                Task.Run(() =>
                {

                    XmlReader reader = XmlReader.Create(url);
                    SyndicationFeed sFeed = SyndicationFeed.Load(reader);


                });
                await Task.Delay(TimeSpan.FromMinutes(intervalTime));
            }

        }

        

        public void SetEpisodes(string feedUrl)
        {
              handler.GenerateEpisodes(feedUrl);
              PodEpisodes = handler.GetEpisodes();
                 
        }
    }
}
