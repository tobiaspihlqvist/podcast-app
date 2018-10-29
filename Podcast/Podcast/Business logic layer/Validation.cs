using System;
using System.Collections.Generic;
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
                MessageBox.Show("Felaktig inmatning \n" + "Var vänlig använd endast bokstäver ");

                return false;
            }
            else
            {

                return true;
            }
        }
        

        static public bool CatIsSame(string input, string comparison)
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
    }
}
