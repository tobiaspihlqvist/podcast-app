using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
   public static class Validation
    {
       

        static public bool OnlyLetters(string input) // måste använda Validation.OnlyLetters samt textrutan man ska kontrollera för att metoden ska fungera
        {
            
            if (!Regex.IsMatch(input, @"^[a-zA-Z]+$"))

            {
                MessageBox.Show("Illegal input \n" + "Please type in letters between a-z");

                return false;
            }
            else
            {

                return true;
            }
        }
        static public bool inputIsNotNull(string input)
        {
            if (!String.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please insert some text...");
                return false;
            }
        }

        static public bool CatIsSame(string input, string comparison) // används i btnChangeCat
        {
            if (input.Equals(comparison))
            {
                MessageBox.Show("You cannot add the same category twice!");

                return false;
            }
            else
            {
                return true;
            }
        }

      

        

        static public bool XmlExists(string input)
        {
            if(File.Exists(input + ".xml"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        static public void NoChosenCat(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("You have not chosen a category to remove, young padawan.");
            }
        }
        static public void ValidateNewCategory(string newCategory, List<Feed> lF)
        {
            if (string.IsNullOrEmpty(newCategory))
            {
                throw new ArgumentException("Input cannot be empty.");
            }
            if (!Regex.IsMatch(newCategory, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Illegal characters. \n Title please use A-Z or a-z.");
            }
            bool proceed = lF.Any((x) => x.Category == newCategory);
            if (proceed)
            {
                throw new ArgumentException("You cannot add the same category twice");
            }
        }

        static public void ValidateFeed(string title, string url, List<Feed> f)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL cannot be empty.");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }
            if (!Regex.IsMatch(title, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Illegal characters. \n Title please use A-Z or a-z.");
            }
            bool isUrl = Uri.IsWellFormedUriString(url, UriKind.Absolute);
            if (!isUrl)
            {
                throw new ArgumentException("The URL is not a valid one.");
            }
            bool urlExists = f.Any((x) => x.FeedUrl == url);
            if (urlExists)
            {
                throw new ArgumentException("You are already subscribing to a podcast with this url.");
            }
            bool titleExists = f.Any((x) => x.Title == title);
            if(titleExists)
            {
                throw new ArgumentException("You are already subscribing to a podcast with this name.");
            }
        }
    }
}
