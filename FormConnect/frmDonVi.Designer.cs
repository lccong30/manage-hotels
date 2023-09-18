namespace FormConnect
{
    partial class frmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonVi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnSkip = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DISABLED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MADVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboCty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lbMADVI = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnSkip,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(962, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 44);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Image = ((System.Drawing.Image)(resources.GetObject("btnSkip.Image")));
            this.btnSkip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(60, 44);
            this.btnSkip.Text = "Bỏ qua";
            this.btnSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thóat";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(962, 299);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DISABLED,
            this.MADVI,
            this.TENDVI,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI,
            this.MACTY});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // DISABLED
            // 
            this.DISABLED.Caption = "DEL";
            this.DISABLED.FieldName = "DISABLED";
            this.DISABLED.MaxWidth = 35;
            this.DISABLED.MinWidth = 25;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.Visible = true;
            this.DISABLED.VisibleIndex = 0;
            this.DISABLED.Width = 30;
            // 
            // MADVI
            // 
            this.MADVI.Caption = "MÃ DVI";
            this.MADVI.FieldName = "MADVI";
            this.MADVI.MaxWidth = 70;
            this.MADVI.MinWidth = 25;
            this.MADVI.Name = "MADVI";
            this.MADVI.Visible = true;
            this.MADVI.VisibleIndex = 1;
            this.MADVI.Width = 70;
            // 
            // TENDVI
            // 
            this.TENDVI.Caption = "TÊN ĐƠN VỊ";
            this.TENDVI.FieldName = "TENDVI";
            this.TENDVI.MaxWidth = 250;
            this.TENDVI.MinWidth = 25;
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.Visible = true;
            this.TENDVI.VisibleIndex = 2;
            this.TENDVI.Width = 94;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Caption = "ĐIỆN THOẠI";
            this.DIENTHOAI.FieldName = "DIENTHOAI";
            this.DIENTHOAI.MaxWidth = 100;
            this.DIENTHOAI.MinWidth = 80;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = true;
            this.DIENTHOAI.VisibleIndex = 3;
            this.DIENTHOAI.Width = 94;
            // 
            // FAX
            // 
            this.FAX.Caption = "FAX";
            this.FAX.FieldName = "FAX";
            this.FAX.MaxWidth = 100;
            this.FAX.MinWidth = 25;
            this.FAX.Name = "FAX";
            this.FAX.Visible = true;
            this.FAX.VisibleIndex = 6;
            this.FAX.Width = 94;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "EMAIL";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.MaxWidth = 180;
            this.EMAIL.MinWidth = 170;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 4;
            this.EMAIL.Width = 170;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MaxWidth = 250;
            this.DIACHI.MinWidth = 25;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            this.DIACHI.Width = 94;
            // 
            // MACTY
            // 
            this.MACTY.Caption = "CÔNG TY";
            this.MACTY.FieldName = "MACTY";
            this.MACTY.MinWidth = 25;
            this.MACTY.Name = "MACTY";
            this.MACTY.Visible = true;
            this.MACTY.VisibleIndex = 7;
            this.MACTY.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboCty);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.lbMADVI);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.chkDisabled);
            this.groupControl1.Controls.Add(this.txtDienThoai);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtFax);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.lbTen);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 346);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(962, 223);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // cboCty
            // 
            this.cboCty.FormattingEnabled = true;
            this.cboCty.Location = new System.Drawing.Point(107, 174);
            this.cboCty.Name = "cboCty";
            this.cboCty.Size = new System.Drawing.Size(764, 24);
            this.cboCty.TabIndex = 18;
            this.cboCty.SelectedIndexChanged += new System.EventHandler(this.cboCty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Công ty";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(107, 48);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(106, 23);
            this.txtMa.TabIndex = 16;
            // 
            // lbMADVI
            // 
            this.lbMADVI.AutoSize = true;
            this.lbMADVI.Location = new System.Drawing.Point(25, 51);
            this.lbMADVI.Name = "lbMADVI";
            this.lbMADVI.Size = new System.Drawing.Size(45, 16);
            this.lbMADVI.TabIndex = 15;
            this.lbMADVI.Text = "MADVI";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(104, 128);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(767, 23);
            this.txtDiaChi.TabIndex = 13;
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(789, 55);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(77, 20);
            this.chkDisabled.TabIndex = 12;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(107, 87);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(320, 23);
            this.txtDienThoai.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(518, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(518, 48);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(244, 23);
            this.txtFax.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(301, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(126, 23);
            this.txtTen.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(219, 51);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(67, 16);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Tên đơn vị";
            // 
            // frmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 569);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đơn vị";
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnSkip;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DISABLED;
        private DevExpress.XtraGrid.Columns.GridColumn MADVI;
        private DevExpress.XtraGrid.Columns.GridColumn TENDVI;
        private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn FAX;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lbMADVI;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTen;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private System.Windows.Forms.ComboBox cboCty;
        private System.Windows.Forms.Label label5;
    }
}