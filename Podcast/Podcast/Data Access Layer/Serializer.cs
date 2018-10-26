using Podcast.Business_logic_layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Podcast.Data_Access_Layer
{
    public class Serializer
    {
        public void SerializeXml(FeedList list)
        {
            var feedList = list;

            var serializer = new XmlSerializer(typeof(FeedList));
            using (var writer = new StreamWriter("feeds.xml"))
            {
                serializer.Serialize(writer, feedList);
            }
        }

        public void DeSerialize()
        {
            FeedList listOfFeeds;
            var serializer = new XmlSerializer(typeof(FeedList));
            using (var reader = new StreamReader("feeds.xml"))
            {
                listOfFeeds = serializer.Deserialize(reader) as FeedList;
            }
            
        }


    }
}
