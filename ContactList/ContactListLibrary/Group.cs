using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListLibrary
{
    public class Group
    {
        public List<Person> Persons { get; set; }

        public String GroupName { get; set; }
        public Group()
        {
            GroupName = "未分组";
            Persons = new List<Person>();
        }
        public Group(String groupName)
        {
            GroupName = groupName;
            Persons = new List<Person>();
        }
        public void AddPerson(Person person)
        {
           Persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            Persons.Remove(person);
        }
        public void ClearPerson()
        {
            Persons.Clear();
        }
        public Person Find(String personName)
        {
            foreach (var item in Persons)
            {
                if (item.PersonName == personName)
                {
                    return item;
                }
            }
            return null;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            if (obj is Group && (obj as Group).GroupName == GroupName)
            {
                return true;
            }
            return base.Equals(obj);
        }
    }
}
