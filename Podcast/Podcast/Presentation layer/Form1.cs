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
using System.Text.RegularExpressions;

namespace Podcast
{
    public partial class Form1 : Form
    {
        private List<Category> categories { get; set; }

        Feed feed = new Feed();
        Episode ep = new Episode();

        Category category = new Category();
        private List<ListViewItem> LvList { get; set; }
        private List<ListViewItem> FilteredLvList = new List<ListViewItem>();
        private string SelectedFeed { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lvEpisodes.View = View.Details;
            //lvDescription.View = View.Details;
            lvEpisodes.HeaderStyle = ColumnHeaderStyle.None;
            //lvDescription.HeaderStyle = ColumnHeaderStyle.None;
            //categories = category.GetList();
            //category.AddInitialCategories();
            UpdateList();
            //feed.LoadXml("fList");
       //     LvList = feed.ToListViewItem();
            fillCmbUpdate();
            UpdateFeeds();
            FillCategoryComboBox();
            FillPodCombobox();



            //category.LoadXml("CList"); //hmmm
        }





        private void btnAddNewFeed_Click(object sender, EventArgs e)
        {
            string podName = tbTitle.Text;
            string podUrl = txtInputURL.Text;
            if (Validation.PodIsSame(podName, feed) && Validation.UrlIsSame(podUrl, feed))
            {
                string podCat = cmbFeedCategory.SelectedItem.ToString();
                string podUpdateFrequency = cmbUpdate.Text;
                string[] words = podUpdateFrequency.Split(' ');
                int minutes = int.Parse(words[0]);
                List<SyndicationItem> podEpisodes = new List<SyndicationItem>();

                feed.AddFeed(podName, podUrl, minutes, podCat, podEpisodes);
         //       feed.LoadXml("fList");
              //  LvList = feed.ToListViewItem();
                UpdateFeeds();
            }


        }

        private void UpdateFeeds()
        {
            feed.LoadXml("fList");
            lvFeed.Items.Clear();

            foreach (var item in feed.GetList())
            {
                lvFeed.Items.Add(item.ToListViewItem());
            }
        }

        //private async Task EpisodeUpdater(string url, int interval)
        //{
        //    var taskA = feed.EpisodeUpdater(url, interval).ContinueWith(() =>
        //    {

        //    });
            
        //}

        private void UpdateFeeds(List<ListViewItem> lizt)
        {
            
            lvFeed.Items.Clear();

            foreach (var lvItem in lizt)
            {
                lvFeed.Items.Add(lvItem);
            }
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
           
        } //finns det något sätt att göra den här mer generell??




        private void UpdateList()
        {
            category.LoadXml("CList");
            categories = category.GetList();
            lvCategory.Items.Clear();

            foreach (var item in categories)
            {
                lvCategory.Items.Add(
                    item.ToListViewItem()
                );
            }
        }

        private void FillPodCombobox()
        {
            cmbPodcast.Items.Clear();
            var list = feed.GetList();
            foreach (var feed in list)
            {
                cmbPodcast.Items.Add(feed.Title);
                if (cmbPodcast.Items.Count >= 0)
                {
                    cmbPodcast.SelectedIndex = 0;
                }
            }
        }

        private bool checkifCatExists()  // måste flyttas till validation på något sätt
        {
            bool proceed = true;
            string inputName = txtInputCategory.Text;

            foreach (var c in categories)
            {
                if (c.Name == inputName)
                {
                    proceed = false;
                    MessageBox.Show("You cannot add the same category twice!");
                    break;
                }
                else
                {
                    proceed = true;
                }
            }
            return proceed;
        }

        private void btnAddCategory_Click(object sender, EventArgs e) // lägga till nya kategorier, behövs validering
        {
            string inputName = txtInputCategory.Text;


            if (Validation.OnlyLetters(inputName) && checkifCatExists())
            {
                category.AddCategory(inputName);

                txtInputCategory.Clear();
                UpdateList();
                FillCategoryComboBox(); // för att lägga till nya värdet
            }
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            string chosenCat = cmbCategories.SelectedItem.ToString();
            string inputName = txtInputCategory.Text;

            if (Validation.CatIsSame(chosenCat, inputName))
            {
                category.UpdateCategory(chosenCat, inputName);

                txtInputCategory.Clear();
                UpdateList();
                FillCategoryComboBox();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string chosenCat = cmbCategories.SelectedItem.ToString();
            category.DeleteCategory(chosenCat);
            UpdateList();
            FillCategoryComboBox();
        }

        private void lvFeed_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvFeed.SelectedItems.Count > 0)
            {
                string selectedItem = lvFeed.SelectedItems[0].Text;
                var matchingFeed = feed.GetList().Find((f) => f.Title == selectedItem);
                SelectedFeed = matchingFeed.FeedUrl;


                ep.SetEpisodes(SelectedFeed);
                var list = ep.GetEpisodes();

                foreach (SyndicationItem si in list)
                {
                    lvEpisodes.Items.Add(si.Title.Text);
                    lvEpisodes.Items.Add("--------------");
                }
            }
        }

        private void lvEpisodes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvEpisodes.SelectedItems.Count > 0) //exceptions
            {
                string selectedEpisode = lvEpisodes.SelectedItems[0].Text;
                var list = ep.GetEpisodes();

                foreach (SyndicationItem si in list)
                {
                    if (selectedEpisode == si.Title.Text)
                    {
                        string description = si.Summary.Text;
                        description = Regex.Replace(description, @"<.+?>", string.Empty);
                        rtbDescription.Text = description;
                    }
                }
            }
        }



        private void lvCategory_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lvCategory.SelectedItems.Count > 0)
            {
                // List<ListViewItem> LvList = new List<ListViewItem>();
                FilteredLvList.Clear();
                string chosenCat = lvCategory.SelectedItems[0].Text;
                var list = LvList;
                foreach (ListViewItem lvi in list)
                {
                    if (chosenCat.Equals(lvi.SubItems[2].Text))
                    {
                        FilteredLvList.Add(lvi);
                    }
                }
                UpdateFeeds(FilteredLvList);

                //var FilteredList = feed.GetList().FindAll(x => x.Category == chosenCat).ToList();

                //  var lvFilteredFeed = new ListView();
                //foreach (var item in FilteredList)
                //{

                //    string[] row =
                //    {
                //        feed.Title,
                //        feed.UpdateFrequency.ToString() + "Minutes",
                //        feed.Category
                //    };
                //    ListViewItem item = new ListViewItem(row);

                //    lvFilteredFeed.Items.Add(item);
                //}
            }
        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            string delete = cmbPodcast.SelectedItem.ToString();

            feed.DeleteFeed(delete);
            UpdateFeeds();
        }

        


        // Allt för UpdateFrequency

        private void fillCmbUpdate()
        {
            cmbUpdate.Items.Add("2");
            cmbUpdate.Items.Add("5");
            cmbUpdate.Items.Add("10");
            cmbUpdate.Items.Add("20");
        }
        /*    public async Task GenerateEpisodez(string url, double interval)

            {
                var intervalTime = cmbUpdate.SelectedItem.ToString();

                try {
                    double.TryParse(intervalTime, out double time);

                    while (true)
                    {
                        var taskA = Task.Run(() =>
                        {
        
        
                            Episodes.Clear();
                            foreach (SyndicationItem si in Episodes)
                            {
                                Episodes.Add(si);
                            }

                        });
                        await Task.Delay(TimeSpan.FromMinutes(time));
                    }
                }
                catch(FormatException e)
                {
                    MessageBox.Show(e.Message);
                }
            } */

        }
    }

    


