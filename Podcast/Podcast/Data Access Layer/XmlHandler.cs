using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Podcast.Data_Access_Layer
{
    public class XmlHandler
    {
        public List<SyndicationItem> Episodes = new List<SyndicationItem>();

        public void GenerateEpisodes (string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed sFeed = SyndicationFeed.Load(reader);
            Episodes.Clear();
            foreach(SyndicationItem si in sFeed.Items)
            {
                Episodes.Add(si);
            }
        }
        
        public List<SyndicationItem> GetEpisodes()
        {
            return Episodes;
        }
    }
}
