
namespace QuanLy_San
{
    partial class frmQLSan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tim_ma = new System.Windows.Forms.Label();
            this.grp_timkiem = new System.Windows.Forms.GroupBox();
            this.txt_tim_ma = new System.Windows.Forms.TextBox();
            this.grp_thongtin = new System.Windows.Forms.GroupBox();
            this.txt_thongtin_giatien = new System.Windows.Forms.TextBox();
            this.txt_thongtin_ten = new System.Windows.Forms.TextBox();
            this.cbbox_kichthuoc = new System.Windows.Forms.ComboBox();
            this.cbbox_loai = new System.Windows.Forms.ComboBox();
            this.lbl_thongtin_ten = new System.Windows.Forms.Label();
            this.lbl_thongtin_loai = new System.Windows.Forms.Label();
            this.lbl_thongtin_kichthuoc = new System.Windows.Forms.Label();
            this.lbl_thongtin_giatien = new System.Windows.Forms.Label();
            this.txt_thongtin_ma = new System.Windows.Forms.TextBox();
            this.lbl_thongtin_ma = new System.Windows.Forms.Label();
            this.grp_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_quayVe = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.grp_timkiem.SuspendLayout();
            this.grp_thongtin.SuspendLayout();
            this.grp_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 31.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(396, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÂN BÓNG";
            // 
            // lbl_tim_ma
            // 
            this.lbl_tim_ma.AutoSize = true;
            this.lbl_tim_ma.Location = new System.Drawing.Point(61, 39);
            this.lbl_tim_ma.Name = "lbl_tim_ma";
            this.lbl_tim_ma.Size = new System.Drawing.Size(75, 23);
            this.lbl_tim_ma.TabIndex = 1;
            this.lbl_tim_ma.Text = "Mã sân:";
            // 
            // grp_timkiem
            // 
            this.grp_timkiem.Controls.Add(this.btn_timKiem);
            this.grp_timkiem.Controls.Add(this.txt_tim_ma);
            this.grp_timkiem.Controls.Add(this.lbl_tim_ma);
            this.grp_timkiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_timkiem.Location = new System.Drawing.Point(33, 79);
            this.grp_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_timkiem.Name = "grp_timkiem";
            this.grp_timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_timkiem.Size = new System.Drawing.Size(475, 122);
            this.grp_timkiem.TabIndex = 2;
            this.grp_timkiem.TabStop = false;
            this.grp_timkiem.Text = "Tìm kiếm";
            // 
            // txt_tim_ma
            // 
            this.txt_tim_ma.Location = new System.Drawing.Point(23, 71);
            this.txt_tim_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim_ma.Multiline = true;
            this.txt_tim_ma.Name = "txt_tim_ma";
            this.txt_tim_ma.Size = new System.Drawing.Size(195, 38);
            this.txt_tim_ma.TabIndex = 5;
            this.txt_tim_ma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grp_thongtin
            // 
            this.grp_thongtin.Controls.Add(this.txt_thongtin_giatien);
            this.grp_thongtin.Controls.Add(this.txt_thongtin_ten);
            this.grp_thongtin.Controls.Add(this.cbbox_kichthuoc);
            this.grp_thongtin.Controls.Add(this.cbbox_loai);
            this.grp_thongtin.Controls.Add(this.lbl_thongtin_ten);
            this.grp_thongtin.Controls.Add(this.lbl_thongtin_loai);
            this.grp_thongtin.Controls.Add(this.lbl_thongtin_kichthuoc);
            this.grp_thongtin.Controls.Add(this.lbl_thongtin_giatien);
            this.grp_thongtin.Controls.Add(this.txt_thongtin_ma);
            this.grp_thongtin.Controls.Add(this.lbl_thongtin_ma);
            this.grp_thongtin.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_thongtin.Location = new System.Drawing.Point(33, 214);
            this.grp_thongtin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_thongtin.Name = "grp_thongtin";
            this.grp_thongtin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_thongtin.Size = new System.Drawing.Size(475, 271);
            this.grp_thongtin.TabIndex = 3;
            this.grp_thongtin.TabStop = false;
            this.grp_thongtin.Text = "Thông tin";
            // 
            // txt_thongtin_giatien
            // 
            this.txt_thongtin_giatien.Location = new System.Drawing.Point(23, 231);
            this.txt_thongtin_giatien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thongtin_giatien.Multiline = true;
            this.txt_thongtin_giatien.Name = "txt_thongtin_giatien";
            this.txt_thongtin_giatien.Size = new System.Drawing.Size(172, 29);
            this.txt_thongtin_giatien.TabIndex = 13;
            this.txt_thongtin_giatien.Leave += new System.EventHandler(this.txt_thongtin_giatien_Leave);
            // 
            // txt_thongtin_ten
            // 
            this.txt_thongtin_ten.Location = new System.Drawing.Point(272, 70);
            this.txt_thongtin_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thongtin_ten.Multiline = true;
            this.txt_thongtin_ten.Name = "txt_thongtin_ten";
            this.txt_thongtin_ten.Size = new System.Drawing.Size(172, 29);
            this.txt_thongtin_ten.TabIndex = 12;
            this.txt_thongtin_ten.Leave += new System.EventHandler(this.txt_thongtin_ten_Leave);
            // 
            // cbbox_kichthuoc
            // 
            this.cbbox_kichthuoc.FormattingEnabled = true;
            this.cbbox_kichthuoc.Location = new System.Drawing.Point(273, 146);
            this.cbbox_kichthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbox_kichthuoc.Name = "cbbox_kichthuoc";
            this.cbbox_kichthuoc.Size = new System.Drawing.Size(172, 29);
            this.cbbox_kichthuoc.TabIndex = 11;
            this.cbbox_kichthuoc.Leave += new System.EventHandler(this.cbbox_kichthuoc_Leave);
            // 
            // cbbox_loai
            // 
            this.cbbox_loai.FormattingEnabled = true;
            this.cbbox_loai.Location = new System.Drawing.Point(23, 146);
            this.cbbox_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbox_loai.Name = "cbbox_loai";
            this.cbbox_loai.Size = new System.Drawing.Size(172, 29);
            this.cbbox_loai.TabIndex = 10;
            this.cbbox_loai.Leave += new System.EventHandler(this.cbbox_loai_Leave);
            // 
            // lbl_thongtin_ten
            // 
            this.lbl_thongtin_ten.AutoSize = true;
            this.lbl_thongtin_ten.Location = new System.Drawing.Point(268, 38);
            this.lbl_thongtin_ten.Name = "lbl_thongtin_ten";
            this.lbl_thongtin_ten.Size = new System.Drawing.Size(76, 22);
            this.lbl_thongtin_ten.TabIndex = 9;
            this.lbl_thongtin_ten.Text = "Tên sân:";
            // 
            // lbl_thongtin_loai
            // 
            this.lbl_thongtin_loai.AutoSize = true;
            this.lbl_thongtin_loai.Location = new System.Drawing.Point(19, 118);
            this.lbl_thongtin_loai.Name = "lbl_thongtin_loai";
            this.lbl_thongtin_loai.Size = new System.Drawing.Size(81, 22);
            this.lbl_thongtin_loai.TabIndex = 8;
            this.lbl_thongtin_loai.Text = "Loại sân:";
            // 
            // lbl_thongtin_kichthuoc
            // 
            this.lbl_thongtin_kichthuoc.AutoSize = true;
            this.lbl_thongtin_kichthuoc.Location = new System.Drawing.Point(268, 118);
            this.lbl_thongtin_kichthuoc.Name = "lbl_thongtin_kichthuoc";
            this.lbl_thongtin_kichthuoc.Size = new System.Drawing.Size(101, 22);
            this.lbl_thongtin_kichthuoc.TabIndex = 7;
            this.lbl_thongtin_kichthuoc.Text = "Kích thước:";
            // 
            // lbl_thongtin_giatien
            // 
            this.lbl_thongtin_giatien.AutoSize = true;
            this.lbl_thongtin_giatien.Location = new System.Drawing.Point(19, 198);
            this.lbl_thongtin_giatien.Name = "lbl_thongtin_giatien";
            this.lbl_thongtin_giatien.Size = new System.Drawing.Size(76, 22);
            this.lbl_thongtin_giatien.TabIndex = 6;
            this.lbl_thongtin_giatien.Text = "Giá tiền:";
            // 
            // txt_thongtin_ma
            // 
            this.txt_thongtin_ma.Location = new System.Drawing.Point(23, 70);
            this.txt_thongtin_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_thongtin_ma.Multiline = true;
            this.txt_thongtin_ma.Name = "txt_thongtin_ma";
            this.txt_thongtin_ma.Size = new System.Drawing.Size(172, 29);
            this.txt_thongtin_ma.TabIndex = 5;
            this.txt_thongtin_ma.Leave += new System.EventHandler(this.txt_thongtin_ma_Leave);
            // 
            // lbl_thongtin_ma
            // 
            this.lbl_thongtin_ma.AutoSize = true;
            this.lbl_thongtin_ma.Location = new System.Drawing.Point(19, 38);
            this.lbl_thongtin_ma.Name = "lbl_thongtin_ma";
            this.lbl_thongtin_ma.Size = new System.Drawing.Size(72, 22);
            this.lbl_thongtin_ma.TabIndex = 1;
            this.lbl_thongtin_ma.Text = "Mã sân:";
            // 
            // grp_chucnang
            // 
            this.grp_chucnang.Controls.Add(this.btn_dong);
            this.grp_chucnang.Controls.Add(this.btn_sua);
            this.grp_chucnang.Controls.Add(this.btn_xoa);
            this.grp_chucnang.Controls.Add(this.btn_them);
            this.grp_chucnang.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_chucnang.Location = new System.Drawing.Point(33, 498);
            this.grp_chucnang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_chucnang.Name = "grp_chucnang";
            this.grp_chucnang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_chucnang.Size = new System.Drawing.Size(475, 185);
            this.grp_chucnang.TabIndex = 6;
            this.grp_chucnang.TabStop = false;
            this.grp_chucnang.Text = "Chức năng";
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_dong.Location = new System.Drawing.Point(273, 110);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(171, 42);
            this.btn_dong.TabIndex = 7;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_sua.Location = new System.Drawing.Point(273, 46);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(171, 42);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa sân";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_xoa.Location = new System.Drawing.Point(23, 110);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(171, 42);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa sân";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_them.Location = new System.Drawing.Point(23, 46);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(171, 42);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm sân";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(596, 95);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 528);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sân";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sân";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại sân";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kích thước";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá tiền";
            this.columnHeader5.Width = 70;
            // 
            // bt_quayVe
            // 
            this.bt_quayVe.BackgroundImage = global::QLSanBanh.Properties.Resources.quayVe;
            this.bt_quayVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_quayVe.Location = new System.Drawing.Point(45, 22);
            this.bt_quayVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_quayVe.Name = "bt_quayVe";
            this.bt_quayVe.Size = new System.Drawing.Size(49, 43);
            this.bt_quayVe.TabIndex = 9;
            this.bt_quayVe.UseVisualStyleBackColor = true;
            this.bt_quayVe.Click += new System.EventHandler(this.bt_quayVe_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_timKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_timKiem.Location = new System.Drawing.Point(273, 71);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(117, 35);
            this.btn_timKiem.TabIndex = 6;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // frmQLSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1255, 674);
            this.Controls.Add(this.bt_quayVe);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grp_chucnang);
            this.Controls.Add(this.grp_thongtin);
            this.Controls.Add(this.grp_timkiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQLSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sân bóng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_timkiem.ResumeLayout(false);
            this.grp_timkiem.PerformLayout();
            this.grp_thongtin.ResumeLayout(false);
            this.grp_thongtin.PerformLayout();
            this.grp_chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tim_ma;
        private System.Windows.Forms.GroupBox grp_timkiem;
        private System.Windows.Forms.TextBox txt_tim_ma;
        private System.Windows.Forms.GroupBox grp_thongtin;
        private System.Windows.Forms.TextBox txt_thongtin_giatien;
        private System.Windows.Forms.TextBox txt_thongtin_ten;
        private System.Windows.Forms.ComboBox cbbox_kichthuoc;
        private System.Windows.Forms.ComboBox cbbox_loai;
        private System.Windows.Forms.Label lbl_thongtin_ten;
        private System.Windows.Forms.Label lbl_thongtin_loai;
        private System.Windows.Forms.Label lbl_thongtin_kichthuoc;
        private System.Windows.Forms.Label lbl_thongtin_giatien;
        private System.Windows.Forms.TextBox txt_thongtin_ma;
        private System.Windows.Forms.Label lbl_thongtin_ma;
        private System.Windows.Forms.GroupBox grp_chucnang;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button bt_quayVe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Button btn_timKiem;
    }
}

