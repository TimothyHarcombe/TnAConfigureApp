namespace TnAConfigureProgram
{
    partial class LifeLoc
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLeftArrow = new System.Windows.Forms.Button();
            this.buttonRightArrow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUSBDevice = new System.Windows.Forms.ComboBox();
            this.richTextBoxDeviceInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonFAT = new System.Windows.Forms.RadioButton();
            this.radioButtonFAT32 = new System.Windows.Forms.RadioButton();
            this.radioButtonEXFAT = new System.Windows.Forms.RadioButton();
            this.radioButtonNTFS = new System.Windows.Forms.RadioButton();
            this.radioButtonUDF = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(284, 179);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select USB Device:";
            // 
            // buttonLeftArrow
            // 
            this.buttonLeftArrow.Location = new System.Drawing.Point(9, 179);
            this.buttonLeftArrow.Name = "buttonLeftArrow";
            this.buttonLeftArrow.Size = new System.Drawing.Size(108, 23);
            this.buttonLeftArrow.TabIndex = 3;
            this.buttonLeftArrow.Text = "Load Left Arrow";
            this.buttonLeftArrow.UseVisualStyleBackColor = true;
            this.buttonLeftArrow.Click += new System.EventHandler(this.buttonLeftArrow_Click);
            // 
            // buttonRightArrow
            // 
            this.buttonRightArrow.Location = new System.Drawing.Point(123, 179);
            this.buttonRightArrow.Name = "buttonRightArrow";
            this.buttonRightArrow.Size = new System.Drawing.Size(105, 23);
            this.buttonRightArrow.TabIndex = 4;
            this.buttonRightArrow.Text = "Load Right Arrow";
            this.buttonRightArrow.UseVisualStyleBackColor = true;
            this.buttonRightArrow.Click += new System.EventHandler(this.buttonRightArrow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUSBDevice);
            this.groupBox1.Controls.Add(this.richTextBoxDeviceInfo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonFormat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRightArrow);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonLeftArrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxUSBDevice
            // 
            this.comboBoxUSBDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUSBDevice.FormattingEnabled = true;
            this.comboBoxUSBDevice.Location = new System.Drawing.Point(6, 152);
            this.comboBoxUSBDevice.Name = "comboBoxUSBDevice";
            this.comboBoxUSBDevice.Size = new System.Drawing.Size(175, 21);
            this.comboBoxUSBDevice.TabIndex = 15;
            // 
            // richTextBoxDeviceInfo
            // 
            this.richTextBoxDeviceInfo.Location = new System.Drawing.Point(6, 32);
            this.richTextBoxDeviceInfo.Name = "richTextBoxDeviceInfo";
            this.richTextBoxDeviceInfo.ReadOnly = true;
            this.richTextBoxDeviceInfo.Size = new System.Drawing.Size(219, 96);
            this.richTextBoxDeviceInfo.TabIndex = 11;
            this.richTextBoxDeviceInfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonFAT);
            this.groupBox3.Controls.Add(this.radioButtonFAT32);
            this.groupBox3.Controls.Add(this.radioButtonEXFAT);
            this.groupBox3.Controls.Add(this.radioButtonNTFS);
            this.groupBox3.Controls.Add(this.radioButtonUDF);
            this.groupBox3.Location = new System.Drawing.Point(231, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select File System:";
            // 
            // radioButtonFAT
            // 
            this.radioButtonFAT.AutoSize = true;
            this.radioButtonFAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFAT.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFAT.Name = "radioButtonFAT";
            this.radioButtonFAT.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFAT.TabIndex = 5;
            this.radioButtonFAT.TabStop = true;
            this.radioButtonFAT.Text = "FAT";
            this.radioButtonFAT.UseVisualStyleBackColor = true;
            // 
            // radioButtonFAT32
            // 
            this.radioButtonFAT32.AutoSize = true;
            this.radioButtonFAT32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFAT32.Location = new System.Drawing.Point(71, 19);
            this.radioButtonFAT32.Name = "radioButtonFAT32";
            this.radioButtonFAT32.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFAT32.TabIndex = 6;
            this.radioButtonFAT32.TabStop = true;
            this.radioButtonFAT32.Text = "FAT32";
            this.radioButtonFAT32.UseVisualStyleBackColor = true;
            // 
            // radioButtonEXFAT
            // 
            this.radioButtonEXFAT.AutoSize = true;
            this.radioButtonEXFAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEXFAT.Location = new System.Drawing.Point(6, 42);
            this.radioButtonEXFAT.Name = "radioButtonEXFAT";
            this.radioButtonEXFAT.Size = new System.Drawing.Size(59, 17);
            this.radioButtonEXFAT.TabIndex = 7;
            this.radioButtonEXFAT.TabStop = true;
            this.radioButtonEXFAT.Text = "EXFAT";
            this.radioButtonEXFAT.UseVisualStyleBackColor = true;
            // 
            // radioButtonNTFS
            // 
            this.radioButtonNTFS.AutoSize = true;
            this.radioButtonNTFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNTFS.Location = new System.Drawing.Point(71, 42);
            this.radioButtonNTFS.Name = "radioButtonNTFS";
            this.radioButtonNTFS.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNTFS.TabIndex = 8;
            this.radioButtonNTFS.TabStop = true;
            this.radioButtonNTFS.Text = "NTFS";
            this.radioButtonNTFS.UseVisualStyleBackColor = true;
            // 
            // radioButtonUDF
            // 
            this.radioButtonUDF.AutoSize = true;
            this.radioButtonUDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUDF.Location = new System.Drawing.Point(6, 65);
            this.radioButtonUDF.Name = "radioButtonUDF";
            this.radioButtonUDF.Size = new System.Drawing.Size(47, 17);
            this.radioButtonUDF.TabIndex = 9;
            this.radioButtonUDF.TabStop = true;
            this.radioButtonUDF.Text = "UDF";
            this.radioButtonUDF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selected Device Current Infomation:";
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(187, 150);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(175, 23);
            this.buttonFormat.TabIndex = 10;
            this.buttonFormat.Text = "Only Format ";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WARNING:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "If you select Load Left Arrow or Load Right Arrow it will format your \r\nUSB Devic" +
    "e. So please select the correct USB device that you would \r\nlike to use for the " +
    "Firmware.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LifeLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LifeLoc";
            this.Text = "LifeLoc";
            this.Load += new System.EventHandler(this.LifeLoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLeftArrow;
        private System.Windows.Forms.Button buttonRightArrow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonUDF;
        private System.Windows.Forms.RadioButton radioButtonNTFS;
        private System.Windows.Forms.RadioButton radioButtonEXFAT;
        private System.Windows.Forms.RadioButton radioButtonFAT32;
        private System.Windows.Forms.RadioButton radioButtonFAT;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDeviceInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxUSBDevice;
    }
}