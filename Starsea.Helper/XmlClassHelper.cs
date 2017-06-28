
using System.IO;
using System.Text;
using System.Xml.Serialization;


namespace Starsea.Helper
{
    public static class XmlClassHelper
    {
        public static T LoadXML2Class<T>(string path) where T : class
        {
            T config = null;
            var xmlser = new XmlSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                config = xmlser.Deserialize(fs) as T;
            }
            return config;
        }
        public static void SaveClass2Xml<T>(T source, string savePath)
        {
            var xmlser = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
            {
                xmlser.Serialize(fs, source);
            }
        }


        public static T LoadXMLString2Class<T>(string xmlstring) where T : class
        {

            byte[] array = Encoding.UTF8.GetBytes(xmlstring);
            MemoryStream stream = new MemoryStream(array);
            T config = null;
            var xmlser = new XmlSerializer(typeof(T));
            config = xmlser.Deserialize(stream) as T;

            return config;
        }
        public static string SaveClass2XmlStirng<T>(T source)
        {
            var xmlser = new XmlSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            xmlser.Serialize(stream, source);

            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();

        }


        //public static T Copy<T>(T source) where T:class 
        //{
        //    var xmlser = new XmlSerializer(typeof(T));
        //    T config = null;
        //    using (var fs = new MemoryStream())
        //    {
        //        xmlser.Serialize(fs, source);
        //        config = xmlser.Deserialize(fs) as T;
        //    }
        //    return config;
        //}
    }
}
