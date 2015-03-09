using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListLibrary
{   
    public class Person
    {
        public String PersonName { get; set; }
        public Phone PersonPhone { get; set; }
        public String PersonEmail { get; set; }
        public String PersonRemark { get; set; }
        //public Image PersonPicture{get;set;}
        public int PersonPicture { get; set; }

        public Person()
        {
            PersonPhone = new Phone();
        }
        public Person(String name)
        {
            PersonName = name;
            PersonPhone = new Phone();
        }
        public Person(String name, String telephone)
        {
            PersonName = name;
            PersonPhone = new Phone(telephone);
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
            if (obj is Person && (obj as Person).PersonName == PersonName)
            {
                return true;
            }
            return base.Equals(obj);
        }
    }
}
