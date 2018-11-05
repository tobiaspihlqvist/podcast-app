using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;

namespace Podcast.Data_Access_Layer
{
    public class XmlHandler
    {
        public List<SyndicationItem> Episodes = new List<SyndicationItem>();

        public void GenerateEpisodes (string url)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed sFeed = SyndicationFeed.Load(reader);
                Episodes.Clear();
                foreach (SyndicationItem si in sFeed.Items)
                {
                    Episodes.Add(si);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldnt retrieve any podcasts.");
            }
        }
        
        public List<SyndicationItem> GetEpisodes()
        {
            return Episodes;
        }
    }
}
