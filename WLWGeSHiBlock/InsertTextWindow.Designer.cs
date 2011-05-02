namespace WLWGeSHiBlock
{
    partial class InsertTextWindow
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.checkBoxCollapsible = new System.Windows.Forms.CheckBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumbering = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1043, 458);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(882, 602);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(983, 602);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "c",
            "cpp",
            "csharp",
            "java",
            "javascript",
            "php",
            "python",
            "ruby",
            "xml"});
            this.comboBoxLang.Location = new System.Drawing.Point(87, 33);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLang.TabIndex = 4;
            // 
            // checkBoxCollapsible
            // 
            this.checkBoxCollapsible.AutoSize = true;
            this.checkBoxCollapsible.Location = new System.Drawing.Point(935, 35);
            this.checkBoxCollapsible.Name = "checkBoxCollapsible";
            this.checkBoxCollapsible.Size = new System.Drawing.Size(98, 21);
            this.checkBoxCollapsible.TabIndex = 5;
            this.checkBoxCollapsible.Text = "Collapsible";
            this.checkBoxCollapsible.UseVisualStyleBackColor = true;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(847, 34);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(49, 22);
            this.textBoxStart.TabIndex = 6;
            this.textBoxStart.Text = "1";
            this.textBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(54, 13);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(1001, 22);
            this.textBoxTitle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Language";
            // 
            // comboBoxNumbering
            // 
            this.comboBoxNumbering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumbering.FormattingEnabled = true;
            this.comboBoxNumbering.Items.AddRange(new object[] {
            "Off",
            "Normal",
            "Fancy"});
            this.comboBoxNumbering.Location = new System.Drawing.Point(671, 33);
            this.comboBoxNumbering.Name = "comboBoxNumbering";
            this.comboBoxNumbering.Size = new System.Drawing.Size(85, 24);
            this.comboBoxNumbering.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Line Numbering";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStyle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxLang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxCollapsible);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStart);
            this.groupBox1.Controls.Add(this.comboBoxNumbering);
            this.groupBox1.Location = new System.Drawing.Point(12, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 88);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Block Style";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyle.DropDownWidth = 300;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "[code lang=\"...\"]...[/code]",
            "<code lang=\"...\">...</code>",
            "[language]...[/language]",
            "<language>...</language>"});
            this.comboBoxStyle.Location = new System.Drawing.Point(314, 33);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStyle.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start from";
            // 
            // InsertTextWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.richTextBox1);
            this.Name = "InsertTextWindow";
            this.Text = "GeSHi Server Block";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.CheckBox checkBoxCollapsible;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumbering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label label4;
    }
}