namespace FormConnect
{
    partial class frmKetNoiDB
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThoat);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnDocFile);
            this.groupControl1.Controls.Add(this.btnKiemTra);
            this.groupControl1.Controls.Add(this.cboDatabase);
            this.groupControl1.Controls.Add(this.lbDatabase);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.Password);
            this.groupControl1.Controls.Add(this.txtUsername);
            this.groupControl1.Controls.Add(this.Username);
            this.groupControl1.Controls.Add(this.txtServer);
            this.groupControl1.Controls.Add(this.lbServer);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(585, 252);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(19, 46);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(45, 16);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(94, 43);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(418, 23);
            this.txtServer.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(94, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(418, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(19, 79);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(65, 16);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(418, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(19, 109);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(62, 16);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Location = new System.Drawing.Point(19, 138);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(60, 16);
            this.lbDatabase.TabIndex = 6;
            this.lbDatabase.Text = "Database";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(94, 138);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(418, 24);
            this.cboDatabase.TabIndex = 7;
            this.cboDatabase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDatabase_MouseClick);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(174, 189);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemTra.TabIndex = 8;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(255, 189);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(75, 23);
            this.btnDocFile.TabIndex = 9;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(347, 189);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(437, 189);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKetNoiDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 409);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKetNoiDB";
            this.Text = "frmKetNoiDB";
            this.Load += new System.EventHandler(this.frmKetNoiDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label Username;
    }
}