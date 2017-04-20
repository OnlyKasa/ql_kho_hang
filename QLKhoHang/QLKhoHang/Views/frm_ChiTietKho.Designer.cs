namespace QLKhoHang.Views
{
    partial class frm_ChiTietKho
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_sua_kh = new System.Windows.Forms.Button();
            this.txt_tong_hang = new System.Windows.Forms.TextBox();
            this.txt_kh_succhua = new System.Windows.Forms.TextBox();
            this.txt_kh_quanly = new System.Windows.Forms.TextBox();
            this.txt_kh_diachi = new System.Windows.Forms.TextBox();
            this.txt_kh_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_chitiet_kho = new System.Windows.Forms.DataGridView();
            this.ct_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hh_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hh_nha_cungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_cap_nhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ct_so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_NhapKho = new System.Windows.Forms.Button();
            this.btn_XuatKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet_kho)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(200, 0);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btn_XuatKho);
            this.splitContainer1.Panel1.Controls.Add(this.btn_NhapKho);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sua_kh);
            this.splitContainer1.Panel1.Controls.Add(this.txt_tong_hang);
            this.splitContainer1.Panel1.Controls.Add(this.txt_kh_succhua);
            this.splitContainer1.Panel1.Controls.Add(this.txt_kh_quanly);
            this.splitContainer1.Panel1.Controls.Add(this.txt_kh_diachi);
            this.splitContainer1.Panel1.Controls.Add(this.txt_kh_id);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_chitiet_kho);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(834, 462);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "(Tấn)";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "(Tấn)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "(Tấn)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thông tin kho hàng";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(172, 221);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(65, 26);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Làm lại";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_sua_kh
            // 
            this.btn_sua_kh.Location = new System.Drawing.Point(243, 221);
            this.btn_sua_kh.Name = "btn_sua_kh";
            this.btn_sua_kh.Size = new System.Drawing.Size(64, 26);
            this.btn_sua_kh.TabIndex = 5;
            this.btn_sua_kh.Text = "Lưu sửa";
            this.btn_sua_kh.UseVisualStyleBackColor = true;
            this.btn_sua_kh.Click += new System.EventHandler(this.btn_sua_kh_Click);
            // 
            // txt_tong_hang
            // 
            this.txt_tong_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tong_hang.Enabled = false;
            this.txt_tong_hang.Location = new System.Drawing.Point(85, 154);
            this.txt_tong_hang.Name = "txt_tong_hang";
            this.txt_tong_hang.Size = new System.Drawing.Size(177, 20);
            this.txt_tong_hang.TabIndex = 4;
            // 
            // txt_kh_succhua
            // 
            this.txt_kh_succhua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kh_succhua.Location = new System.Drawing.Point(85, 126);
            this.txt_kh_succhua.Name = "txt_kh_succhua";
            this.txt_kh_succhua.Size = new System.Drawing.Size(177, 20);
            this.txt_kh_succhua.TabIndex = 4;
            // 
            // txt_kh_quanly
            // 
            this.txt_kh_quanly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kh_quanly.Location = new System.Drawing.Point(85, 98);
            this.txt_kh_quanly.Name = "txt_kh_quanly";
            this.txt_kh_quanly.Size = new System.Drawing.Size(216, 20);
            this.txt_kh_quanly.TabIndex = 3;
            // 
            // txt_kh_diachi
            // 
            this.txt_kh_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kh_diachi.Location = new System.Drawing.Point(85, 70);
            this.txt_kh_diachi.Name = "txt_kh_diachi";
            this.txt_kh_diachi.Size = new System.Drawing.Size(216, 20);
            this.txt_kh_diachi.TabIndex = 2;
            // 
            // txt_kh_id
            // 
            this.txt_kh_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kh_id.Enabled = false;
            this.txt_kh_id.Location = new System.Drawing.Point(85, 42);
            this.txt_kh_id.Name = "txt_kh_id";
            this.txt_kh_id.Size = new System.Drawing.Size(216, 20);
            this.txt_kh_id.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng hàng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sức chứa ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên quản lý ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã kho hàng";
            // 
            // dgv_chitiet_kho
            // 
            this.dgv_chitiet_kho.AllowUserToOrderColumns = true;
            this.dgv_chitiet_kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chitiet_kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitiet_kho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_chitiet_kho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_chitiet_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ct_id,
            this.hh_id,
            this.hh_ten,
            this.hh_nha_cungcap,
            this.ngay_cap_nhat,
            this.ct_so_luong});
            this.dgv_chitiet_kho.Location = new System.Drawing.Point(0, 29);
            this.dgv_chitiet_kho.Name = "dgv_chitiet_kho";
            this.dgv_chitiet_kho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitiet_kho.Size = new System.Drawing.Size(512, 430);
            this.dgv_chitiet_kho.TabIndex = 0;
            // 
            // ct_id
            // 
            this.ct_id.HeaderText = "Mã chi tiết";
            this.ct_id.Name = "ct_id";
            this.ct_id.ReadOnly = true;
            // 
            // hh_id
            // 
            this.hh_id.HeaderText = "Mã hàng hóa ";
            this.hh_id.Name = "hh_id";
            this.hh_id.ReadOnly = true;
            // 
            // hh_ten
            // 
            this.hh_ten.HeaderText = "Tên loại hàng hóa";
            this.hh_ten.Name = "hh_ten";
            this.hh_ten.ReadOnly = true;
            // 
            // hh_nha_cungcap
            // 
            this.hh_nha_cungcap.HeaderText = "Tên nhà cung cấp";
            this.hh_nha_cungcap.Name = "hh_nha_cungcap";
            this.hh_nha_cungcap.ReadOnly = true;
            // 
            // ngay_cap_nhat
            // 
            this.ngay_cap_nhat.HeaderText = "Ngày cập nhật";
            this.ngay_cap_nhat.Name = "ngay_cap_nhat";
            this.ngay_cap_nhat.ReadOnly = true;
            // 
            // ct_so_luong
            // 
            this.ct_so_luong.HeaderText = "Số lượng hàng(tấn)";
            this.ct_so_luong.Name = "ct_so_luong";
            this.ct_so_luong.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thông tin chi tiết kho hàng ";
            // 
            // btn_NhapKho
            // 
            this.btn_NhapKho.Location = new System.Drawing.Point(9, 221);
            this.btn_NhapKho.Name = "btn_NhapKho";
            this.btn_NhapKho.Size = new System.Drawing.Size(75, 26);
            this.btn_NhapKho.TabIndex = 11;
            this.btn_NhapKho.Text = "Nhập Kho";
            this.btn_NhapKho.UseVisualStyleBackColor = true;
            this.btn_NhapKho.Click += new System.EventHandler(this.btn_NhapKho_Click);
            // 
            // btn_XuatKho
            // 
            this.btn_XuatKho.Location = new System.Drawing.Point(91, 221);
            this.btn_XuatKho.Name = "btn_XuatKho";
            this.btn_XuatKho.Size = new System.Drawing.Size(75, 26);
            this.btn_XuatKho.TabIndex = 7;
            this.btn_XuatKho.Text = "Xuat Kho";
            this.btn_XuatKho.UseVisualStyleBackColor = true;
            this.btn_XuatKho.Click += new System.EventHandler(this.btn_XuatKho_Click);
            // 
            // frm_ChiTietKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 458);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_ChiTietKho";
            this.Text = "Thông tin chi tiết kho hàng ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ChiTietKho_FormClosed);
            this.Load += new System.EventHandler(this.ChiTietKho_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet_kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_kh_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kh_succhua;
        private System.Windows.Forms.TextBox txt_kh_quanly;
        private System.Windows.Forms.TextBox txt_kh_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_sua_kh;
        private System.Windows.Forms.DataGridView dgv_chitiet_kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ct_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hh_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn hh_nha_cungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_cap_nhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ct_so_luong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tong_hang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_NhapKho;
        private System.Windows.Forms.Button btn_XuatKho;


    }
}