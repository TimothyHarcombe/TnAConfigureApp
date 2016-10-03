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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSiteInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decommissionedGateWayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreSiteGateWayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tnAConfigureToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagemConfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rabitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lifeLocTesterFirmwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCReaderFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lCFirmwareUploaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTnAConfigureProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonConfigureGateway = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectSite = new System.Windows.Forms.ComboBox();
            this.comboBoxGWArea = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.richTextBoxNICAdapters = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.siteInformationToolStripMenuItem,
            this.tnAConfigureToolsToolStripMenuItem,
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
            this.decommissionedGateWayToolStripMenuItem,
            this.restoreSiteGateWayToolStripMenuItem});
            this.siteInformationToolStripMenuItem.Name = "siteInformationToolStripMenuItem";
            this.siteInformationToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.siteInformationToolStripMenuItem.Text = "Site/GateWay Information";
            // 
            // addNewSiteToolStripMenuItem
            // 
            this.addNewSiteToolStripMenuItem.Name = "addNewSiteToolStripMenuItem";
            this.addNewSiteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addNewSiteToolStripMenuItem.Text = "Add New Site/GateWay";
            this.addNewSiteToolStripMenuItem.Click += new System.EventHandler(this.addNewSiteToolStripMenuItem_Click);
            // 
            // changeSiteInformationToolStripMenuItem
            // 
            this.changeSiteInformationToolStripMenuItem.Name = "changeSiteInformationToolStripMenuItem";
            this.changeSiteInformationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.changeSiteInformationToolStripMenuItem.Text = "Change GateWay Information";
            this.changeSiteInformationToolStripMenuItem.Click += new System.EventHandler(this.changeSiteInformationToolStripMenuItem_Click);
            // 
            // decommissionedGateWayToolStripMenuItem
            // 
            this.decommissionedGateWayToolStripMenuItem.Name = "decommissionedGateWayToolStripMenuItem";
            this.decommissionedGateWayToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.decommissionedGateWayToolStripMenuItem.Text = "Remove Site/GateWay";
            this.decommissionedGateWayToolStripMenuItem.Click += new System.EventHandler(this.decommissionedGateWayToolStripMenuItem_Click);
            // 
            // restoreSiteGateWayToolStripMenuItem
            // 
            this.restoreSiteGateWayToolStripMenuItem.Name = "restoreSiteGateWayToolStripMenuItem";
            this.restoreSiteGateWayToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.restoreSiteGateWayToolStripMenuItem.Text = "Restore Site/GateWay";
            this.restoreSiteGateWayToolStripMenuItem.Click += new System.EventHandler(this.restoreSiteGateWayToolStripMenuItem_Click);
            // 
            // tnAConfigureToolsToolStripMenuItem
            // 
            this.tnAConfigureToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagemConfigureToolStripMenuItem,
            this.rabitToolStripMenuItem,
            this.shroomToolStripMenuItem,
            this.uDPToolToolStripMenuItem,
            this.dBConnectToolStripMenuItem,
            this.lifeLocTesterFirmwareToolStripMenuItem,
            this.lCProgramsToolStripMenuItem});
            this.tnAConfigureToolsToolStripMenuItem.Name = "tnAConfigureToolsToolStripMenuItem";
            this.tnAConfigureToolsToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.tnAConfigureToolsToolStripMenuItem.Text = "Configuration Tools";
            // 
            // sagemConfigureToolStripMenuItem
            // 
            this.sagemConfigureToolStripMenuItem.Name = "sagemConfigureToolStripMenuItem";
            this.sagemConfigureToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.sagemConfigureToolStripMenuItem.Text = "Sagem Configure";
            this.sagemConfigureToolStripMenuItem.Click += new System.EventHandler(this.sagemConfigureToolStripMenuItem_Click);
            // 
            // rabitToolStripMenuItem
            // 
            this.rabitToolStripMenuItem.Name = "rabitToolStripMenuItem";
            this.rabitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.rabitToolStripMenuItem.Text = "Rabbit";
            this.rabitToolStripMenuItem.Click += new System.EventHandler(this.rabitToolStripMenuItem_Click);
            // 
            // shroomToolStripMenuItem
            // 
            this.shroomToolStripMenuItem.Name = "shroomToolStripMenuItem";
            this.shroomToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.shroomToolStripMenuItem.Text = "Shroom";
            this.shroomToolStripMenuItem.Click += new System.EventHandler(this.shroomToolStripMenuItem_Click);
            // 
            // uDPToolToolStripMenuItem
            // 
            this.uDPToolToolStripMenuItem.Name = "uDPToolToolStripMenuItem";
            this.uDPToolToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.uDPToolToolStripMenuItem.Text = "UDPTool";
            this.uDPToolToolStripMenuItem.Click += new System.EventHandler(this.uDPToolToolStripMenuItem_Click);
            // 
            // dBConnectToolStripMenuItem
            // 
            this.dBConnectToolStripMenuItem.Name = "dBConnectToolStripMenuItem";
            this.dBConnectToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dBConnectToolStripMenuItem.Text = "DBConnect";
            this.dBConnectToolStripMenuItem.Click += new System.EventHandler(this.dBConnectToolStripMenuItem_Click);
            // 
            // lifeLocTesterFirmwareToolStripMenuItem
            // 
            this.lifeLocTesterFirmwareToolStripMenuItem.Name = "lifeLocTesterFirmwareToolStripMenuItem";
            this.lifeLocTesterFirmwareToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.lifeLocTesterFirmwareToolStripMenuItem.Text = "LifeLoc Tester Firmware";
            this.lifeLocTesterFirmwareToolStripMenuItem.Click += new System.EventHandler(this.lifeLocTesterFirmwareToolStripMenuItem_Click);
            // 
            // lCProgramsToolStripMenuItem
            // 
            this.lCProgramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lCReaderFinderToolStripMenuItem,
            this.lCFirmwareUploaderToolStripMenuItem});
            this.lCProgramsToolStripMenuItem.Name = "lCProgramsToolStripMenuItem";
            this.lCProgramsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.lCProgramsToolStripMenuItem.Text = "LC Programs";
            // 
            // lCReaderFinderToolStripMenuItem
            // 
            this.lCReaderFinderToolStripMenuItem.Name = "lCReaderFinderToolStripMenuItem";
            this.lCReaderFinderToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lCReaderFinderToolStripMenuItem.Text = "LC Reader Finder";
            this.lCReaderFinderToolStripMenuItem.Click += new System.EventHandler(this.lCReaderFinderToolStripMenuItem_Click);
            // 
            // lCFirmwareUploaderToolStripMenuItem
            // 
            this.lCFirmwareUploaderToolStripMenuItem.Name = "lCFirmwareUploaderToolStripMenuItem";
            this.lCFirmwareUploaderToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lCFirmwareUploaderToolStripMenuItem.Text = "LC Firmware Uploader";
            this.lCFirmwareUploaderToolStripMenuItem.Click += new System.EventHandler(this.lCFirmwareUploaderToolStripMenuItem_Click);
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
            this.aboutTnAConfigureProgramToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.aboutTnAConfigureProgramToolStripMenuItem.Text = "About Time and Attendance Configuration ";
            this.aboutTnAConfigureProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTnAConfigureProgramToolStripMenuItem_Click);
            // 
            // buttonConfigureGateway
            // 
            this.buttonConfigureGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigureGateway.Location = new System.Drawing.Point(321, 87);
            this.buttonConfigureGateway.Name = "buttonConfigureGateway";
            this.buttonConfigureGateway.Size = new System.Drawing.Size(95, 23);
            this.buttonConfigureGateway.TabIndex = 1;
            this.buttonConfigureGateway.Text = "Configure";
            this.buttonConfigureGateway.UseVisualStyleBackColor = true;
            this.buttonConfigureGateway.Click += new System.EventHandler(this.buttonConfigureGateway_Click);
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
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Site:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select GateWay Area:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMessage);
            this.groupBox1.Controls.Add(this.richTextBoxMessage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxRegion);
            this.groupBox1.Controls.Add(this.comboBoxSelectSite);
            this.groupBox1.Controls.Add(this.comboBoxGWArea);
            this.groupBox1.Controls.Add(this.buttonConfigureGateway);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 121);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GateWay Configuration:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(438, 31);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 19);
            this.labelMessage.TabIndex = 40;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(442, 60);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(150, 59);
            this.richTextBoxMessage.TabIndex = 39;
            this.richTextBoxMessage.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Select Region:";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(136, 32);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(179, 21);
            this.comboBoxRegion.TabIndex = 36;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // comboBoxSelectSite
            // 
            this.comboBoxSelectSite.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelectSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectSite.FormattingEnabled = true;
            this.comboBoxSelectSite.Location = new System.Drawing.Point(136, 62);
            this.comboBoxSelectSite.Name = "comboBoxSelectSite";
            this.comboBoxSelectSite.Size = new System.Drawing.Size(179, 21);
            this.comboBoxSelectSite.TabIndex = 35;
            this.comboBoxSelectSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSite_SelectedIndexChanged);
            // 
            // comboBoxGWArea
            // 
            this.comboBoxGWArea.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxGWArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGWArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGWArea.FormattingEnabled = true;
            this.comboBoxGWArea.Location = new System.Drawing.Point(136, 89);
            this.comboBoxGWArea.Name = "comboBoxGWArea";
            this.comboBoxGWArea.Size = new System.Drawing.Size(179, 21);
            this.comboBoxGWArea.TabIndex = 32;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Time and Attendance Configuration Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxGWArea;
        private System.Windows.Forms.ToolStripMenuItem siteInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSiteInformationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxNICAdapters;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.ToolStripMenuItem decommissionedGateWayToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tnAConfigureToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagemConfigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rabitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCReaderFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lCFirmwareUploaderToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxSelectSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ToolStripMenuItem lifeLocTesterFirmwareToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ToolStripMenuItem restoreSiteGateWayToolStripMenuItem;
    }
}

