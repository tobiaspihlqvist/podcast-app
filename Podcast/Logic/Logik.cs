﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Windows.Forms;




namespace Logic
{
    public class Logik
    {
        Feed feed = new Feed();
        
        public void AddToFeed(string _url, int _updateFreq, string _category)
        {
            string podUrl = _url;
            int updateFreq = _updateFreq;
            string category = _category;

            feed.AddPodToFeed(category, updateFreq, podUrl);
        }

        

        
    }

    
}
