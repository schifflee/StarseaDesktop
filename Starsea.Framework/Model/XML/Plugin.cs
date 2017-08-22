using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Starsea.Framework.Model.XML
{
    [Serializable]
    public class Plugin
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }

        public UI UI { get; set; }

        public Components Components { get; set; }

        public Config Config { get; set; }

        public Resource Resource { get; set; }

    }


    public class UI
    {
        public Ribbon Ribbon { get; set; }
    }

    public class Components
    {
        [XmlElement("Component")]
        public List<Component> ComponentList { get; set; }
    }

    public class Component
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("site")]
        public string Site { get; set; }
        [XmlAttribute("text")]
        public string Text { get; set; }
        [XmlAttribute("dll")]
        public string Dll { get; set; }
        [XmlAttribute("class")]
        public string Class { get; set; }
        [XmlAttribute("func")]
        public string Func { get; set; }


    }


    public class Config
    {
        [XmlElement("Key")]
        public List<Key> KeyList { get; set; }
    }

    public class Key
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }


    }

    public class Resource
    {
        [XmlElement("File")]
        public List<File> FileList { get; set; }
    }

    public class File
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("desc")]
        public string Des { get; set; }


        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("path")]
        public string Path { get; set; }


    }

}
