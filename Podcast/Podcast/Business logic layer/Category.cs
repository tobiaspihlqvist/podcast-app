﻿using Podcast.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class Category : IListable, ISerializeable
    {
        public string Name { get; set; }
        public List<Category> categories = new List<Category>();
        Serializer serializer = new Serializer();


        public void LoadXml(string fileName) // ska flyttas till validation eller till serializer
        {
            if (File.Exists(fileName + ".xml"))
            {
                categories = serializer.GetListFromXml<List<Category>>(fileName);
            }
        } 

        public void AddInitialCategories()
        {   
            categories.Add(new Category
            {
                Name = "business"
            });
            categories.Add(new Category
            {
                Name = "Lifestyle"
            });
            serializer.SerializeXml(categories, "CList");

        }

        public void AddCategory(string input)
        {   
            Category newCat = new Category
            {
                Name = input
            };
            categories.Add(newCat);
            serializer.SerializeXml(categories, "CList");

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
                categories.Where(c => c.Name == chosenCat)
                .Select(c => { c.Name = c.Name.Replace(chosenCat, inputName); return c; })
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

