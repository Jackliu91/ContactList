using ContactListLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PhoneBook
{
    public partial class MainForm : Form
    {
        private Service service;
        private Point point;
        public MainForm()
        {
            InitializeComponent();
            treeView.ContextMenuStrip = contextMenuStrip;
            service = new Service();
            deSerialization();
            contact2Nodes();
        }
        private void deSerialization()
        {
            if (File.Exists("contact.xml"))
            {
                service.ContactList = service.Serialization.DeSerialization();
            }
        }
        private void serialiazation()
        {
            service.Serialization.Serialization(service.ContactList);
        }
        private void contact2Nodes()
        {
            TreeNode group, person;
            foreach (var g in service.ContactList.Groups)
            {
                group= new TreeNode(g.GroupName);
                foreach (var p in g.Persons)
                {
                    person = new TreeNode(p.PersonName,p.PersonPicture,p.PersonPicture);
                    person.Tag = p;
                    group.Nodes.Add(person);
                }
                treeView.Nodes.Add(group);
            }
        }
        private void addGroupMenuItem_Click(object sender, EventArgs e)
        {
            GroupForm form = new GroupForm();
            if (DialogResult.OK == form.ShowDialog())
            {
                foreach (var g in treeView.Nodes)
                {
                    if ((g as TreeNode).Text == form.getGroupName())
                    {
                        return;
                    }
                }
                treeView.Nodes.Add(form.getGroupName());
                service.AddGroup(new Group(form.getGroupName()));
            }
        }

        private void addPersonMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            PersonForm form = new PersonForm();
            if (DialogResult.OK == form.ShowDialog())
            {     
                Person person = new Person();
                person.PersonName = form.getPersonName();
                person.PersonPhone.AddNumber(form.getPersonTelephone());
                person.PersonEmail = form.getPersonEmail();
                person.PersonRemark = form.getPersonRemark();
                person.PersonPicture = form.imageIndex + 1;
                TreeNode p = new TreeNode(person.PersonName, person.PersonPicture, person.PersonPicture);
                p.Tag = person;
                if (node == null)
                {
                    foreach (var g in treeView.Nodes)
                    {
                        if ((g as TreeNode).Text == "未分组")
                        {
                            (g as TreeNode).Nodes.Add(p);
                        }
                    }
                    service.AddPerson(null, person);                    
                }
                else
                {
                    node.Nodes.Add(p);
                    service.AddPerson(node.Text, person);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitForm form = new ExitForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                serialiazation();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void treeView_MouseUp(object sender, MouseEventArgs e)
        {
            point = e.Location;
            TreeNode node = treeView.GetNodeAt(e.Location);
            if (node == null)
            {
                treeView.ContextMenuStrip.Items[0].Visible = true;
                treeView.ContextMenuStrip.Items[1].Visible = true;
                treeView.ContextMenuStrip.Items[2].Visible = false;
                treeView.ContextMenuStrip.Items[3].Visible = false;
                treeView.ContextMenuStrip.Items[4].Visible = false;
                treeView.ContextMenuStrip.Items[5].Visible = false;
            }
            else
            {
                treeView.SelectedNode = node;
                if (node.Tag == null)
                {
                    if (node.Text == "未分组")
                    {
                        treeView.ContextMenuStrip.Items[0].Visible = false;
                        treeView.ContextMenuStrip.Items[1].Visible = true;
                        treeView.ContextMenuStrip.Items[2].Visible = false;
                        treeView.ContextMenuStrip.Items[3].Visible = false;
                        treeView.ContextMenuStrip.Items[4].Visible = false;
                        treeView.ContextMenuStrip.Items[5].Visible = false;
                    }
                    else
                    {
                        treeView.ContextMenuStrip.Items[0].Visible = false;
                        treeView.ContextMenuStrip.Items[1].Visible = true;
                        treeView.ContextMenuStrip.Items[2].Visible = true;
                        treeView.ContextMenuStrip.Items[3].Visible = true;
                        treeView.ContextMenuStrip.Items[4].Visible = true;
                        treeView.ContextMenuStrip.Items[5].Visible = false;
                    }
                }
                else 
                {
                    treeView.ContextMenuStrip.Items[0].Visible = false;
                    treeView.ContextMenuStrip.Items[1].Visible = false;
                    treeView.ContextMenuStrip.Items[2].Visible = false;
                    treeView.ContextMenuStrip.Items[3].Visible = false;
                    treeView.ContextMenuStrip.Items[4].Visible = false;
                    treeView.ContextMenuStrip.Items[5].Visible = true;
                }
            }

        }

        private void delGroupMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            if (node != null)
            {
                foreach (TreeNode tn in treeView.Nodes)
                {
                    if (tn.Text == "未分组")
                    {
                        foreach (TreeNode n in node.Nodes)
                        {
                            tn.Nodes.Add(n.Clone() as TreeNode);
                            service.AddPerson(null, n.Tag as Person);
                        }
                    }
                }
                treeView.Nodes.Remove(node);
                service.RemoveGroup(new Group(node.Text));
            }
        }

        private void deleteGroupAllMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            treeView.Nodes.Remove(node);
            service.RemoveGroup(new Group(node.Text));
        }

        private void renameMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            GroupForm form = new GroupForm();
            form.setGroupName((node as TreeNode).Text);
            if (DialogResult.OK == form.ShowDialog())
            {
                service.RenameGroup(new Group((node as TreeNode).Text),form.getGroupName());
                node.Text = form.getGroupName();
            }
        }

        private void delPersonMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            service.RemovePerson(new Group(node.Parent.Text), node.Tag as Person);
            node.Parent.Nodes.Remove(node);
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = treeView.GetNodeAt(point);
            if (node != null && node.Tag is Person)
            {
                Person p = (Person)node.Tag;
                PersonForm form = new PersonForm();
                form.setPersonName(p.PersonName);
                form.setPersonTelephone(p.PersonPhone.ToString());
                form.setPersonEmail(p.PersonEmail);
                form.setPersonRemark(p.PersonRemark);
                form.imageIndex = p.PersonPicture - 1;
                if (DialogResult.OK == form.ShowDialog())
                {
                    p.PersonName = form.getPersonName();
                    p.PersonEmail = form.getPersonEmail();
                    p.PersonRemark = form.getPersonRemark();
                    p.PersonPhone.ClearNumber();
                    foreach (var phone in form.getPersonTelephone().Split(','))
                    {
                        p.PersonPhone.AddNumber(phone);
                    }
                    node.Tag = p;
                    node.Text = p.PersonName;
                    service.RemovePerson(new Group(node.Parent.Text), p);
                    service.AddPerson(node.Parent.Text, p);
                    //treeView.Invalidate();
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TreeNode result = new TreeNode();
            foreach (TreeNode tn in treeView.Nodes)
            {
                if (tn.Tag == null && tn.Text.Contains(textSerach.Text))
                {
                    result.Nodes.Add(tn.Clone() as TreeNode);
                }
                foreach (TreeNode p in tn.Nodes)
                {
                    if ((p.Tag as Person).PersonEmail.Contains(textSerach.Text) || (p.Tag as Person).PersonName.Contains(textSerach.Text) 
                        || (p.Tag as Person).PersonPhone.ToString().Contains(textSerach.Text) || (p.Tag as Person).PersonRemark.Contains(textSerach.Text))
                    {
                        result.Nodes.Add(p.Clone() as TreeNode);
                    }
                }   
            }
            treeView.Nodes.Clear();
            foreach (TreeNode tn in result.Nodes)
            {
                treeView.Nodes.Add(tn);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            contact2Nodes();
        }
    }
}