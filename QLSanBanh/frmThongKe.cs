using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace QLSanBanh
{
    public partial class frmThongKe : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        public string maNhanVien, tenNhanVien;
        public frmThongKe()
        {
            InitializeComponent();
            
        }

        
        public void Display()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            try
            {
                string query = "select d.maDon, d.tenNguoiDat, s.tenSan, s.loaiSan, nv.tenNV, d.thoiGianDat, d.thoiLuong, d.tongTien " +
                "from DonDatSan d, San s, NhanVien nv " +
                "where d.maSan = s.maSan and nv.maNV = d.maNV";
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item= new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetString(2));
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetDateTime(5).ToString());
                    item.SubItems.Add(reader.GetInt32(6).ToString());
                    item.SubItems.Add(reader.GetInt32(7).ToString());
                    lst_thongKe.Items.Add(item);
                }
                reader.Close();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            Display();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã đơn";
                    ws.Cells[1, 2] = "Tên khách hàng";
                    ws.Cells[1, 3] = "Tên sân";
                    ws.Cells[1, 4] = "Loại sân";
                    ws.Cells[1, 5] = "Tên nhân viên quản lý";
                    ws.Cells[1, 6] = "Thời gian đặt";
                    ws.Cells[1, 7] = "Thời lượng";
                    ws.Cells[1, 8] = "Tổng tiền";

                    int i = 2;
                    foreach(ListViewItem item in lst_thongKe.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        ws.Cells[i, 8] = item.SubItems[7].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    MessageBox.Show("Đã chuyển thành file excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void bt_quayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu ds = new frmMenu();
            ds.tk = maNhanVien;
            ds.tenNV = tenNhanVien;
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }
    }
}
