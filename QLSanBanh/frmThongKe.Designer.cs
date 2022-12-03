namespace QLSanBanh
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
            this.lst_thongKe = new System.Windows.Forms.ListView();
            this.maDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenSan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaiSan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thoiGian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thoiLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_quayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_thongKe
            // 
            this.lst_thongKe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maDon,
            this.tenKH,
            this.tenSan,
            this.loaiSan,
            this.tenNV,
            this.thoiGian,
            this.thoiLuong,
            this.tongTien});
            this.lst_thongKe.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_thongKe.GridLines = true;
            this.lst_thongKe.HideSelection = false;
            this.lst_thongKe.Location = new System.Drawing.Point(41, 103);
            this.lst_thongKe.Name = "lst_thongKe";
            this.lst_thongKe.Size = new System.Drawing.Size(1009, 460);
            this.lst_thongKe.TabIndex = 0;
            this.lst_thongKe.UseCompatibleStateImageBehavior = false;
            this.lst_thongKe.View = System.Windows.Forms.View.Details;
            // 
            // maDon
            // 
            this.maDon.Text = "Mã đơn";
            this.maDon.Width = 80;
            // 
            // tenKH
            // 
            this.tenKH.Text = "Tên khách hàng";
            this.tenKH.Width = 125;
            // 
            // tenSan
            // 
            this.tenSan.Text = "Tên sân";
            this.tenSan.Width = 128;
            // 
            // loaiSan
            // 
            this.loaiSan.Text = "Loại sân";
            this.loaiSan.Width = 90;
            // 
            // tenNV
            // 
            this.tenNV.Text = "Tên nhân viên quản lý";
            this.tenNV.Width = 180;
            // 
            // thoiGian
            // 
            this.thoiGian.Text = "Thời gian đặt";
            this.thoiGian.Width = 110;
            // 
            // thoiLuong
            // 
            this.thoiLuong.Text = "Thời lượng";
            this.thoiLuong.Width = 103;
            // 
            // tongTien
            // 
            this.tongTien.Text = "Tổng tiền";
            this.tongTien.Width = 109;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(896, 48);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(154, 37);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Xuất File Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // bt_quayVe
            // 
            this.bt_quayVe.BackgroundImage = global::QLSanBanh.Properties.Resources.quayVe;
            this.bt_quayVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_quayVe.Location = new System.Drawing.Point(41, 42);
            this.bt_quayVe.Name = "bt_quayVe";
            this.bt_quayVe.Size = new System.Drawing.Size(49, 43);
            this.bt_quayVe.TabIndex = 14;
            this.bt_quayVe.UseVisualStyleBackColor = true;
            this.bt_quayVe.Click += new System.EventHandler(this.bt_quayVe_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSanBanh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1080, 607);
            this.Controls.Add(this.bt_quayVe);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lst_thongKe);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_thongKe;
        private System.Windows.Forms.ColumnHeader maDon;
        private System.Windows.Forms.ColumnHeader tenKH;
        private System.Windows.Forms.ColumnHeader tenSan;
        private System.Windows.Forms.ColumnHeader tenNV;
        private System.Windows.Forms.ColumnHeader thoiGian;
        private System.Windows.Forms.ColumnHeader thoiLuong;
        private System.Windows.Forms.ColumnHeader tongTien;
        private System.Windows.Forms.ColumnHeader loaiSan;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_quayVe;
    }
}