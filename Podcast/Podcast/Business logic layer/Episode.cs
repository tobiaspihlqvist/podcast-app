﻿using System;
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

    public class Episode
    {
        XmlHandler handler = new XmlHandler();
        public List<SyndicationItem> PodEpisodes = new List<SyndicationItem>();

        public List<SyndicationItem> GetEpisodes()
        {
            return PodEpisodes;
        }

        public async Task Hora(string feedUrl, int tid)
        {
            string url = feedUrl;
            double intervalTime = Convert.ToDouble(tid);
            while (true)
            {
                await Task.Run(() =>
                 {
                     SetEpisodes(feedUrl);
                     
                     MessageBox.Show("kukjävel");
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
