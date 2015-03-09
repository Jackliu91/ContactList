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
    public partial class PersonForm : Form
    {
        public int imageIndex { get; set; }
        public PersonForm()
        {
            InitializeComponent();
            Random random = new Random();
            imageIndex = random.Next(1,9);
            pictureBox.Image = imageList.Images[imageIndex];
        }

        private void PersonForm_Activated(object sender, EventArgs e)
        {
            nameText.Focus();
            pictureBox.Image = imageList.Images[imageIndex];
        }
        public String getPersonName()
        {
            return nameText.Text;
        }
        public void setPersonName(String personName)
        {
            nameText.Text=personName;
        }
        public String getPersonTelephone()
        {
            return telephoneText.Text;
        }
        public void setPersonTelephone(String personTelephone)
        {
            telephoneText.Text = personTelephone;
        }
        public String getPersonEmail()
        {
            return emailText.Text;
        }
        public void setPersonEmail(String personEmail)
        {
            emailText.Text = personEmail;
        }
        public String getPersonRemark()
        {
            return remarkText.Text;
        }
        public void setPersonRemark(String personRemark)
        {
            remarkText.Text = personRemark;
        }
        public Image getPersonPicture()
        {
            return pictureBox.Image;
        }
    }
}
