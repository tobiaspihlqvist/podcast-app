﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Podcast.Business_logic_layer
{
    public class Validation
    {


        static public void OnlyLetters(string input) 
        {

            if (!Regex.IsMatch(input, @"^[a-zA-Z_ ]*$"))
            {
                throw new ArgumentException("Illegal characters. \n Title please use A-Z or a-z.");
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

        static public void ChangeCat(string input, List<Category> c)
        {
            bool catExists = c.Any((x) => x.Name == input);
            if (catExists)
            {
                throw new ArgumentException("You haven't changed the name, please enter a new name.");
            }
        }

        static public bool XmlExists(string input)
        {
            if (File.Exists(input + ".xml"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void nothingChosenInCombobox(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new NullReferenceException("You have not chosen anything to remove, young padawan.");
            }
        }
        static public void ValidateNewCategory(string newCategory, List<Category> c)
        {
            if (string.IsNullOrEmpty(newCategory))
            {
                throw new ArgumentException("Input cannot be empty.");
            }
            if (!Regex.IsMatch(newCategory, @"^[a-zA-Z_ ]*$"))
            {
                throw new ArgumentException("Illegal characters. \n Title please use A-Z or a-z.");
            }
            bool proceed = c.Any((x) => x.Name == newCategory);
            if (proceed)
            {
                throw new ArgumentException("You cannot add the same category twice");
            }
        }

        static public void ValidateNewFeed(string title, string url, List<Feed> f, string category)
        {


            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL cannot be empty.");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be empty.");
            }
            if (!Regex.IsMatch(title, @"^[a-zA-Z_ ]*$"))
            {
                throw new ArgumentException("Illegal characters. \n Title please use A-Z or a-z.");

            }
            bool isUrl = Uri.IsWellFormedUriString(url, UriKind.Absolute);
            if (!isUrl)
            {
                throw new ArgumentException("The URL is not a valid one.");
            }
            if (url.Contains("feed") || url.EndsWith("xml") || url.Contains("rss"))
            {

            }
            else
            {
                throw new ArgumentException("It seems that the URL that has been provided is not a URL for a podcast.");

            }
            bool urlExists = f.Any((x) => x.FeedUrl == url);
            if (urlExists)
            {
                throw new ArgumentException("You are already subscribing to a podcast with this url.");
            }
            bool titleExists = f.Any((x) => x.Title == title);
            if (titleExists)
            {
                throw new ArgumentException("You are already subscribing to a podcast with this name.");
            }
            if (string.IsNullOrEmpty(category)){
                throw new NullReferenceException("You have to choose a category to add to the feed");
            }
        }
    }
}

    
