namespace Hadoop.Conf
{
    partial class Credentials
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.gbHost = new System.Windows.Forms.GroupBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.tlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.gbUsername.SuspendLayout();
            this.gbPort.SuspendLayout();
            this.gbHost.SuspendLayout();
            this.tlpAction.SuspendLayout();
            this.gbPath.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbPassword, 0, 3);
            this.tlpMain.Controls.Add(this.gbUsername, 0, 2);
            this.tlpMain.Controls.Add(this.gbPort, 0, 1);
            this.tlpMain.Controls.Add(this.gbHost, 0, 0);
            this.tlpMain.Controls.Add(this.tlpAction, 0, 6);
            this.tlpMain.Controls.Add(this.gbPath, 0, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(282, 289);
            this.tlpMain.TabIndex = 0;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPassword.Location = new System.Drawing.Point(3, 153);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(276, 44);
            this.gbPassword.TabIndex = 3;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(3, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(270, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // gbUsername
            // 
            this.gbUsername.Controls.Add(this.txtUsername);
            this.gbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsername.Location = new System.Drawing.Point(3, 103);
            this.gbUsername.Name = "gbUsername";
            this.gbUsername.Size = new System.Drawing.Size(276, 44);
            this.gbUsername.TabIndex = 2;
            this.gbUsername.TabStop = false;
            this.gbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(3, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // gbPort
            // 
            this.gbPort.Controls.Add(this.txtPort);
            this.gbPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPort.Location = new System.Drawing.Point(3, 53);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(276, 44);
            this.gbPort.TabIndex = 1;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(3, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(270, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "22";
            // 
            // gbHost
            // 
            this.gbHost.Controls.Add(this.txtHost);
            this.gbHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHost.Location = new System.Drawing.Point(3, 3);
            this.gbHost.Name = "gbHost";
            this.gbHost.Size = new System.Drawing.Size(276, 44);
            this.gbHost.TabIndex = 0;
            this.gbHost.TabStop = false;
            this.gbHost.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHost.Location = new System.Drawing.Point(3, 16);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(270, 20);
            this.txtHost.TabIndex = 0;
            this.txtHost.Text = "localhost";
            // 
            // tlpAction
            // 
            this.tlpAction.ColumnCount = 3;
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpAction.Controls.Add(this.btnAccept, 2, 0);
            this.tlpAction.Controls.Add(this.btnCancel, 1, 0);
            this.tlpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAction.Location = new System.Drawing.Point(0, 259);
            this.tlpAction.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAction.Name = "tlpAction";
            this.tlpAction.RowCount = 1;
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAction.Size = new System.Drawing.Size(282, 30);
            this.tlpAction.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Location = new System.Drawing.Point(185, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 24);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.OnAccept);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(85, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPath.Location = new System.Drawing.Point(3, 203);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(276, 44);
            this.gbPath.TabIndex = 4;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.Location = new System.Drawing.Point(3, 16);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(270, 20);
            this.txtPath.TabIndex = 4;
            this.txtPath.Text = "/";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.tlpMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(284, 291);
            this.pnlMain.TabIndex = 1;
            // 
            // Credentials
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Credentials";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Credentials";
            this.tlpMain.ResumeLayout(false);
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.gbUsername.ResumeLayout(false);
            this.gbUsername.PerformLayout();
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbHost.ResumeLayout(false);
            this.gbHost.PerformLayout();
            this.tlpAction.ResumeLayout(false);
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.GroupBox gbUsername;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.GroupBox gbHost;
        private System.Windows.Forms.TableLayoutPanel tlpAction;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel pnlMain;
    }
}