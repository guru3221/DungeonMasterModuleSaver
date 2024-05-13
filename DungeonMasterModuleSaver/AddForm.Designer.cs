namespace DungeonMasterModuleSaver
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNewNodeName = new System.Windows.Forms.TextBox();
            this.labelAddNodeName = new System.Windows.Forms.Label();
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.labelSelectNodeType = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewNodeName
            // 
            this.textBoxNewNodeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewNodeName.Location = new System.Drawing.Point(12, 33);
            this.textBoxNewNodeName.Name = "textBoxNewNodeName";
            this.textBoxNewNodeName.Size = new System.Drawing.Size(325, 29);
            this.textBoxNewNodeName.TabIndex = 0;
            // 
            // labelAddNodeName
            // 
            this.labelAddNodeName.AutoSize = true;
            this.labelAddNodeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddNodeName.Location = new System.Drawing.Point(12, 9);
            this.labelAddNodeName.Name = "labelAddNodeName";
            this.labelAddNodeName.Size = new System.Drawing.Size(81, 21);
            this.labelAddNodeName.TabIndex = 1;
            this.labelAddNodeName.Text = "Название:";
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Items.AddRange(new object[] {
            "Локация",
            "Персонаж/существо",
            "Заметка"});
            this.comboBoxTypes.Location = new System.Drawing.Point(12, 89);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(325, 29);
            this.comboBoxTypes.TabIndex = 2;
            // 
            // labelSelectNodeType
            // 
            this.labelSelectNodeType.AutoSize = true;
            this.labelSelectNodeType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectNodeType.Location = new System.Drawing.Point(12, 65);
            this.labelSelectNodeType.Name = "labelSelectNodeType";
            this.labelSelectNodeType.Size = new System.Drawing.Size(39, 21);
            this.labelSelectNodeType.TabIndex = 3;
            this.labelSelectNodeType.Text = "Тип:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(262, 128);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(181, 128);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 163);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSelectNodeType);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.labelAddNodeName);
            this.Controls.Add(this.textBoxNewNodeName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewNodeName;
        private System.Windows.Forms.Label labelAddNodeName;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Label labelSelectNodeType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
    }
}