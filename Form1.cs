using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CodeReference
{
    public partial class Form1 : Form
    {
        //Thread th;
        public XElement xelement;
        public bool homeScreen = true;
        public int size_x = 1;
        public int size_y = 1;
        public int pos_x;
        public int pos_y;
        public string newNodeName;
        System.Collections.ArrayList textList = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();
            //this.mainRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.mainRichTextBox_LinkClicked);
        }



        public void LoadNodes()
        {
            saveNodeBtn.Visible = false;
            headerLabel.Visible = false;
            mainRichTextBox.Visible = false;
            homeScreen = true;
            xelement = XElement.Load(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            IEnumerable<XElement> nodes = xelement.Elements();
            //var names = xelement.Elements().Select(item => item.Element("nodeName").Value);
            //var parents = xelement.Elements().Select(item => item.Element("parent").Value);
            //adds the nodes
            foreach (XElement el in nodes)
            {
                SearchAndAddNode(el.Attribute("Parent").Value, el.Attribute("Name").Value);
            }
        }

        public void loadPictures()
        {

        }

        public void SearchAndAddNode(string searchKey, string newValue)
        {
            TreeNode[] list = treeView.Nodes.Find(searchKey, true);
            if (list.Length != 0)
            {
                list[0].Nodes.Add(newValue, newValue);
            }
        }

        public TreeNode FindNode(string searchKey, string parentKey)
        {
            TreeNode[] list = treeView.Nodes.Find(searchKey, true);
            foreach(TreeNode t in list)
            {
                if(t.Parent.Name == parentKey)
                {
                    return t;
                }
            }
            return null;
            /*
            if (list.Length != 0)
            {
                return list[0];
            } else return null;*/
        }

        public void DeleteNode(string nodeToDelete, string parentName)
        {
            TreeNode found = FindNode(nodeToDelete, parentName);
            var infoNode = from el in xelement.Elements("InfoNode")
                           where (string)el.Attribute("Name") == found.Name
                           select el;
            infoNode.ToList().ForEach(x => x.Remove());
            xelement.Save(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            found.Remove();
        }

        public void LoadText()
        {
            string searchName = treeView.SelectedNode.Name;
            var infoNode = from el in xelement.Elements("InfoNode")
                           where (string)el.Attribute("Name") == searchName
                           select el;
            var dataLines = from ahh in infoNode.Elements("data")
                            select ahh;
            try
            {
                mainRichTextBox.Rtf = dataLines.FirstOrDefault().Value;
            }
            catch { }
            
            /*
            foreach(XElement line in dataLines)
            {
                mainRichTextBox.AppendText(line.Value + Environment.NewLine);
            }*/
        }

        public void WriteToXML(string nodeName, string parentName)
        {
            XDocument doc = XDocument.Load(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));

            var infoNode = (from el in doc.Elements("InfoNodes").Elements("InfoNode")
                           where (string)el.Attribute("Name")==nodeName && (string)el.Attribute("Parent")==parentName
                           select el).FirstOrDefault();
            //infoNode.Remove();

            XElement root = new XElement("InfoNode");
            root.Add(new XAttribute("Name", nodeName));
            root.Add(new XAttribute("Parent", parentName));
            //root.Add(new XElement("nodeName", nodeName));
            //root.Add(new XElement("parent", parentName));
            int count = 0;
            foreach (string line in mainRichTextBox.Lines)
            {
                XElement x = new XElement("data", new XAttribute("line", count));
                x.Value = line;
                root.Add(x);
                count++;
            }
            if(infoNode == null)
            {
                doc.Element("InfoNodes").Add(root);
            }
            else infoNode.ReplaceWith(root);

            doc.Save(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            xelement = XElement.Load(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            treeView.SelectedNode.Tag = "Saved";
        }

        public void WriteToXMLRTF(string nodeName, string parentName)
        {
            XDocument doc = XDocument.Load(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));

            var infoNode = (from el in doc.Elements("InfoNodes").Elements("InfoNode")
                            where (string)el.Attribute("Name") == nodeName && (string)el.Attribute("Parent") == parentName
                            select el).FirstOrDefault();
            //infoNode.Remove();

            XElement root = new XElement("InfoNode");
            root.Add(new XAttribute("Name", nodeName));
            root.Add(new XAttribute("Parent", parentName));
            //root.Add(new XElement("nodeName", nodeName));
            //root.Add(new XElement("parent", parentName));
            int count = 0;
            string rtf = mainRichTextBox.Rtf;
            XElement x = new XElement("data", new XAttribute("line", count));
            x.Value = rtf;
            root.Add(x);

            if (infoNode == null)
            {
                doc.Element("InfoNodes").Add(root);
            }
            else infoNode.ReplaceWith(root);

            doc.Save(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            xelement = XElement.Load(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "InfoText.xml"));
            treeView.SelectedNode.Tag = "Saved";
        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "homeNode":
                    saveNodeBtn.Visible = false;
                    headerLabel.Visible = false;
                    mainRichTextBox.Visible = false;
                    homeScreen = true;
                    /*for (int i = 0; i < 100; i++)
                    {
                        size_x++;
                        size_y++;
                        //canvas.Refresh();
                        //System.Sleep();
                    }*/
                    break;

                default:
                    homeScreen = false;
                    saveNodeBtn.Visible = true;
                    mainRichTextBox.Visible = true;
                    mainRichTextBox.Text = "";
                    headerLabel.Visible = true;
                    headerLabel.Text = e.Node.Text;
                    LoadText();
                    
                    break;

                    //size_x = 1;
                    //size_y = 1;
                    //break;
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainRichTextBox.AcceptsTab = true;
            //Task loadTextTask = Task.Factory.StartNew(() => loadText());
            LoadNodes();
            Task loadPicturesTask = Task.Factory.StartNew(() => loadPictures());
            //Task draw =bkoch   Task.Factory.StartNew(() => drawTask());
        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            if(treeView.SelectedNode.Name == "homeNode")
            {
                MessageBox.Show("Cannot add node to homepage");
            }else
            {
                newNodeName = AddNodePrompt.ShowDialog("Choose a Name", "Node Name");
                SearchAndAddNode(treeView.SelectedNode.Name, newNodeName);
                treeView.SelectedNode = FindNode(newNodeName, treeView.SelectedNode.Name);
            }
        }

        private void saveNodeBtn_Click(object sender, EventArgs e)
        {
            string name = treeView.SelectedNode.Name;
            string parent = treeView.SelectedNode.Parent.Name;
            //string bodytxt = mainTextBox.Text;
            WriteToXMLRTF(name, parent);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeleteNode(treeView.SelectedNode.Name, treeView.SelectedNode.Parent.Name);
        }

        private void formatBtn1_Click(object sender, EventArgs e)
        {
            var style = mainRichTextBox.SelectionFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            if (mainRichTextBox.SelectionFont.Underline)
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.SelectionFont, style|FontStyle.Underline);
            }
            else
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.SelectionFont, style);
            }
        }


        private void FontSizeCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Font temp = new Font(mainRichTextBox.SelectionFont, mainRichTextBox.SelectionFont.Style);
            try
            {
                mainRichTextBox.SelectionFont = new Font(temp.FontFamily, float.Parse(FontSizeCombo.SelectedItem.ToString()), temp.Style);
            }
            catch (Exception ehh)
            {
                MessageBox.Show(ehh.ToString());
            }
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            //show color picker?
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                mainRichTextBox.SelectionColor = colorPicker.Color;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            mainRichTextBox.Size = new Size(control.Size.Width-195, control.Size.Height - 115);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            var style = mainRichTextBox.SelectionFont.Underline ? FontStyle.Regular : FontStyle.Underline;
            if(mainRichTextBox.SelectionFont.Bold)
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.SelectionFont, style|FontStyle.Bold);
            }
            else
            {
                mainRichTextBox.SelectionFont = new Font(mainRichTextBox.SelectionFont, style);
            }
            

        }

        public System.Diagnostics.Process p = new System.Diagnostics.Process();

        private void mainRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            string link = e.LinkText.Substring(e.LinkText.IndexOf('#')+1);
            try
            {
                p = System.Diagnostics.Process.Start("chrome.exe", link);
            }
            catch
            {
                p = System.Diagnostics.Process.Start("IExplore.exe", link);
            }

            //StopWebProcess();
        }

        public void StopWebProcess()
        {
            p.Kill();
        }

        private void addLinkBtn_Click(object sender, EventArgs e)
        {
            string link = AddNodePrompt.ShowDialog("Enter a link", "Web Address");
            if(link != string.Empty)
            {
                mainRichTextBox.InsertLink(mainRichTextBox.SelectedText, link, mainRichTextBox.SelectionStart);
            }
        }

        private void getRTFBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mainRichTextBox.SelectedRtf);
        }
    }

    public class InfoNode
    {
        public string nodeName { get; set; }
        public string parentNode { get; set; }
        public string data { get; set; }
    }

    public static class AddNodePrompt
    {
        public static string ShowDialog(string caption, string text)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 140,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 40, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            //textBox.KeyDown += new KeyEventHandler(tb_KeyDown);
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
