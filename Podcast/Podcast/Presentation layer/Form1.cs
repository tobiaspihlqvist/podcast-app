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

using Podcast.Data_Access_Layer;

namespace Podcast
{
    public partial class Form1 : Form
    {
        private List<Category> categories { get; set; }

        private Feed feed = new Feed();
        private List<Feed> feedList { get; set; }

        private List<ListViewItem> LvList = new List<ListViewItem>();
 

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
            feed.LoadXml("fList");
            UpdateFeeds();
            FillPodCombobox();

            
            
            
            
        }



        //public void PrepareListView(List<Feed> feeds)
        //{

        //    foreach (var feed in feeds)
        //    {
        //        string[] row =
        //        {
        //            feed.Title,
        //            feed.UpdateFrequency.ToString() + "Minutes",
        //            feed.Category
        //        };
        //        ListViewItem item = new ListViewItem(row);
        //        LvList.Add(item);
        //    }
        //}

        private void UpdateFeeds()
        {
            
            lvFeed.Items.Clear();
            LvList = feed.PrepareListView();
            
            
            foreach (var lvItem in LvList)
            {
                lvFeed.Items.Add(lvItem);
            }
        }

        private void FillPodCombobox ()
        {
            cmbPodcast.Items.Clear();
            var list = feed.GetList();
            foreach(var feed in list)
            {
                cmbPodcast.Items.Add(feed.Title);
            }
            cmbPodcast.SelectedIndex = 0;
        }

        

        private void btnAddNewFeed_Click(object sender, EventArgs e)
        {
            string podName = tbTitle.Text;
            string podUrl = txtInputURL.Text;
            string podCat = cmbCategories.SelectedItem.ToString();
            string podUpdateFrequency = cmbUpdate.Text;
            string[] words = podUpdateFrequency.Split(' ');
            int minutes = int.Parse(words[0]);

            feed.AddFeed(podName, podUrl, minutes, podCat);
            UpdateFeeds();
        }

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

        private void UpdateCategory() //lambda och linq, ska egentligen vara i kategoriklassen??
        {
            string chosenCat = cmbCategories.SelectedItem.ToString();
            string inputName = txtInputCategory.Text;

            if (Validation.OnlyLetters(inputName))
            {
                categories.Where(p => p.Name == chosenCat)
                .Select(p => { p.Name = p.Name.Replace(chosenCat, inputName); return p; })
                .ToList();

                UpdateList();
                FillCategoryComboBox();
            }
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

        private void btnAddCategory_Click(object sender, EventArgs e) // lägga till nya kategorier, behövs validering
        {
            string inputName = txtInputCategory.Text;

            if (Validation.OnlyLetters(inputName))
            {
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

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            UpdateCategory();
        }
    }
}
