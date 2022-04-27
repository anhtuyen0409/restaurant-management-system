namespace THD_DoAnCuoiKi
{
    partial class frmDangNhap
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
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.ckbMatKhau = new System.Windows.Forms.CheckBox();
            this.txtDangNhapMK = new System.Windows.Forms.TextBox();
            this.txtDangNhapTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDangNhap.Controls.Add(this.ckbMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtDangNhapMK);
            this.pnlDangNhap.Controls.Add(this.txtDangNhapTK);
            this.pnlDangNhap.Controls.Add(this.label2);
            this.pnlDangNhap.Controls.Add(this.label1);
            this.pnlDangNhap.Location = new System.Drawing.Point(293, 125);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(379, 137);
            this.pnlDangNhap.TabIndex = 1;
            // 
            // ckbMatKhau
            // 
            this.ckbMatKhau.AutoSize = true;
            this.ckbMatKhau.Location = new System.Drawing.Point(249, 87);
            this.ckbMatKhau.Name = "ckbMatKhau";
            this.ckbMatKhau.Size = new System.Drawing.Size(95, 17);
            this.ckbMatKhau.TabIndex = 4;
            this.ckbMatKhau.Text = "Hiện mật khẩu";
            this.ckbMatKhau.UseVisualStyleBackColor = true;
            this.ckbMatKhau.CheckedChanged += new System.EventHandler(this.ckbMatKhau_CheckedChanged);
            // 
            // txtDangNhapMK
            // 
            this.txtDangNhapMK.Location = new System.Drawing.Point(143, 86);
            this.txtDangNhapMK.Name = "txtDangNhapMK";
            this.txtDangNhapMK.Size = new System.Drawing.Size(100, 20);
            this.txtDangNhapMK.TabIndex = 3;
            this.txtDangNhapMK.Text = "123";
            this.txtDangNhapMK.UseSystemPasswordChar = true;
            // 
            // txtDangNhapTK
            // 
            this.txtDangNhapTK.Location = new System.Drawing.Point(143, 36);
            this.txtDangNhapTK.Name = "txtDangNhapTK";
            this.txtDangNhapTK.Size = new System.Drawing.Size(100, 20);
            this.txtDangNhapTK.TabIndex = 2;
            this.txtDangNhapTK.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(356, 296);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(110, 58);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(520, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::THD_DoAnCuoiKi.Properties.Resources._247988691_264973382091561_3521355960670375351_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(943, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pnlDangNhap);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.TextBox txtDangNhapMK;
        private System.Windows.Forms.TextBox txtDangNhapTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ckbMatKhau;
    }
}

