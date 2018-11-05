﻿using Podcast.Business_logic_layer;
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
        private List<SyndicationItem> FeedEpisodes = new List<SyndicationItem>();
        private string SelectedFeed { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            categories = category.GetList();
            category.AddInitialCategories();
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
            try
            {
                string podName = tbTitle.Text;
                string podUrl = txtInputURL.Text;
                Validation.ValidateFeed(podName, podUrl, feed.GetList());
                string podCat = cmbFeedCategory.SelectedItem.ToString();
                string podUpdateFrequency = cmbUpdate.Text;
                string[] words = podUpdateFrequency.Split(' ');
                int minutes = int.Parse(words[0]);
                Feed newFeed = new Feed { Title = podName, FeedUrl = podUrl, Category = podCat, UpdateFrequency = minutes };

                feed.AddToList(newFeed);
                feed.LoadXml("fList");
                //  LvList = feed.ToListViewItem();
                UpdateFeeds();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
            if (cmbCategories.Items.Count >= 0 && cmbFeedCategory.Items.Count >= 0)
            {
                cmbCategories.SelectedIndex = 0;
                cmbFeedCategory.SelectedIndex = 0;

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
            try
            {
                string inputName = txtInputCategory.Text;
                Validation.ValidateNewCategory(inputName, categories);
                category.AddCategory(inputName);

                txtInputCategory.Clear();
                UpdateList();
                FillCategoryComboBox(); // för att lägga till nya värdet
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string chosenCat = cmbCategories.SelectedItem.ToString();
                string inputName = txtInputCategory.Text;

                Validation.ChangeCat(inputName, categories) ;
                
                    category.UpdateCategory(chosenCat, inputName);

                    txtInputCategory.Clear();
                    UpdateList();
                    FillCategoryComboBox();
                
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message); }
            catch (NullReferenceException) { MessageBox.Show("You have to choose a category to change, young padawan.");  };
            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {

            try
            {
                Validation.NoChosenCat(cmbCategories.SelectedItem.ToString());
                var delete = cmbCategories.SelectedItem.ToString();

                category.DeleteCategory(delete);
                UpdateList();
                FillCategoryComboBox();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("You have to choose a category to remove, young padawan.");
            }
            

        }



        private void GenerateEpisodes(string url, int frequency)
        {
            lvEpisodes.Items.Clear();
            
            ep.intervalTimer(SelectedFeed, frequency);
            FeedEpisodes = ep.GetEpisodes();

            foreach (SyndicationItem si in FeedEpisodes)
            {
                lvEpisodes.Items.Add(si.Title.Text);
                lvEpisodes.Items.Add("\n");
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


                string chosenCat = lvCategory.SelectedItems[0].Text;
                List<Feed> fList = feed.GetList().FindAll(x => x.Category == chosenCat).ToList();
                var lvList = new List<ListViewItem>();
                foreach (Feed f in fList)
                {
                    lvList.Add(f.ToListViewItem());
                }
                UpdateFeeds(lvList);
            }
            else
            {
                UpdateFeeds();
            }
        }

        private void btnDeleteFeed_Click(object sender, EventArgs e)
        {
            string delete = cmbPodcast.SelectedItem.ToString();


            feed.DeleteFeed(delete);
            UpdateFeeds();
            lvEpisodes.Items.Clear();
            FillPodCombobox();

        }




        // Allt för UpdateFrequency

        private void fillCmbUpdate()
        {
            cmbUpdate.Items.Add("2");
            cmbUpdate.Items.Add("5");
            cmbUpdate.Items.Add("10");
            cmbUpdate.Items.Add("20");
        }



        private void lvFeed_ItemActivate(object sender, EventArgs e)
        {
            if (lvFeed.SelectedItems.Count > 0)
            {

                string selectedItem = lvFeed.SelectedItems[0].Text;
                var matchingFeed = feed.GetList().Find((f) => f.Title == selectedItem);
                SelectedFeed = matchingFeed.FeedUrl;
                int tid = matchingFeed.UpdateFrequency;


                GenerateEpisodes(SelectedFeed, tid);
            }
        }

        private void cmbPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = cmbPodcast.SelectedItem.ToString();
            foreach (var f in feed.GetList())
            {
                if (f.Title == name)
                {
                    tbTitle.Text = f.Title;
                    txtInputURL.Text = f.FeedUrl;
                    string frequency = f.UpdateFrequency.ToString();
                    cmbFeedCategory.SelectedIndex = cmbFeedCategory.Items.IndexOf(f.Category);
                    cmbUpdate.SelectedIndex = cmbUpdate.Items.IndexOf(frequency);

                    //   feed.UpdateFeed(tbTitle.Text, txtInputURL.Text,"",  "");
                    //   UpdateFeeds();
                    //   FillPodCombobox();
                    break;
                }
            }
        }

        private void btnUpdateFeed_Click(object sender, EventArgs e)
        {
            string podName = cmbPodcast.SelectedItem.ToString();
            string podUrl = txtInputURL.Text;
            if (Validation.inputIsNotNull(podName) && Validation.inputIsNotNull(podUrl))
           {
                string podCat = cmbFeedCategory.SelectedItem.ToString();
                string podUpdateFrequency = cmbUpdate.Text;
                string[] words = podUpdateFrequency.Split(' ');
                int minutes = int.Parse(words[0]);
                string changeName = tbTitle.Text; ;

                feed.UpdateFeed(podName, podUrl, minutes, podCat, changeName);
                feed.LoadXml("fList");
                UpdateFeeds();
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
}


    


