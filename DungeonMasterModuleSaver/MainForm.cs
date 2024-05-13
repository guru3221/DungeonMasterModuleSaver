using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonMasterModuleSaver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mTree = new DMTree(new DMNoteNode("Корень"));
            mNode = null;
            fileIsSaved = false;
            pathToFile = string.Empty;
        }
        private DMTree mTree;
        private DMNode mNode;
        public string pathToFile;
        public bool fileIsSaved;
        public void UpdateForm()
        {
            UpdateTree();
            UpdateFormName();
            ShowSelectedNodeMenu();
        }
        public void UpdateTree()
        {
            this.objTree.Nodes.Clear();
            this.objTree.Nodes.Add(mTree.GetTreeNode());
        }
        public void UpdateFormName()
        {
            this.Text = "Редактор модулей - " + (pathToFile == string.Empty ? "(новый файл)" : pathToFile) + (fileIsSaved ? "" : "*");
        }
        public void ShowSelectedNodeMenu()
        {
            var selectedNode = this.objTree.SelectedNode;
            if (selectedNode == null)
            {
                mNode = null;
                this.textBoxName.Text = string.Empty;
                this.richTextBoxDescr.Text = string.Empty;
                this.richTextBoxOther.Text = string.Empty;
                return;
            }
            mNode = this.mTree.Search(selectedNode.Text);
                
            this.textBoxName.Text = mNode.Name;
            this.richTextBoxDescr.Text = mNode.Description;
            this.richTextBoxOther.Text = mNode.Other;
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
        public void AddNode(string nameTo, string nameWhat, int type)
        {
            DMNode node;
            switch(type)
            {
                case 0:
                    node = new DMLocationNode(nameWhat);
                    break;
                case 1:
                    node = new DMCreatureNode(nameWhat);
                    break;
                case 2:
                default:
                    node = new DMNoteNode(nameWhat);
                    break;
            }
            mTree.AddNode(nameTo, node);
        }
        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            if (mNode == null) return;
            var addForm = new AddForm(mNode.Name, this);
            addForm.Show();
        }

        private void buttonDelNode_Click(object sender, EventArgs e)
        {
            var selectedNode = this.objTree.SelectedNode;
            if (selectedNode == null) return;
            this.mTree.RemoveNode(selectedNode.Text);
            this.fileIsSaved = false;
            this.UpdateForm();
        }

        private void добавитьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.buttonAddNode_Click(sender, e);
        }

        private void удалитьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.buttonDelNode_Click(sender, e);
        }

        private void objTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowSelectedNodeMenu();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if(mNode == null)
                return;
            this.fileIsSaved = false;
            mTree.ChangeNodeName(mNode.Name, textBoxName.Text);
            //UpdateTree();
        }

        private void richTextBoxDescr_TextChanged(object sender, EventArgs e)
        {
            if (mNode == null)
                return;
            this.fileIsSaved = false;
            mNode.Description = richTextBoxDescr.Text;
        }

        private void richTextBoxOther_TextChanged(object sender, EventArgs e)
        {
            if (mNode == null)
                return;
            this.fileIsSaved = false;
            mNode.Other = richTextBoxOther.Text;
        }

        private void новыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mTree = new DMTree(new DMNoteNode("Корень"));
            this.fileIsSaved = false;
            this.pathToFile = string.Empty;
            UpdateForm();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.pathToFile = openFileDialog1.FileName;

            using (FileStream fstream = new FileStream(this.pathToFile, FileMode.Open))
            {
                var binarySr = new BinaryFormatter();
                this.mTree = (DMTree)binarySr.Deserialize(fstream);
                this.fileIsSaved = true;
            }
            this.UpdateForm();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pathToFile == string.Empty)
                сохранитьКакToolStripMenuItem_Click(sender, e);
            else
            {
                using (FileStream fstream = new FileStream(this.pathToFile, FileMode.Create))
                {
                    var binarySr = new BinaryFormatter();
                    binarySr.Serialize(fstream, mTree);
                    this.fileIsSaved = true;
                }
            }
            UpdateFormName();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.pathToFile = saveFileDialog1.FileName;
            
            using (FileStream fstream = new FileStream(this.pathToFile, FileMode.Create))
            {
                var binarySr = new BinaryFormatter();
                binarySr.Serialize(fstream, mTree);
                this.fileIsSaved = true;
            }
            UpdateFormName();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateFormName();
            this.Close();
        }

        private void уничтожитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mNode == null)
                return;
            mNode.IsDead = !mNode.IsDead;
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UpdateForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.fileIsSaved)
            {
                var dr =
                    MessageBox.Show("Хотите сохранить файл перед выходом из приложения?", "Выход", MessageBoxButtons.YesNoCancel);
                if (dr
                    == DialogResult.Yes)
                {
                    сохранитьToolStripMenuItem_Click(sender, e);
                }
                else if (dr
                    == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
