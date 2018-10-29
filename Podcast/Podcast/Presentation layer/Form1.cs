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

        Feed feed = new Feed();

        Category category = new Category();
        private List<ListViewItem> LvList { get; set; }
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             categories = category.categories;
            category.AddInitialCategories();
            UpdateList();
            FillCategoryComboBox();
            
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
            fl.LoadFromXml();
            LvList = fl.GetListItems();
            

                foreach (var lvItem in LvList)
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
            cmbFeedCategory.SelectedIndex = 0;
            cmbCategories.SelectedIndex = 0;
        } //finns det något sätt att göra den här mer generell??

       
        

        private void UpdateList()
        {
            var list = categories;
            lvCategory.Items.Clear();

            foreach (var item in list)
            {
                lvCategory.Items.Add(
                    item.ToListViewItem()
                );
            }
        }



        private void btnAddCategory_Click(object sender, EventArgs e) // lägga till nya kategorier, behövs validering
        {
            string inputName = txtInputCategory.Text;

            if (Validation.OnlyLetters(inputName))
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

            category.UpdateCategory(chosenCat, inputName);

            txtInputCategory.Clear();
            UpdateList();
            FillCategoryComboBox();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string chosenCat = cmbCategories.SelectedItem.ToString();
            category.DeleteCategory(chosenCat);
            UpdateList();
            FillCategoryComboBox();
        }
    }
}
