namespace QLKhoHang.Views
{
    partial class frm_NhapXuat
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
            this.dvg_HoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_ChiTiet = new System.Windows.Forms.Panel();
            this.txt_hh_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_seach_hh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_themChiTiet = new System.Windows.Forms.Button();
            this.btn_hd_Them = new System.Windows.Forms.Button();
            this.txt_hd_nguoiLap = new System.Windows.Forms.TextBox();
            this.txt_hd_ngay_lap = new System.Windows.Forms.TextBox();
            this.txt_hd_Loai = new System.Windows.Forms.TextBox();
            this.txt_hd_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kh_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_HoaDon)).BeginInit();
            this.pan_ChiTiet.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.pan_ChiTiet);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvg_HoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(743, 449);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 1;
            // 
            // dvg_HoaDon
            // 
            this.dvg_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvg_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDon,
            this.maKho,
            this.loaiHoaDon,
            this.ngayLap,
            this.nguoiLap});
            this.dvg_HoaDon.Location = new System.Drawing.Point(3, 3);
            this.dvg_HoaDon.Name = "dvg_HoaDon";
            this.dvg_HoaDon.Size = new System.Drawing.Size(464, 446);
            this.dvg_HoaDon.TabIndex = 0;
            // 
            // maHoaDon
            // 
            this.maHoaDon.HeaderText = "Mã hóa đơn";
            this.maHoaDon.Name = "maHoaDon";
            // 
            // maKho
            // 
            this.maKho.HeaderText = "Mã Kho";
            this.maKho.Name = "maKho";
            // 
            // loaiHoaDon
            // 
            this.loaiHoaDon.HeaderText = "Loại hóa đơn";
            this.loaiHoaDon.Name = "loaiHoaDon";
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.Name = "ngayLap";
            // 
            // nguoiLap
            // 
            this.nguoiLap.HeaderText = "Người lập";
            this.nguoiLap.Name = "nguoiLap";
            // 
            // pan_ChiTiet
            // 
            this.pan_ChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_ChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_ChiTiet.Controls.Add(this.label8);
            this.pan_ChiTiet.Controls.Add(this.btn_seach_hh);
            this.pan_ChiTiet.Controls.Add(this.btn_cancel);
            this.pan_ChiTiet.Controls.Add(this.btnAdd);
            this.pan_ChiTiet.Controls.Add(this.textBox1);
            this.pan_ChiTiet.Controls.Add(this.label7);
            this.pan_ChiTiet.Controls.Add(this.txt_hh_id);
            this.pan_ChiTiet.Controls.Add(this.label6);
            this.pan_ChiTiet.Location = new System.Drawing.Point(3, 235);
            this.pan_ChiTiet.Name = "pan_ChiTiet";
            this.pan_ChiTiet.Size = new System.Drawing.Size(266, 211);
            this.pan_ChiTiet.TabIndex = 13;
            this.pan_ChiTiet.Visible = false;
            // 
            // txt_hh_id
            // 
            this.txt_hh_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hh_id.Location = new System.Drawing.Point(87, 21);
            this.txt_hh_id.Name = "txt_hh_id";
            this.txt_hh_id.Size = new System.Drawing.Size(139, 20);
            this.txt_hh_id.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã hàng hóa ";
            // 
            // btn_seach_hh
            // 
            this.btn_seach_hh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_seach_hh.Location = new System.Drawing.Point(232, 21);
            this.btn_seach_hh.Name = "btn_seach_hh";
            this.btn_seach_hh.Size = new System.Drawing.Size(27, 20);
            this.btn_seach_hh.TabIndex = 12;
            this.btn_seach_hh.Text = "Seach";
            this.btn_seach_hh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Khối lượng";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(87, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "(tấn)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(94, 100);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_themChiTiet);
            this.panel2.Controls.Add(this.btn_hd_Them);
            this.panel2.Controls.Add(this.txt_hd_nguoiLap);
            this.panel2.Controls.Add(this.txt_hd_ngay_lap);
            this.panel2.Controls.Add(this.txt_hd_Loai);
            this.panel2.Controls.Add(this.txt_hd_id);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_kh_id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textLable);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 226);
            this.panel2.TabIndex = 14;
            // 
            // btn_themChiTiet
            // 
            this.btn_themChiTiet.Location = new System.Drawing.Point(90, 189);
            this.btn_themChiTiet.Name = "btn_themChiTiet";
            this.btn_themChiTiet.Size = new System.Drawing.Size(92, 31);
            this.btn_themChiTiet.TabIndex = 25;
            this.btn_themChiTiet.Text = "Thêm chi tiết ";
            this.btn_themChiTiet.UseVisualStyleBackColor = true;
            this.btn_themChiTiet.Click += new System.EventHandler(this.btn_themChiTiet_Click);
            // 
            // btn_hd_Them
            // 
            this.btn_hd_Them.Location = new System.Drawing.Point(9, 190);
            this.btn_hd_Them.Name = "btn_hd_Them";
            this.btn_hd_Them.Size = new System.Drawing.Size(75, 31);
            this.btn_hd_Them.TabIndex = 24;
            this.btn_hd_Them.Text = "Thêm mới";
            this.btn_hd_Them.UseVisualStyleBackColor = true;
            // 
            // txt_hd_nguoiLap
            // 
            this.txt_hd_nguoiLap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hd_nguoiLap.Location = new System.Drawing.Point(91, 163);
            this.txt_hd_nguoiLap.Name = "txt_hd_nguoiLap";
            this.txt_hd_nguoiLap.Size = new System.Drawing.Size(165, 20);
            this.txt_hd_nguoiLap.TabIndex = 19;
            // 
            // txt_hd_ngay_lap
            // 
            this.txt_hd_ngay_lap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hd_ngay_lap.Location = new System.Drawing.Point(91, 134);
            this.txt_hd_ngay_lap.Name = "txt_hd_ngay_lap";
            this.txt_hd_ngay_lap.Size = new System.Drawing.Size(165, 20);
            this.txt_hd_ngay_lap.TabIndex = 20;
            // 
            // txt_hd_Loai
            // 
            this.txt_hd_Loai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hd_Loai.Enabled = false;
            this.txt_hd_Loai.Location = new System.Drawing.Point(91, 106);
            this.txt_hd_Loai.Name = "txt_hd_Loai";
            this.txt_hd_Loai.Size = new System.Drawing.Size(165, 20);
            this.txt_hd_Loai.TabIndex = 21;
            // 
            // txt_hd_id
            // 
            this.txt_hd_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hd_id.Location = new System.Drawing.Point(91, 78);
            this.txt_hd_id.Name = "txt_hd_id";
            this.txt_hd_id.Size = new System.Drawing.Size(165, 20);
            this.txt_hd_id.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Người lập";
            // 
            // txt_kh_id
            // 
            this.txt_kh_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kh_id.Enabled = false;
            this.txt_kh_id.Location = new System.Drawing.Point(91, 50);
            this.txt_kh_id.Name = "txt_kh_id";
            this.txt_kh_id.Size = new System.Drawing.Size(165, 20);
            this.txt_kh_id.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã kho";
            // 
            // textLable
            // 
            this.textLable.AutoSize = true;
            this.textLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLable.Location = new System.Drawing.Point(38, 5);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(0, 37);
            this.textLable.TabIndex = 13;
            // 
            // frm_NhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 455);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_NhapXuat";
            this.Text = "Quản lý nhập xuất hàng hóa ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_HoaDon)).EndInit();
            this.pan_ChiTiet.ResumeLayout(false);
            this.pan_ChiTiet.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dvg_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiLap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_themChiTiet;
        private System.Windows.Forms.Button btn_hd_Them;
        private System.Windows.Forms.TextBox txt_hd_nguoiLap;
        private System.Windows.Forms.TextBox txt_hd_ngay_lap;
        private System.Windows.Forms.TextBox txt_hd_Loai;
        private System.Windows.Forms.TextBox txt_hd_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kh_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textLable;
        private System.Windows.Forms.Panel pan_ChiTiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_seach_hh;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hh_id;
        private System.Windows.Forms.Label label6;
    }
}