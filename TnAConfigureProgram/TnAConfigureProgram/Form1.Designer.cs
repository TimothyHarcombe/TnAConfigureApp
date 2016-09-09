namespace TnAConfigureProgram
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSiteInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTnAConfigureProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConfigureGateway = new System.Windows.Forms.Button();
            this.buttonConfigureSagem = new System.Windows.Forms.Button();
            this.textBoxMATM = new System.Windows.Forms.TextBox();
            this.buttonMATMBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSelectSiteBrowse = new System.Windows.Forms.Button();
            this.textBoxSelectSite = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGWArea = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.richTextBoxNICAdapters = new System.Windows.Forms.RichTextBox();
            this.decommissionedGateWayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.siteInformationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // siteInformationToolStripMenuItem
            // 
            this.siteInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSiteToolStripMenuItem,
            this.changeSiteInformationToolStripMenuItem,
            this.decommissionedGateWayToolStripMenuItem});
            this.siteInformationToolStripMenuItem.Name = "siteInformationToolStripMenuItem";
            this.siteInformationToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.siteInformationToolStripMenuItem.Text = "Site Information";
            // 
            // addNewSiteToolStripMenuItem
            // 
            this.addNewSiteToolStripMenuItem.Name = "addNewSiteToolStripMenuItem";
            this.addNewSiteToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.addNewSiteToolStripMenuItem.Text = "Add New Site";
            this.addNewSiteToolStripMenuItem.Click += new System.EventHandler(this.addNewSiteToolStripMenuItem_Click);
            // 
            // changeSiteInformationToolStripMenuItem
            // 
            this.changeSiteInformationToolStripMenuItem.Name = "changeSiteInformationToolStripMenuItem";
            this.changeSiteInformationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.changeSiteInformationToolStripMenuItem.Text = "Change Site Information";
            this.changeSiteInformationToolStripMenuItem.Click += new System.EventHandler(this.changeSiteInformationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTnAConfigureProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTnAConfigureProgramToolStripMenuItem
            // 
            this.aboutTnAConfigureProgramToolStripMenuItem.Name = "aboutTnAConfigureProgramToolStripMenuItem";
            this.aboutTnAConfigureProgramToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.aboutTnAConfigureProgramToolStripMenuItem.Text = "About TnA Configure Program";
            this.aboutTnAConfigureProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTnAConfigureProgramToolStripMenuItem_Click);
            // 
            // buttonConfigureGateway
            // 
            this.buttonConfigureGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigureGateway.Location = new System.Drawing.Point(355, 63);
            this.buttonConfigureGateway.Name = "buttonConfigureGateway";
            this.buttonConfigureGateway.Size = new System.Drawing.Size(95, 23);
            this.buttonConfigureGateway.TabIndex = 1;
            this.buttonConfigureGateway.Text = "Configure";
            this.buttonConfigureGateway.UseVisualStyleBackColor = true;
            this.buttonConfigureGateway.Click += new System.EventHandler(this.buttonConfigureGateway_Click);
            // 
            // buttonConfigureSagem
            // 
            this.buttonConfigureSagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigureSagem.Location = new System.Drawing.Point(436, 48);
            this.buttonConfigureSagem.Name = "buttonConfigureSagem";
            this.buttonConfigureSagem.Size = new System.Drawing.Size(136, 23);
            this.buttonConfigureSagem.TabIndex = 2;
            this.buttonConfigureSagem.Text = "Configure Sagem";
            this.buttonConfigureSagem.UseVisualStyleBackColor = true;
            this.buttonConfigureSagem.Click += new System.EventHandler(this.buttonConfigureSagem_Click);
            // 
            // textBoxMATM
            // 
            this.textBoxMATM.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMATM.Location = new System.Drawing.Point(9, 50);
            this.textBoxMATM.Multiline = true;
            this.textBoxMATM.Name = "textBoxMATM";
            this.textBoxMATM.ReadOnly = true;
            this.textBoxMATM.Size = new System.Drawing.Size(372, 20);
            this.textBoxMATM.TabIndex = 18;
            // 
            // buttonMATMBrowse
            // 
            this.buttonMATMBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMATMBrowse.Location = new System.Drawing.Point(387, 48);
            this.buttonMATMBrowse.Name = "buttonMATMBrowse";
            this.buttonMATMBrowse.Size = new System.Drawing.Size(43, 23);
            this.buttonMATMBrowse.TabIndex = 19;
            this.buttonMATMBrowse.Text = "....";
            this.buttonMATMBrowse.UseVisualStyleBackColor = true;
            this.buttonMATMBrowse.Click += new System.EventHandler(this.buttonMATMBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Network Card Index Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select GateWay Area:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Location of MATM Express:";
            // 
            // buttonSelectSiteBrowse
            // 
            this.buttonSelectSiteBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSiteBrowse.Location = new System.Drawing.Point(546, 33);
            this.buttonSelectSiteBrowse.Name = "buttonSelectSiteBrowse";
            this.buttonSelectSiteBrowse.Size = new System.Drawing.Size(43, 23);
            this.buttonSelectSiteBrowse.TabIndex = 30;
            this.buttonSelectSiteBrowse.Text = "....";
            this.buttonSelectSiteBrowse.UseVisualStyleBackColor = true;
            this.buttonSelectSiteBrowse.Click += new System.EventHandler(this.buttonSelectSiteBrowse_Click);
            // 
            // textBoxSelectSite
            // 
            this.textBoxSelectSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectSite.Location = new System.Drawing.Point(150, 35);
            this.textBoxSelectSite.Name = "textBoxSelectSite";
            this.textBoxSelectSite.ReadOnly = true;
            this.textBoxSelectSite.Size = new System.Drawing.Size(390, 20);
            this.textBoxSelectSite.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxGWArea);
            this.groupBox1.Controls.Add(this.buttonConfigureGateway);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSelectSite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSelectSiteBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 99);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TnA GateWay Configure:";
            // 
            // comboBoxGWArea
            // 
            this.comboBoxGWArea.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGWArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGWArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGWArea.FormattingEnabled = true;
            this.comboBoxGWArea.Location = new System.Drawing.Point(150, 65);
            this.comboBoxGWArea.Name = "comboBoxGWArea";
            this.comboBoxGWArea.Size = new System.Drawing.Size(179, 21);
            this.comboBoxGWArea.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonConfigureSagem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxMATM);
            this.groupBox2.Controls.Add(this.buttonMATMBrowse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 82);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sagem Configure:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxIndex);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.richTextBoxNICAdapters);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 178);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Network Adapters:";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(214, 146);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(40, 20);
            this.textBoxIndex.TabIndex = 33;
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBoxNICAdapters
            // 
            this.richTextBoxNICAdapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNICAdapters.Location = new System.Drawing.Point(6, 22);
            this.richTextBoxNICAdapters.Name = "richTextBoxNICAdapters";
            this.richTextBoxNICAdapters.Size = new System.Drawing.Size(375, 122);
            this.richTextBoxNICAdapters.TabIndex = 0;
            this.richTextBoxNICAdapters.Text = "";
            // 
            // decommissionedGateWayToolStripMenuItem
            // 
            this.decommissionedGateWayToolStripMenuItem.Name = "decommissionedGateWayToolStripMenuItem";
            this.decommissionedGateWayToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.decommissionedGateWayToolStripMenuItem.Text = "Decommissioned GateWay";
            this.decommissionedGateWayToolStripMenuItem.Click += new System.EventHandler(this.decommissionedGateWayToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 52);
            this.label1.TabIndex = 34;
            this.label1.Text = "Please select the function you \r\nwould like to do and select the Network \r\nAdapte" +
    "r that you would like to use via \r\nthe Index number.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TnA Configure Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTnAConfigureProgramToolStripMenuItem;
        private System.Windows.Forms.Button buttonConfigureGateway;
        private System.Windows.Forms.Button buttonConfigureSagem;
        private System.Windows.Forms.TextBox textBoxMATM;
        private System.Windows.Forms.Button buttonMATMBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSelectSiteBrowse;
        private System.Windows.Forms.TextBox textBoxSelectSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxGWArea;
        private System.Windows.Forms.ToolStripMenuItem siteInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSiteInformationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxNICAdapters;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.ToolStripMenuItem decommissionedGateWayToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

