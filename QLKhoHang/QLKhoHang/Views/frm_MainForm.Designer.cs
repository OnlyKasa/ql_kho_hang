namespace QLKhoHang.Views
{
    partial class frm_MainForm
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
            this.tabPage_3 = new System.Windows.Forms.TabPage();
            this.tabPage_1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_all_kho = new System.Windows.Forms.DataGridView();
            this.kh_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh_dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh_quan_ly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh_suc_chua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addKhoHang1 = new QLKhoHang.Views.uctrl_AddKhoHang();
            this.btn_them_moi = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_tim_kiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kh_id = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_kho)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_3
            // 
            this.tabPage_3.Location = new System.Drawing.Point(4, 22);
            this.tabPage_3.Name = "tabPage_3";
            this.tabPage_3.Size = new System.Drawing.Size(687, 360);
            this.tabPage_3.TabIndex = 2;
            this.tabPage_3.Text = "Quản lý hàng hóa";
            this.tabPage_3.UseVisualStyleBackColor = true;
            // 
            // tabPage_1
            // 
            this.tabPage_1.Controls.Add(this.panel1);
            this.tabPage_1.Controls.Add(this.addKhoHang1);
            this.tabPage_1.Controls.Add(this.btn_them_moi);
            this.tabPage_1.Controls.Add(this.btn_all);
            this.tabPage_1.Controls.Add(this.btn_tim_kiem);
            this.tabPage_1.Controls.Add(this.label1);
            this.tabPage_1.Controls.Add(this.txt_kh_id);
            this.tabPage_1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_1.Name = "tabPage_1";
            this.tabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_1.Size = new System.Drawing.Size(687, 360);
            this.tabPage_1.TabIndex = 0;
            this.tabPage_1.Text = "Quản lý hệ thống kho";
            this.tabPage_1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_all_kho);
            this.panel1.Location = new System.Drawing.Point(273, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 379);
            this.panel1.TabIndex = 6;
            // 
            // dgv_all_kho
            // 
            this.dgv_all_kho.AllowUserToOrderColumns = true;
            this.dgv_all_kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_all_kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_all_kho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_all_kho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_all_kho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_all_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_all_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kh_id,
            this.kh_dia_chi,
            this.kh_quan_ly,
            this.kh_suc_chua});
            this.dgv_all_kho.Location = new System.Drawing.Point(-2, 13);
            this.dgv_all_kho.Name = "dgv_all_kho";
            this.dgv_all_kho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_all_kho.RowTemplate.ReadOnly = true;
            this.dgv_all_kho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_all_kho.Size = new System.Drawing.Size(414, 371);
            this.dgv_all_kho.TabIndex = 1;
            this.dgv_all_kho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_all_kho_CellClick);
            // 
            // kh_id
            // 
            this.kh_id.DataPropertyName = "kh_id";
            this.kh_id.HeaderText = "Mã kho hàng";
            this.kh_id.Name = "kh_id";
            // 
            // kh_dia_chi
            // 
            this.kh_dia_chi.DataPropertyName = "kh_dia_chi";
            this.kh_dia_chi.HeaderText = "Địa chỉ kho";
            this.kh_dia_chi.Name = "kh_dia_chi";
            // 
            // kh_quan_ly
            // 
            this.kh_quan_ly.DataPropertyName = "kh_quan_ly";
            this.kh_quan_ly.HeaderText = "Quản lý kho";
            this.kh_quan_ly.Name = "kh_quan_ly";
            // 
            // kh_suc_chua
            // 
            this.kh_suc_chua.DataPropertyName = "kh_suc_chua";
            this.kh_suc_chua.HeaderText = "Sức chứa của kho(tấn)";
            this.kh_suc_chua.Name = "kh_suc_chua";
            // 
            // addKhoHang1
            // 
            this.addKhoHang1.Location = new System.Drawing.Point(6, 124);
            this.addKhoHang1.Name = "addKhoHang1";
            this.addKhoHang1.Size = new System.Drawing.Size(250, 214);
            this.addKhoHang1.TabIndex = 5;
            this.addKhoHang1.Visible = false;
            this.addKhoHang1.SubmitClickOK += new QLKhoHang.Views.uctrl_AddKhoHang.SubmitHandler(this.addKhoHang1_SubmitClickOK);
            this.addKhoHang1.SubmitClickCancel += new QLKhoHang.Views.uctrl_AddKhoHang.SubmitHandler(this.addKhoHang1_SubmitClickCancel);
            // 
            // btn_them_moi
            // 
            this.btn_them_moi.Location = new System.Drawing.Point(171, 77);
            this.btn_them_moi.Name = "btn_them_moi";
            this.btn_them_moi.Size = new System.Drawing.Size(85, 28);
            this.btn_them_moi.TabIndex = 4;
            this.btn_them_moi.Text = "Thêm mới";
            this.btn_them_moi.UseVisualStyleBackColor = true;
            this.btn_them_moi.Click += new System.EventHandler(this.btn_them_moi_Click);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(6, 77);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(78, 28);
            this.btn_all.TabIndex = 3;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_tim_kiem
            // 
            this.btn_tim_kiem.Location = new System.Drawing.Point(89, 77);
            this.btn_tim_kiem.Name = "btn_tim_kiem";
            this.btn_tim_kiem.Size = new System.Drawing.Size(78, 28);
            this.btn_tim_kiem.TabIndex = 3;
            this.btn_tim_kiem.Text = "Tìm Kiếm";
            this.btn_tim_kiem.UseVisualStyleBackColor = true;
            this.btn_tim_kiem.Click += new System.EventHandler(this.btn_tim_kiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã kho";
            // 
            // txt_kh_id
            // 
            this.txt_kh_id.Location = new System.Drawing.Point(72, 32);
            this.txt_kh_id.Name = "txt_kh_id";
            this.txt_kh_id.Size = new System.Drawing.Size(184, 20);
            this.txt_kh_id.TabIndex = 1;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage_1);
            this.tabControlMain.Controls.Add(this.tabPage_3);
            this.tabControlMain.Location = new System.Drawing.Point(2, 5);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(695, 386);
            this.tabControlMain.TabIndex = 0;
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 394);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frm_MainForm";
            this.Text = "Quản lý hệ thống kho hàng";
            this.tabPage_1.ResumeLayout(false);
            this.tabPage_1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_kho)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_3;
        private System.Windows.Forms.TabPage tabPage_1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgv_all_kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh_dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh_quan_ly;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh_suc_chua;
        private uctrl_AddKhoHang addKhoHang1;
        private System.Windows.Forms.Button btn_them_moi;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_tim_kiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kh_id;
        private System.Windows.Forms.TabControl tabControlMain;

    }
}