namespace THD_DoAnCuoiKi
{
    partial class frmThongKe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdoSoMonMua = new System.Windows.Forms.RadioButton();
            this.rdoTheoHoaDon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdoSoMonMua
            // 
            this.rdoSoMonMua.AutoSize = true;
            this.rdoSoMonMua.Location = new System.Drawing.Point(64, 18);
            this.rdoSoMonMua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdoSoMonMua.Name = "rdoSoMonMua";
            this.rdoSoMonMua.Size = new System.Drawing.Size(232, 24);
            this.rdoSoMonMua.TabIndex = 2;
            this.rdoSoMonMua.TabStop = true;
            this.rdoSoMonMua.Text = "Thống kê theo số món mua";
            this.rdoSoMonMua.UseVisualStyleBackColor = true;
            this.rdoSoMonMua.CheckedChanged += new System.EventHandler(this.rdoDThuTheoTDN_CheckedChanged);
            // 
            // rdoTheoHoaDon
            // 
            this.rdoTheoHoaDon.AutoSize = true;
            this.rdoTheoHoaDon.Location = new System.Drawing.Point(64, 70);
            this.rdoTheoHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdoTheoHoaDon.Name = "rdoTheoHoaDon";
            this.rdoTheoHoaDon.Size = new System.Drawing.Size(208, 24);
            this.rdoTheoHoaDon.TabIndex = 3;
            this.rdoTheoHoaDon.TabStop = true;
            this.rdoTheoHoaDon.Text = "Doanh thu theo hóa đơn";
            this.rdoTheoHoaDon.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTheoHoaDon);
            this.panel1.Controls.Add(this.rdoSoMonMua);
            this.panel1.Location = new System.Drawing.Point(115, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 122);
            this.panel1.TabIndex = 4;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoSoMonMua;
        private System.Windows.Forms.RadioButton rdoTheoHoaDon;
        private System.Windows.Forms.Panel panel1;
    }
}