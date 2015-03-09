using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListLibrary
{
    public interface ISerialization
    {
        void Serialization(ContactList contactList);
        ContactList DeSerialization();
    }
}
