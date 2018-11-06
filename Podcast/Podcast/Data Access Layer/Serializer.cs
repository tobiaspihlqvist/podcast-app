using System.IO;
using System.Xml.Serialization;

namespace Podcast.Data_Access_Layer
{
    public class Serializer
    {

        public void SerializeXml<T>(T obj, string fileName)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(fileName+".xml"))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public T GetListFromXml<T>(string fileName) //deserilaize ska döpas om
        {
            T deserializedList;    
                var serializer = new XmlSerializer(typeof(T));
                using (var reader = new StreamReader(fileName+".xml"))
                {
                    deserializedList = (T)serializer.Deserialize(reader);

                }
            
                return deserializedList;
            
        }  
    }
}
