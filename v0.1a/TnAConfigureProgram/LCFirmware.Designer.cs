namespace TnAConfigureProgram
{
    partial class LCFirmware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCFirmware));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxLCIP = new System.Windows.Forms.TextBox();
            this.comboBoxLCFirm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddFirmList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIPAdd = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxNICAdapters = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(9, 153);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(352, 153);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(103, 23);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload Firmware";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxLCIP
            // 
            this.textBoxLCIP.Location = new System.Drawing.Point(450, 92);
            this.textBoxLCIP.Name = "textBoxLCIP";
            this.textBoxLCIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxLCIP.TabIndex = 3;
            // 
            // comboBoxLCFirm
            // 
            this.comboBoxLCFirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLCFirm.FormattingEnabled = true;
            this.comboBoxLCFirm.Location = new System.Drawing.Point(450, 118);
            this.comboBoxLCFirm.Name = "comboBoxLCFirm";
            this.comboBoxLCFirm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLCFirm.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LC IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LC Firmware:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonAddFirmList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxIPAdd);
            this.groupBox1.Controls.Add(this.textBoxIndex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.richTextBoxNICAdapters);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonUpload);
            this.groupBox1.Controls.Add(this.textBoxLCIP);
            this.groupBox1.Controls.Add(this.comboBoxLCFirm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonAddFirmList
            // 
            this.buttonAddFirmList.Location = new System.Drawing.Point(141, 153);
            this.buttonAddFirmList.Name = "buttonAddFirmList";
            this.buttonAddFirmList.Size = new System.Drawing.Size(152, 23);
            this.buttonAddFirmList.TabIndex = 16;
            this.buttonAddFirmList.Text = "Add New Firmware To List";
            this.buttonAddFirmList.UseVisualStyleBackColor = true;
            this.buttonAddFirmList.Click += new System.EventHandler(this.buttonAddFirmList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Desired IP:";
            // 
            // textBoxIPAdd
            // 
            this.textBoxIPAdd.Location = new System.Drawing.Point(450, 66);
            this.textBoxIPAdd.Name = "textBoxIPAdd";
            this.textBoxIPAdd.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPAdd.TabIndex = 14;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(450, 40);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(30, 20);
            this.textBoxIndex.TabIndex = 12;
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Network Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Network Adapters:";
            // 
            // richTextBoxNICAdapters
            // 
            this.richTextBoxNICAdapters.Location = new System.Drawing.Point(9, 41);
            this.richTextBoxNICAdapters.Name = "richTextBoxNICAdapters";
            this.richTextBoxNICAdapters.ReadOnly = true;
            this.richTextBoxNICAdapters.Size = new System.Drawing.Size(347, 106);
            this.richTextBoxNICAdapters.TabIndex = 9;
            this.richTextBoxNICAdapters.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start LC Web Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(299, 153);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(47, 23);
            this.buttonRefresh.TabIndex = 38;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // LCFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 207);
            this.Controls.Add(this.groupBox1);
            this.Name = "LCFirmware";
            this.Text = "LC Firmware";
            this.Load += new System.EventHandler(this.LCFirmware_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxLCIP;
        private System.Windows.Forms.ComboBox comboBoxLCFirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxNICAdapters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIPAdd;
        private System.Windows.Forms.Button buttonAddFirmList;
        private System.Windows.Forms.Button buttonRefresh;
    }
}