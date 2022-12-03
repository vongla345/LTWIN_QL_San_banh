using QuanLy_San;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSanBanh
{
    public partial class frmMenu : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        public string tk,tenNV;
        public bool admin = false;
        string query;

        public frmMenu()
        {
            InitializeComponent();

            //connect database
            sqlcon = sqlcon =  new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        

        // bật form datSan
        private void bt_datSan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatSan ds = new frmDatSan();
            ds.maNhanVien = tk;
            ds.tenNhanVien = tenNV;
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }


        // dư
        private void loadData(string send)
        {
            //MessageBox.Show(send);
        }
        private void bt_chiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_qlSan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSan ds = new frmQLSan();
            ds.maNhanVien = tk;
            ds.tenNhanVien = tenNV;
            ds.admin = admin;
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }

        private void bt_qlNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLNhanVien ds = new frmQLNhanVien();
            ds.maNhanVien = tk;
            ds.tenNhanVien = tenNV;
            ds.admin = admin;
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }

        private void bt_dangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin ds = new frmLogin();
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }

        private void bt_thongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKe frm = new frmThongKe();
            frm.maNhanVien = tk;
            frm.tenNhanVien = tenNV;
            frm.FormClosed += (s, args) => this.Close();
            frm.ShowDialog();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_giaiDau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaiDau ds = new frmGiaiDau();
            ds.maNhanVien = tk;
            ds.tenNhanVien = tenNV;
            ds.FormClosed += (s, args) => this.Close();
            ds.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            query = "select tenNV, admin from NhanVien where maNV = N'" + tk +"'";
            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tenNV = reader[0].ToString();
                    if (reader[1].ToString().Trim() == "true") admin = true;
                }
                reader.Close();
            }
            if (admin) lb_tk.Text += "Quản lí ";
            lb_tk.Text += tenNV;
        }
    }
}
