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

        static public bool PodIsSame(string input, Feed f)
        {
            bool proceed = f.GetList().Any((x) => x.Title == input);
            if (proceed)
            {
                MessageBox.Show("You are already subscribing to a podcast with this name");
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool UrlIsSame(string input, Feed f)
        {
            
            
            bool proceed = f.GetList().Any((x) => x.FeedUrl == input);
            if (proceed)
            {
                MessageBox.Show("You are already subscribing to a podcast with this url");
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

        static public bool CategoryIsUsed(string input, List<Feed> lF)
        {
            bool proceed = lF.Any((x) => x.Category == input);
            if (proceed)
            {
                return false;
            }
            else
            {
                MessageBox.Show("You are subscribing to podcasts with this category,\n to remove this category you have to unsubscribe to these podcasts first");
                return true;
            }
        }

        static public void NoChosenCat(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("You have not chosen a category to remove, young padawan.");
            }
        }
    }
}
