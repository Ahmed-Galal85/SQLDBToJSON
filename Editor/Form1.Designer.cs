namespace Editor
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
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.tbPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstvwFiles = new System.Windows.Forms.ListView();
            this.btnBrows = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLdTables = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lstbxTables = new System.Windows.Forms.ListBox();
            this.tbPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveAs.Location = new System.Drawing.Point(0, 394);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(672, 23);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // tbPage
            // 
            this.tbPage.Controls.Add(this.tabPage1);
            this.tbPage.Controls.Add(this.tabPage2);
            this.tbPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPage.Location = new System.Drawing.Point(0, 0);
            this.tbPage.Name = "tbPage";
            this.tbPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPage.RightToLeftLayout = true;
            this.tbPage.SelectedIndex = 0;
            this.tbPage.Size = new System.Drawing.Size(672, 395);
            this.tbPage.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstvwFiles);
            this.tabPage1.Controls.Add(this.btnBrows);
            this.tabPage1.Controls.Add(this.txtPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstvwFiles
            // 
            this.lstvwFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstvwFiles.Location = new System.Drawing.Point(3, 46);
            this.lstvwFiles.Name = "lstvwFiles";
            this.lstvwFiles.Size = new System.Drawing.Size(658, 301);
            this.lstvwFiles.TabIndex = 5;
            this.lstvwFiles.UseCompatibleStateImageBehavior = false;
            this.lstvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // btnBrows
            // 
            this.btnBrows.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrows.Location = new System.Drawing.Point(3, 23);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(658, 23);
            this.btnBrows.TabIndex = 4;
            this.btnBrows.Text = "Brows";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.Location = new System.Drawing.Point(3, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(658, 20);
            this.txtPath.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLdTables);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.lstbxTables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataBase";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLdTables
            // 
            this.btnLdTables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLdTables.Location = new System.Drawing.Point(3, 343);
            this.btnLdTables.Name = "btnLdTables";
            this.btnLdTables.Size = new System.Drawing.Size(658, 23);
            this.btnLdTables.TabIndex = 2;
            this.btnLdTables.Text = "Load Tables";
            this.btnLdTables.UseVisualStyleBackColor = true;
            this.btnLdTables.Click += new System.EventHandler(this.btnLdTables_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32523F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.67477F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDataBaseName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 116);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(548, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(3, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(538, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(548, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(548, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "User name";
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(3, 32);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(538, 20);
            this.txtDataBaseName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(555, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Server name";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(4, 3);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(537, 20);
            this.txtServer.TabIndex = 12;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(3, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(538, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // lstbxTables
            // 
            this.lstbxTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstbxTables.FormattingEnabled = true;
            this.lstbxTables.Location = new System.Drawing.Point(3, 3);
            this.lstbxTables.Name = "lstbxTables";
            this.lstbxTables.Size = new System.Drawing.Size(658, 225);
            this.lstbxTables.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 417);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.btnSaveAs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tbPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.TabControl tbPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstvwFiles;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.ListBox lstbxTables;
        private System.Windows.Forms.Button btnLdTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
    }
}

