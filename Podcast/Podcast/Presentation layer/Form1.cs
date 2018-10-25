using Podcast.Business_logic_layer;
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
        private List<Category> categories { get; set; }
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categories = new List<Category> {
                new Category{
                    Name = "Comedy"
        },
                new Category{
                    Name = "Lifestyle"
                },
                new Category
                {
                    Name = "Business"
                }
            };

            UpdateList();
            FillCategoryComboBox();
            
        }

        private void UpdateList()
        {
            lvCategory.Items.Clear();

            foreach (var cat in categories)
            {
                lvCategory.Items.Add(
                    cat.ToListViewItem()
                );
            }
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
        private void FillCategoryComboBox() // för att fylla kategori comboboxarna
        {
            cmbFeedCategory.Items.Clear();
            cmbCategories.Items.Clear();
            foreach (var item in categories)
            {
                cmbCategories.Items.Add(item.Name);
                cmbFeedCategory.Items.Add(item.Name);
            }
            cmbFeedCategory.SelectedIndex = 0;
            cmbCategories.SelectedIndex = 0;
        } //finns det något sätt att göra den här mer generell??
        
        private void UpdateCategory()
        {
              
        }

        private void btnAddCategory_Click(object sender, EventArgs e) // lägga till nya kategorier, behövs validering
        {
            string inputName = txtInputCategory.Text;

            Category newCat = new Category
            {
                Name = inputName
            };
            categories.Add(newCat);

            txtInputCategory.Clear();

            UpdateList();
            FillCategoryComboBox(); // för att lägga till nya värdet

        }
    }
}
