namespace DungeonMasterModuleSaver
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.objTree = new System.Windows.Forms.TreeView();
            this.contextMenuStripNodes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelNode = new System.Windows.Forms.Button();
            this.richTextBoxDescr = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxOther = new System.Windows.Forms.RichTextBox();
            this.labelOther = new System.Windows.Forms.Label();
            this.labelDescr = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.уничтожитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStripNodes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objTree
            // 
            this.objTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objTree.ContextMenuStrip = this.contextMenuStripNodes;
            this.objTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objTree.HideSelection = false;
            this.objTree.HotTracking = true;
            this.objTree.ImageIndex = 0;
            this.objTree.ImageList = this.imageList1;
            this.objTree.LineColor = System.Drawing.Color.IndianRed;
            this.objTree.Location = new System.Drawing.Point(0, 27);
            this.objTree.Name = "objTree";
            this.objTree.SelectedImageIndex = 0;
            this.objTree.Size = new System.Drawing.Size(329, 584);
            this.objTree.TabIndex = 0;
            this.objTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.objTree_AfterSelect);
            // 
            // contextMenuStripNodes
            // 
            this.contextMenuStripNodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУзелToolStripMenuItem,
            this.удалитьУзелToolStripMenuItem,
            this.уничтожитьToolStripMenuItem});
            this.contextMenuStripNodes.Name = "contextMenuStripNodes";
            this.contextMenuStripNodes.Size = new System.Drawing.Size(211, 70);
            // 
            // добавитьУзелToolStripMenuItem
            // 
            this.добавитьУзелToolStripMenuItem.Name = "добавитьУзелToolStripMenuItem";
            this.добавитьУзелToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьУзелToolStripMenuItem.Text = "Добавить узел...";
            this.добавитьУзелToolStripMenuItem.Click += new System.EventHandler(this.добавитьУзелToolStripMenuItem_Click);
            // 
            // удалитьУзелToolStripMenuItem
            // 
            this.удалитьУзелToolStripMenuItem.Name = "удалитьУзелToolStripMenuItem";
            this.удалитьУзелToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьУзелToolStripMenuItem.Text = "Удалить узел";
            this.удалитьУзелToolStripMenuItem.Click += new System.EventHandler(this.удалитьУзелToolStripMenuItem_Click);
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.Location = new System.Drawing.Point(12, 623);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(114, 26);
            this.buttonAddNode.TabIndex = 2;
            this.buttonAddNode.Text = "Добавить...";
            this.buttonAddNode.UseVisualStyleBackColor = true;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1297, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйФайлToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйФайлToolStripMenuItem
            // 
            this.новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
            this.новыйФайлToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.новыйФайлToolStripMenuItem.Text = "Новый файл";
            this.новыйФайлToolStripMenuItem.Click += new System.EventHandler(this.новыйФайлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonDelNode
            // 
            this.buttonDelNode.Location = new System.Drawing.Point(132, 623);
            this.buttonDelNode.Name = "buttonDelNode";
            this.buttonDelNode.Size = new System.Drawing.Size(116, 26);
            this.buttonDelNode.TabIndex = 4;
            this.buttonDelNode.Text = "Удалить";
            this.buttonDelNode.UseVisualStyleBackColor = true;
            this.buttonDelNode.Click += new System.EventHandler(this.buttonDelNode_Click);
            // 
            // richTextBoxDescr
            // 
            this.richTextBoxDescr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescr.Location = new System.Drawing.Point(359, 98);
            this.richTextBoxDescr.Name = "richTextBoxDescr";
            this.richTextBoxDescr.Size = new System.Drawing.Size(926, 445);
            this.richTextBoxDescr.TabIndex = 5;
            this.richTextBoxDescr.Text = "";
            this.richTextBoxDescr.TextChanged += new System.EventHandler(this.richTextBoxDescr_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(359, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(811, 29);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // richTextBoxOther
            // 
            this.richTextBoxOther.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxOther.Location = new System.Drawing.Point(359, 562);
            this.richTextBoxOther.Name = "richTextBoxOther";
            this.richTextBoxOther.Size = new System.Drawing.Size(926, 87);
            this.richTextBoxOther.TabIndex = 7;
            this.richTextBoxOther.Text = "";
            this.richTextBoxOther.TextChanged += new System.EventHandler(this.richTextBoxOther_TextChanged);
            // 
            // labelOther
            // 
            this.labelOther.AutoSize = true;
            this.labelOther.Location = new System.Drawing.Point(356, 546);
            this.labelOther.Name = "labelOther";
            this.labelOther.Size = new System.Drawing.Size(77, 13);
            this.labelOther.TabIndex = 8;
            this.labelOther.Text = "Последствия:";
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.Location = new System.Drawing.Point(356, 82);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(64, 13);
            this.labelDescr.TabIndex = 9;
            this.labelDescr.Text = "Описание:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(356, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя/Название:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "DMT(*.dmt)|*.dmt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "DMT(*.dmt)|*.dmt";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "domik.png");
            this.imageList1.Images.SetKeyName(1, "41f0c91ada92bb86ce41.png");
            this.imageList1.Images.SetKeyName(2, "png-transparent-computer-icons-symbol-note-icon-angle-pencil-text.png");
            // 
            // уничтожитьToolStripMenuItem
            // 
            this.уничтожитьToolStripMenuItem.Name = "уничтожитьToolStripMenuItem";
            this.уничтожитьToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.уничтожитьToolStripMenuItem.Text = "Переключить состояние";
            this.уничтожитьToolStripMenuItem.Click += new System.EventHandler(this.уничтожитьToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1176, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDescr);
            this.Controls.Add(this.labelOther);
            this.Controls.Add(this.richTextBoxOther);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.richTextBoxDescr);
            this.Controls.Add(this.buttonDelNode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.objTree);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripNodes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView objTree;
        private System.Windows.Forms.Button buttonAddNode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodes;
        private System.Windows.Forms.ToolStripMenuItem добавитьУзелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьУзелToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelNode;
        private System.Windows.Forms.RichTextBox richTextBoxDescr;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxOther;
        private System.Windows.Forms.Label labelOther;
        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem уничтожитьToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

