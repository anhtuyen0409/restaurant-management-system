namespace THD_DoAnCuoiKi
{
    partial class frmMain
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
            this.mnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuaTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTaiKhoan,
            this.mnMonAn,
            this.mnQL,
            this.mnBaoCao,
            this.mnDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(945, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnTaiKhoan
            // 
            this.mnTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuaTaiKhoan});
            this.mnTaiKhoan.Name = "mnTaiKhoan";
            this.mnTaiKhoan.Size = new System.Drawing.Size(97, 25);
            this.mnTaiKhoan.Text = "Tài Khoản";
            // 
            // menuSuaTaiKhoan
            // 
            this.menuSuaTaiKhoan.Name = "menuSuaTaiKhoan";
            this.menuSuaTaiKhoan.Size = new System.Drawing.Size(184, 26);
            this.menuSuaTaiKhoan.Text = "Sửa thông tin";
            this.menuSuaTaiKhoan.Click += new System.EventHandler(this.menuSuaTaiKhoan_Click);
            // 
            // mnMonAn
            // 
            this.mnMonAn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatMon});
            this.mnMonAn.Name = "mnMonAn";
            this.mnMonAn.Size = new System.Drawing.Size(80, 25);
            this.mnMonAn.Text = "Món ăn";
            // 
            // menuDatMon
            // 
            this.menuDatMon.Name = "menuDatMon";
            this.menuDatMon.Size = new System.Drawing.Size(152, 26);
            this.menuDatMon.Text = "Đặt món";
            this.menuDatMon.Click += new System.EventHandler(this.menuDatMon_Click);
            // 
            // mnQL
            // 
            this.mnQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLTaiKhoan,
            this.menuKhachHang,
            this.menuNhanVien,
            this.menuQLMonAn});
            this.mnQL.Name = "mnQL";
            this.mnQL.Size = new System.Drawing.Size(80, 25);
            this.mnQL.Text = "Quản Lí";
            this.mnQL.ToolTipText = "ko dc";
            // 
            // menuQLTaiKhoan
            // 
            this.menuQLTaiKhoan.Name = "menuQLTaiKhoan";
            this.menuQLTaiKhoan.Size = new System.Drawing.Size(172, 26);
            this.menuQLTaiKhoan.Text = "Tài Khoản";
            this.menuQLTaiKhoan.Click += new System.EventHandler(this.menuQLTaiKhoan_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(172, 26);
            this.menuKhachHang.Text = "Khách Hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(172, 26);
            this.menuNhanVien.Text = "Nhân Viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuQLMonAn
            // 
            this.menuQLMonAn.Name = "menuQLMonAn";
            this.menuQLMonAn.Size = new System.Drawing.Size(172, 26);
            this.menuQLMonAn.Text = "Món Ăn";
            this.menuQLMonAn.Click += new System.EventHandler(this.menuQLMonAn_Click);
            // 
            // mnBaoCao
            // 
            this.mnBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoanhThu});
            this.mnBaoCao.Name = "mnBaoCao";
            this.mnBaoCao.Size = new System.Drawing.Size(84, 25);
            this.mnBaoCao.Text = "Báo Cáo";
            // 
            // menuDoanhThu
            // 
            this.menuDoanhThu.Name = "menuDoanhThu";
            this.menuDoanhThu.Size = new System.Drawing.Size(164, 26);
            this.menuDoanhThu.Text = "Doanh Thu";
            this.menuDoanhThu.Click += new System.EventHandler(this.menuDoanhThu_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(102, 25);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 42);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Cyan;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(295, 37);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::THD_DoAnCuoiKi.Properties.Resources.healthy_ingredients_white_wooden_desk_23_2148194994;
            this.ClientSize = new System.Drawing.Size(945, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuSuaTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnMonAn;
        private System.Windows.Forms.ToolStripMenuItem menuDatMon;
        private System.Windows.Forms.ToolStripMenuItem mnQL;
        private System.Windows.Forms.ToolStripMenuItem menuQLTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLMonAn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}