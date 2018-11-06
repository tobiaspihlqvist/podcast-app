using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using Podcast.Data_Access_Layer;

namespace Podcast.Business_logic_layer
{

    public class Episode
    {
        private XmlHandler handler = new XmlHandler();
        private List<SyndicationItem> PodEpisodes = new List<SyndicationItem>();

        public List<SyndicationItem> GetEpisodes()
        {
            return PodEpisodes;
        }

        public async Task intervalTimer(string feedUrl, int time)
        {
            string url = feedUrl;
            double intervalTime = Convert.ToDouble(time);
            while (true)
            {
                SetEpisodes(url);
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
