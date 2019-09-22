using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;

namespace AccountingSoftware
{


        [XmlRoot("Users")]
        public class UserDictionary<TKey, TValue> : Dictionary<TKey, TValue>,
                                              IXmlSerializable
        {
            public XmlSchema GetSchema() { return null; }
            public void ReadXml(XmlReader reader)
            {
                if (reader.IsEmptyElement) { return; }
                reader.Read();
                while (reader.NodeType != XmlNodeType.EndElement)
                {
                    object key = reader.GetAttribute("Username");
                    object value = reader.GetAttribute("Password");
                    this.Add((TKey)key, (TValue)value);
                    reader.Read();
                }
            }
            public void WriteXml(XmlWriter writer)
            {
                foreach (var key in this.Keys)
                {
                    writer.WriteStartElement("Users");
                    writer.WriteAttributeString("Username", this[key].ToString());
                    writer.WriteAttributeString("Password", this[key].ToString());
                    writer.WriteAttributeString("Salt", this[key].ToString());
                    writer.WriteEndElement();
                }
            }
        }
}
