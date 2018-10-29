using Podcast.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class Category : IListable
    {
        public string Name { get; set; }
        public List<Category> categories = new List<Category>();
        Serializer serializer = new Serializer();




        public void AddInitialCategories()
        {   
            if (File.Exists("CList" + ".xml"))
            {
                categories = serializer.GetListFromXml<List<Feed>>();
            }

            else
            {
                serializer.SerializeXml(categories, "CList");

            }
            categories.Add(new Category
            {
                Name = "business"
            });
            categories.Add(new Category
            {
                Name = "Lifestyle"
            });
            return;
        }

        public void AddCategory(string input)
        {
            Category newCat = new Category
            {
                Name = input
            };
            categories.Add(newCat);
            return;
        }

        public void DeleteCategory(string input)
        {
            var catToRemove = categories.Single(p => p.Name == input);
                categories.Remove(catToRemove);
        }



        public void UpdateCategory(string chosenCat, string inputName)
        {
            if (Validation.OnlyLetters(inputName))
            {
                categories.Where(p => p.Name == chosenCat)
                .Select(p => { p.Name = p.Name.Replace(chosenCat, inputName); return p; })
                .ToList();
            }
        }
         

        protected virtual List<string> PrepareListViewItem()
        {
            return new List<string> {Name};
        } 

        public virtual ListViewItem ToListViewItem()
        {
            return new ListViewItem(PrepareListViewItem().ToArray());
        }

     
    }
}

