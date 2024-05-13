using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterModuleSaver
{
    public partial class AddForm : Form
    {
        private MainForm mainForm;
        private string nodName;
        public AddForm(string nodeName, MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            nodName = nodeName;
            this.Text = "Добавить узел в: " + nodeName;
            this.comboBoxTypes.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.textBoxNewNodeName.Text == string.Empty)
                return;
            mainForm.AddNode(nodName, this.textBoxNewNodeName.Text,
                this.comboBoxTypes.SelectedIndex);
            mainForm.UpdateForm();
            mainForm.fileIsSaved = false;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
