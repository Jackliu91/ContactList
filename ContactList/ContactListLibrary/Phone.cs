using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListLibrary
{   [Serializable]
    public class Phone
    {
        public List<String> Phones { get; set; }
        public Phone()
        {
            Phones = new List<string>();
        }
        public Phone(String phone)
        {
            Phones = new List<string>();
            Phones.Add(phone);
        }
        public void AddNumber(String phone)
        {
            Phones.Add(phone);
        }
        public void RemoveNumber(String phone)
        {
            Phones.Remove(phone);
        }
        public void ClearNumber()
        {
            Phones.Clear();
        }
        override public String ToString()
        {
            if (Phones.Count == 0)
                return "";
            String result = "";
            foreach (var phone in Phones)
            {
                result += phone;
                result += ",";
            }
            return result;
        }
    }
}
