using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListLibrary
{
    public class Service
    {
        public ContactList ContactList { get; set; }
        public ISerialization Serialization { get; set; }
        public Service()
        {
            ContactList = new ContactList();
            Serialization = new XmlSerialization();
            AddGroup(new Group());
        }
        public bool AddGroup(Group group)
        {
            if (FindGroup(group.GroupName) != null)
            {
                return false;
            }
            else
            {
                ContactList.AddGroup(group);
                return true;
            }
        }
        public bool RemoveGroup(Group group)
        {
            if (FindGroup(group.GroupName) == null)
            {
                return false;
            }
            else
            {
                ContactList.RemoveGroup(group);
                return true;
            }
        }
        public void RenameGroup(Group group,String groupName)
        {
            try
            {
                FindGroup(group.GroupName).GroupName = groupName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Group FindGroup(String groupName)
        {
            return ContactList.FindGroup(groupName);
        }
        public void AddPerson(String groupName, Person person)
        {
            if (groupName == null)
            {
                FindGroup("未分组").AddPerson(person);
            }
            else
            {
                try
                {
                    FindGroup(groupName).AddPerson(person);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void RemovePerson(Group group, Person person)
        {
            try
            {
                FindGroup(group.GroupName).RemovePerson(person);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Person FindPerson(String personName)
        {
            return ContactList.FindPerson(personName);
        }

    }
}
