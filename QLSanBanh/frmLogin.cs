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

namespace QLSanBanh
{
    public partial class frmLogin : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        string query;

        public frmLogin()
        {
            InitializeComponent();

            //connect database
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string tk = txtb_tk.Text;
            string pass = txtb_pass.Text;

            query = "select maNV, matKhau from NhanVien where maNV = N'" + tk + "'";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (pass != reader[1].ToString())
                    {
                        MessageBox.Show("Sai mật khấu", "Thông báo", MessageBoxButtons.OK);
                        txtb_pass.Clear();
                        txtb_pass.Focus();
                        break;
                    }
                    else
                    {
                        DialogResult r = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                        if (r == DialogResult.OK)
                        {
                            this.Hide();
                            frmMenu ds = new frmMenu();
                            ds.tk = txtb_tk.Text;
                            ds.FormClosed += (s, args) => this.Close();
                            ds.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK);
                txtb_tk.Clear();
                txtb_pass.Clear();
                txtb_tk.Focus();
            }
            reader.Close();

        }

        private void txtb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }
    }
}
