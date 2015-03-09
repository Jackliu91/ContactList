using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }
        public String getGroupName()
        {
            return groupName.Text;
        }
        public void setGroupName(String name)
        {
            groupName.Text=name;
        }
    }
}
