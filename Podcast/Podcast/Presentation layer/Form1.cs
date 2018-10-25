using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.ServiceModel.Description;
using System.ServiceModel;
using Podcast.Business_logic_layer;

namespace Podcast
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbUpdate.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
        }

        private void lblFeedFrequency_Click(object sender, EventArgs e)
        {
            
        }

        public void PrintFeeds()
        {
            var list = FeedList.ReturnList();
            foreach (var feed in list)
            {
                string[] row =
                {
                    feed.Title,
                    feed.UpdateFrequency.ToString() + "Minutes",
                    feed.Category
                };

                ListViewItem item = new ListViewItem(row);

                lvFeed.Items.Add(item);

            }
        }

        private void btnAddNewFeed_Click(object sender, EventArgs e)
        {
            string podUrl = tbUrl.Text;

            XmlReader reader = XmlReader.Create(podUrl);
            SyndicationFeed sFeed = SyndicationFeed.Load(reader);

            
            string podTitle = sFeed.Title.Text;
            string podCat = cbCategory.Text;
            string podUpdateFrequency = cbUpdate.Text;
            string[] words = podUpdateFrequency.Split(' ');
            int minutes = int.Parse(words[0]);

            var listOfPods = new FeedList();
            var pod = new Feed { Title = podTitle, Category = podCat, FeedUrl = podUrl, UpdateFrequency = minutes };

            FeedList.AddFeed(listOfPods, pod);

            PrintFeeds();
        }
    }
}
