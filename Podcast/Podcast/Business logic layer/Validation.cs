using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
   public class Validation
    {
       

        static public bool OnlyLetters(string input) // måste använda Validation.OnlyLetters samt textrutan man ska kontrollera för att metoden ska fungera
        {
            
            if (!Regex.IsMatch(input, @"^[a-zA-Z]+$"))

            {
                MessageBox.Show("Felaktig inmatning \n" + "Var vänlig använd endast bokstäver ");

                return false;
            }
            else
            {

                return true;
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
    }
}
