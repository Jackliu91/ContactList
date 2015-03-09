using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ContactListLibrary
{
    public class ContactList
    {
        public List<Group> Groups { get; set; }
        public ContactList()
        {
            Groups = new List<Group>();
        }
        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }
        public void RemoveGroup(Group group)
        {
            Groups.Remove(group);
        }
        public void ClearGroup()
        {
           Groups.Clear();
        }
        public Group FindGroup(String groupName)
        {
            foreach (var item in Groups)
            {
                if (item.GroupName == groupName)
                {
                    return item;
                }
            }
            return null;
        }
        public Person FindPerson(String personName)
        {
            foreach (var g in Groups)
            {
                Person person = g.Find(personName);
                if ( person != null)
                {
                    return person;
                }
            }
            return null;
        }
    }  
}
