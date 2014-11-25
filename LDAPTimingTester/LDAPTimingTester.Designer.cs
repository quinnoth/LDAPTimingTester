namespace LDAPTimingTester
{
    partial class LDAPTimingTester
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
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.chkLDAPSEnabled = new System.Windows.Forms.CheckBox();
            this.txtSearchBase = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDirectoryPort = new System.Windows.Forms.TextBox();
            this.txtDirectoryHostname = new System.Windows.Forms.TextBox();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.lblSearchFilter = new System.Windows.Forms.Label();
            this.lblSearchBase = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDirectoryPort = new System.Windows.Forms.Label();
            this.lblDirectoryHostname = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRunAsSync = new System.Windows.Forms.Button();
            this.btnRunAsAsync = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpConfiguration.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Controls.Add(this.txtSearchItems);
            this.grpConfiguration.Controls.Add(this.txtSearchFilter);
            this.grpConfiguration.Controls.Add(this.chkLDAPSEnabled);
            this.grpConfiguration.Controls.Add(this.txtSearchBase);
            this.grpConfiguration.Controls.Add(this.txtPassword);
            this.grpConfiguration.Controls.Add(this.txtUsername);
            this.grpConfiguration.Controls.Add(this.txtDirectoryPort);
            this.grpConfiguration.Controls.Add(this.txtDirectoryHostname);
            this.grpConfiguration.Controls.Add(this.lblSearchItems);
            this.grpConfiguration.Controls.Add(this.lblSearchFilter);
            this.grpConfiguration.Controls.Add(this.lblSearchBase);
            this.grpConfiguration.Controls.Add(this.lblPassword);
            this.grpConfiguration.Controls.Add(this.lblUsername);
            this.grpConfiguration.Controls.Add(this.lblDirectoryPort);
            this.grpConfiguration.Controls.Add(this.lblDirectoryHostname);
            this.grpConfiguration.Location = new System.Drawing.Point(13, 13);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Size = new System.Drawing.Size(376, 364);
            this.grpConfiguration.TabIndex = 0;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration";
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.Location = new System.Drawing.Point(116, 194);
            this.txtSearchItems.Multiline = true;
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchItems.Size = new System.Drawing.Size(254, 164);
            this.txtSearchItems.TabIndex = 14;
            this.txtSearchItems.WordWrap = false;
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Location = new System.Drawing.Point(116, 168);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(254, 20);
            this.txtSearchFilter.TabIndex = 13;
            // 
            // chkLDAPSEnabled
            // 
            this.chkLDAPSEnabled.AutoSize = true;
            this.chkLDAPSEnabled.Location = new System.Drawing.Point(116, 121);
            this.chkLDAPSEnabled.Name = "chkLDAPSEnabled";
            this.chkLDAPSEnabled.Size = new System.Drawing.Size(109, 17);
            this.chkLDAPSEnabled.TabIndex = 12;
            this.chkLDAPSEnabled.Text = "LDAPS Enabled?";
            this.chkLDAPSEnabled.UseVisualStyleBackColor = true;
            // 
            // txtSearchBase
            // 
            this.txtSearchBase.Location = new System.Drawing.Point(116, 142);
            this.txtSearchBase.Name = "txtSearchBase";
            this.txtSearchBase.Size = new System.Drawing.Size(254, 20);
            this.txtSearchBase.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(116, 69);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // txtDirectoryPort
            // 
            this.txtDirectoryPort.Location = new System.Drawing.Point(116, 43);
            this.txtDirectoryPort.Name = "txtDirectoryPort";
            this.txtDirectoryPort.Size = new System.Drawing.Size(254, 20);
            this.txtDirectoryPort.TabIndex = 8;
            this.txtDirectoryPort.Text = "389";
            // 
            // txtDirectoryHostname
            // 
            this.txtDirectoryHostname.Location = new System.Drawing.Point(116, 17);
            this.txtDirectoryHostname.Name = "txtDirectoryHostname";
            this.txtDirectoryHostname.Size = new System.Drawing.Size(254, 20);
            this.txtDirectoryHostname.TabIndex = 7;
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.AutoSize = true;
            this.lblSearchItems.Location = new System.Drawing.Point(38, 197);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(72, 13);
            this.lblSearchItems.TabIndex = 6;
            this.lblSearchItems.Text = "Search Items:";
            this.lblSearchItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSearchFilter
            // 
            this.lblSearchFilter.AutoSize = true;
            this.lblSearchFilter.Location = new System.Drawing.Point(41, 171);
            this.lblSearchFilter.Name = "lblSearchFilter";
            this.lblSearchFilter.Size = new System.Drawing.Size(69, 13);
            this.lblSearchFilter.TabIndex = 5;
            this.lblSearchFilter.Text = "Search Filter:";
            this.lblSearchFilter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSearchBase
            // 
            this.lblSearchBase.AutoSize = true;
            this.lblSearchBase.Location = new System.Drawing.Point(39, 145);
            this.lblSearchBase.Name = "lblSearchBase";
            this.lblSearchBase.Size = new System.Drawing.Size(71, 13);
            this.lblSearchBase.TabIndex = 4;
            this.lblSearchBase.Text = "Search Base:";
            this.lblSearchBase.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(52, 72);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDirectoryPort
            // 
            this.lblDirectoryPort.AutoSize = true;
            this.lblDirectoryPort.Location = new System.Drawing.Point(36, 46);
            this.lblDirectoryPort.Name = "lblDirectoryPort";
            this.lblDirectoryPort.Size = new System.Drawing.Size(74, 13);
            this.lblDirectoryPort.TabIndex = 1;
            this.lblDirectoryPort.Text = "Directory Port:";
            this.lblDirectoryPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDirectoryHostname
            // 
            this.lblDirectoryHostname.AutoSize = true;
            this.lblDirectoryHostname.Location = new System.Drawing.Point(7, 20);
            this.lblDirectoryHostname.Name = "lblDirectoryHostname";
            this.lblDirectoryHostname.Size = new System.Drawing.Size(103, 13);
            this.lblDirectoryHostname.TabIndex = 0;
            this.lblDirectoryHostname.Text = "Directory Hostname:";
            this.lblDirectoryHostname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(396, 13);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(504, 364);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(6, 17);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(492, 341);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // btnRunAsSync
            // 
            this.btnRunAsSync.Location = new System.Drawing.Point(570, 383);
            this.btnRunAsSync.Name = "btnRunAsSync";
            this.btnRunAsSync.Size = new System.Drawing.Size(106, 23);
            this.btnRunAsSync.TabIndex = 2;
            this.btnRunAsSync.Text = "Run as Sync";
            this.btnRunAsSync.UseVisualStyleBackColor = true;
            this.btnRunAsSync.Click += new System.EventHandler(this.btnRunAsSync_Click);
            // 
            // btnRunAsAsync
            // 
            this.btnRunAsAsync.Location = new System.Drawing.Point(682, 383);
            this.btnRunAsAsync.Name = "btnRunAsAsync";
            this.btnRunAsAsync.Size = new System.Drawing.Size(106, 23);
            this.btnRunAsAsync.TabIndex = 3;
            this.btnRunAsAsync.Text = "Run as Async";
            this.btnRunAsAsync.UseVisualStyleBackColor = true;
            this.btnRunAsAsync.Click += new System.EventHandler(this.btnRunAsAsync_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(794, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LDAPTimingTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRunAsAsync);
            this.Controls.Add(this.btnRunAsSync);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpConfiguration);
            this.Name = "LDAPTimingTester";
            this.Text = "Form1";
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguration;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDirectoryPort;
        private System.Windows.Forms.Label lblDirectoryHostname;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.CheckBox chkLDAPSEnabled;
        private System.Windows.Forms.TextBox txtSearchBase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDirectoryPort;
        private System.Windows.Forms.TextBox txtDirectoryHostname;
        private System.Windows.Forms.Label lblSearchItems;
        private System.Windows.Forms.Label lblSearchFilter;
        private System.Windows.Forms.Label lblSearchBase;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRunAsSync;
        private System.Windows.Forms.Button btnRunAsAsync;
        private System.Windows.Forms.Button btnClose;
    }
}

