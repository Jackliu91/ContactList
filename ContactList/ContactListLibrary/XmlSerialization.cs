using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ContactListLibrary
{
    public class XmlSerialization : ISerialization
    {
        public ContactList DeSerialization()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ContactList));
            Stream stream = new FileStream("contact.xml", FileMode.Open,
            FileAccess.Read, FileShare.Read);
            ContactList contactList = (ContactList)formatter.Deserialize(stream);
            stream.Close();
            return contactList;
        }

        public void Serialization(ContactList contactList)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ContactList));
            Stream stream = new FileStream("contact.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, contactList);
            stream.Close();
        }
    }
}
