namespace QLSanBanh
{
    partial class frmGiaiDau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_soDoi = new System.Windows.Forms.TextBox();
            this.txtb_sdt = new System.Windows.Forms.TextBox();
            this.txtb_tenDaiDien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_taoGiai = new System.Windows.Forms.Button();
            this.bt_info = new System.Windows.Forms.Button();
            this.bt_quayVe = new System.Windows.Forms.Button();
            this.cb_tranh34 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ngayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_loaiSan = new System.Windows.Forms.ComboBox();
            this.cb_kichThuoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(447, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI ĐẤU";
            // 
            // txtb_soDoi
            // 
            this.txtb_soDoi.Location = new System.Drawing.Point(767, 141);
            this.txtb_soDoi.Name = "txtb_soDoi";
            this.txtb_soDoi.Size = new System.Drawing.Size(88, 31);
            this.txtb_soDoi.TabIndex = 5;
            // 
            // txtb_sdt
            // 
            this.txtb_sdt.Location = new System.Drawing.Point(231, 198);
            this.txtb_sdt.Name = "txtb_sdt";
            this.txtb_sdt.Size = new System.Drawing.Size(274, 31);
            this.txtb_sdt.TabIndex = 4;
            // 
            // txtb_tenDaiDien
            // 
            this.txtb_tenDaiDien.Location = new System.Drawing.Point(231, 136);
            this.txtb_tenDaiDien.Name = "txtb_tenDaiDien";
            this.txtb_tenDaiDien.Size = new System.Drawing.Size(274, 31);
            this.txtb_tenDaiDien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số đội tham dự:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "SĐT: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên người đại diện: ";
            // 
            // bt_taoGiai
            // 
            this.bt_taoGiai.Location = new System.Drawing.Point(488, 525);
            this.bt_taoGiai.Name = "bt_taoGiai";
            this.bt_taoGiai.Size = new System.Drawing.Size(143, 42);
            this.bt_taoGiai.TabIndex = 10;
            this.bt_taoGiai.Text = "Tạo Giải Đấu";
            this.bt_taoGiai.UseVisualStyleBackColor = true;
            this.bt_taoGiai.Click += new System.EventHandler(this.bt_taoGiai_Click);
            // 
            // bt_info
            // 
            this.bt_info.BackgroundImage = global::QLSanBanh.Properties.Resources.info;
            this.bt_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_info.Location = new System.Drawing.Point(931, 46);
            this.bt_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(49, 43);
            this.bt_info.TabIndex = 62;
            this.bt_info.UseVisualStyleBackColor = true;
            this.bt_info.Click += new System.EventHandler(this.bt_info_Click);
            // 
            // bt_quayVe
            // 
            this.bt_quayVe.BackgroundImage = global::QLSanBanh.Properties.Resources.quayVe;
            this.bt_quayVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_quayVe.Location = new System.Drawing.Point(69, 34);
            this.bt_quayVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_quayVe.Name = "bt_quayVe";
            this.bt_quayVe.Size = new System.Drawing.Size(49, 43);
            this.bt_quayVe.TabIndex = 61;
            this.bt_quayVe.UseVisualStyleBackColor = true;
            this.bt_quayVe.Click += new System.EventHandler(this.bt_quayVe_Click);
            // 
            // cb_tranh34
            // 
            this.cb_tranh34.AutoSize = true;
            this.cb_tranh34.Location = new System.Drawing.Point(621, 417);
            this.cb_tranh34.Name = "cb_tranh34";
            this.cb_tranh34.Size = new System.Drawing.Size(113, 27);
            this.cb_tranh34.TabIndex = 9;
            this.cb_tranh34.Text = "Tranh 3,4";
            this.cb_tranh34.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Bắt Đầu Giải:";
            // 
            // dtp_ngayBatDau
            // 
            this.dtp_ngayBatDau.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayBatDau.Location = new System.Drawing.Point(621, 346);
            this.dtp_ngayBatDau.Name = "dtp_ngayBatDau";
            this.dtp_ngayBatDau.Size = new System.Drawing.Size(270, 31);
            this.dtp_ngayBatDau.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sân:";
            // 
            // cb_loaiSan
            // 
            this.cb_loaiSan.FormattingEnabled = true;
            this.cb_loaiSan.Location = new System.Drawing.Point(144, 346);
            this.cb_loaiSan.Name = "cb_loaiSan";
            this.cb_loaiSan.Size = new System.Drawing.Size(205, 31);
            this.cb_loaiSan.TabIndex = 7;
            this.cb_loaiSan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_kichThuoc
            // 
            this.cb_kichThuoc.FormattingEnabled = true;
            this.cb_kichThuoc.Location = new System.Drawing.Point(144, 415);
            this.cb_kichThuoc.Name = "cb_kichThuoc";
            this.cb_kichThuoc.Size = new System.Drawing.Size(205, 31);
            this.cb_kichThuoc.TabIndex = 7;
            // 
            // frmGiaiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSanBanh.Properties.Resources.cup1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_tenDaiDien);
            this.Controls.Add(this.txtb_sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_soDoi);
            this.Controls.Add(this.cb_kichThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_loaiSan);
            this.Controls.Add(this.bt_quayVe);
            this.Controls.Add(this.bt_taoGiai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_ngayBatDau);
            this.Controls.Add(this.cb_tranh34);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaiDau";
            this.Load += new System.EventHandler(this.frmGiaiDau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_sdt;
        private System.Windows.Forms.TextBox txtb_tenDaiDien;
        private System.Windows.Forms.TextBox txtb_soDoi;
        private System.Windows.Forms.Button bt_taoGiai;
        private System.Windows.Forms.Button bt_quayVe;
        private System.Windows.Forms.Button bt_info;
        private System.Windows.Forms.CheckBox cb_tranh34;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ngayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_loaiSan;
        private System.Windows.Forms.ComboBox cb_kichThuoc;
    }
}