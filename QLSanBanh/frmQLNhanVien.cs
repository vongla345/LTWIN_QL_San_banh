using QLSanBanh.Object;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QLSanBanh
{
    public partial class frmQLNhanVien : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        string query;
        string insert;
        string delete;
        string update;
        public string maNhanVien, tenNhanVien;
        public bool admin = false;
        List <NhanVien> listNV = new List<NhanVien>();

        public frmQLNhanVien()
        {
            InitializeComponent();

            //connect database
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            // them du lieu
            query = "select * from NhanVien";
            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    bool isAdmin;
                    if (reader[7].ToString().Trim() == "true") isAdmin = true;
                    else isAdmin = false;

                    NhanVien y = new NhanVien(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), DateTime.Parse(reader[3].ToString()), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),isAdmin);
                    listNV.Add(y);  

                    var tmpItem = new ListViewItem(reader[0].ToString());
                    tmpItem.SubItems.Add(reader[1].ToString());
                    tmpItem.SubItems.Add(reader[2].ToString());
                    tmpItem.SubItems.Add(reader[3].ToString());
                    tmpItem.SubItems.Add(reader[4].ToString());
                    tmpItem.SubItems.Add(reader[5].ToString());
                    if (isAdmin) tmpItem.SubItems.Add("Quản Lí");
                    else tmpItem.SubItems.Add("Nhân Viên");
                    lsvNhanVien.Items.Add(tmpItem);
                }

                reader.Close();
            }
            // quan li nhan vien cua admin
            if (admin) groupBox1.Enabled = true;
            else groupBox1.Enabled = false;


            // them gioi tinh
            cbb_gioiTinh.Items.Add("Nam");
            cbb_gioiTinh.Items.Add("Nữ");
            cbb_gioiTinh.SelectedIndex= 0;
            //
            txtb_tim.Text = "Nhập mã nhân viên";
            txtb_tim.ForeColor = Color.Gray;
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                var x = lsvNhanVien.SelectedItems[0];

                txtb_maNV.Text = x.SubItems[0].Text;
                txtb_ten.Text = x.SubItems[1].Text;
                cbb_gioiTinh.Text = x.SubItems[2].Text;
                dtp_ngaySinh.Text = x.SubItems[3].Text;
                txtb_sdt.Text = x.SubItems[4].Text;
                txtb_diaChi.Text = x.SubItems[5].Text;
                if (x.SubItems[6].Text == "Quản Lí") cb_admin.CheckState = CheckState.Checked;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string mnv = txtb_maNV.Text;
            bool check = true;
            if (txtb_maNV.Text.Trim() == "" || txtb_ten.Text.Trim() == "" || cbb_gioiTinh.SelectedIndex== -1 ||txtb_matKhau.Text.Trim()=="" || txtb_reMatKhau.Text.Trim() == "" || txtb_sdt.Text.Trim() == "" || txtb_diaChi.Text.Trim() == "")
            {
                check = false;
                MessageBox.Show("Không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem i in lsvNhanVien.Items)
                {
                    if (i.SubItems[0].Text == mnv)
                    {
                        check = false;
                        MessageBox.Show("Trùng mã NV");
                        txtb_maNV.Clear();
                        txtb_maNV.Focus();
                        return;
                    }
                }

                if (txtb_matKhau.Text != txtb_reMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    txtb_reMatKhau.Clear();
                    txtb_reMatKhau.Focus();
                    check = false;
                }
                else check = true;

                if (txtb_matKhau.Text.Trim() == "" || txtb_reMatKhau.Text.Trim() == "")
                {
                    check = false;
                    MessageBox.Show("Mật Khẩu Không Được Để Trống", "Thông báo", MessageBoxButtons.OK);
                    txtb_matKhau.Focus();
                }
                else check = true;

                if (check)
                {
                    string checkAdmin = "false";
                    var tmpItem = new ListViewItem(txtb_maNV.Text);
                    tmpItem.SubItems.Add(txtb_ten.Text);
                    tmpItem.SubItems.Add(cbb_gioiTinh.Text);
                    tmpItem.SubItems.Add(dtp_ngaySinh.Text);
                    tmpItem.SubItems.Add(txtb_sdt.Text);
                    tmpItem.SubItems.Add(txtb_diaChi.Text);
                    if (cb_admin.Checked)
                    {
                        tmpItem.SubItems.Add("Quản Lí");
                        checkAdmin = "true";
                    }
                    else
                    {
                        tmpItem.SubItems.Add("Nhân Viên");
                        checkAdmin = "false";
                    }
                    lsvNhanVien.Items.Add(tmpItem);

                    insert = "insert into NhanVien values(N'" + txtb_maNV.Text + "',N'" + txtb_ten.Text + "',N'" + cbb_gioiTinh.Text + "','" + dtp_ngaySinh.Value.ToString("yyyy-MM-dd") + "','" + txtb_sdt.Text + "',N'" + txtb_diaChi.Text + "', '" + txtb_matKhau.Text + "', '" + checkAdmin + "')";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count>0)
            {
                bool check = true;
                if (txtb_matKhau.Text != txtb_reMatKhau.Text)
                {
                    check = false;
                    MessageBox.Show("Mật khẩu không trùng nhau, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    txtb_reMatKhau.Clear();
                    txtb_reMatKhau.Focus();
                }
                else check = true;

                if (txtb_matKhau.Text.Trim() == "" || txtb_reMatKhau.Text.Trim() == "")
                {
                    check = false;
                    MessageBox.Show("Mật Khẩu Không Được Để Trống", "Thông báo", MessageBoxButtons.OK);
                    txtb_matKhau.Focus();
                }
                else check = true;

                if (check)
                {
                    string checkAdmin = "false";

                    lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtb_maNV.Text;
                    lsvNhanVien.SelectedItems[0].SubItems[1].Text = txtb_ten.Text;
                    lsvNhanVien.SelectedItems[0].SubItems[2].Text = cbb_gioiTinh.Text;
                    lsvNhanVien.SelectedItems[0].SubItems[3].Text = dtp_ngaySinh.Value.ToString("yyyy-MM-dd");
                    lsvNhanVien.SelectedItems[0].SubItems[4].Text = txtb_sdt.Text;
                    lsvNhanVien.SelectedItems[0].SubItems[5].Text = txtb_diaChi.Text;
                    if (cb_admin.Checked)
                    {
                        lsvNhanVien.SelectedItems[0].SubItems[6].Text = "Quản Lí";
                        checkAdmin = "true";
                    }
                    else
                    {
                        lsvNhanVien.SelectedItems[0].SubItems[6].Text = "Nhân Viên";
                        checkAdmin = "false";
                    }
                    update = "update NhanVien set tenNV = N'" + txtb_ten.Text + "', gioiTinh = N'" + cbb_gioiTinh.Text + "', ngaySinh = '" + dtp_ngaySinh.Value.ToString("yyyy-MM-dd") + "', sdt = '" + txtb_sdt.Text + "', diaChi = N'" + txtb_diaChi.Text + "', matKhau = '" + txtb_matKhau.Text + "', admin = '" + checkAdmin + "' where maNV = N'" + txtb_maNV.Text + "'";
                    cmd.CommandText = update;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count>0)
            {
                lsvNhanVien.SelectedItems[0].Remove();

                delete = " delete from NhanVien where maNV = N'" + txtb_maNV.Text + "'";
                cmd.CommandText= delete;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtb_reMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtb_tim.Text =="Nhập mã nhân viên")
            {
                txtb_tim.Text = "";
                txtb_tim.ForeColor = Color.Black;
            }
        }

        private void txtb_tim_Leave(object sender, EventArgs e)
        {
            if (txtb_tim.Text=="")
            {
                txtb_tim.Text = "Nhập mã nhân viên";
                txtb_tim.ForeColor = Color.Gray;
            }
        }

        private void txtb_sdt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtb_maNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtb_ten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtb_diaChi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtb_maNV_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtb_maNV.Text.Trim() == "")
            {
                this.errorProvider1.SetError(ctr, "Không được để trống");
            }
            else this.errorProvider1.Clear();
        }

        private void txtb_ten_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtb_ten.Text.Trim() == "")
            {
                this.errorProvider2.SetError(ctr, "Không được để trống");
            }
            else this.errorProvider2.Clear();
        }

        private void txtb_matKhau_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtb_matKhau.Text.Trim() == "")
            {
                this.errorProvider4.SetError(ctr, "Không được để trống");
            }
            else this.errorProvider4.Clear();
        }

        private void txtb_sdt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtb_sdt.Text.Trim() == "")
            {
                this.errorProvider3.SetError(ctr, "Không được để trống");
            }
            else this.errorProvider3.Clear();
        }

        private void txtb_diaChi_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtb_diaChi.Text.Trim() == "")
            {
                this.errorProvider5.SetError(ctr, "Không được để trống");
            }
            else this.errorProvider5.Clear();
        }

        private void txtb_reMatKhau_Leave(object sender, EventArgs e)
        {
            Control control= (Control)sender;
            if(txtb_reMatKhau.Text.Trim() == "")
            {
                this.errorProvider6.SetError(control, "Không được để trống");
            }
            else
            {
                this.errorProvider6.Clear();
            }
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            if(txtb_tim.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần tìm", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                
                query = "select * from NhanVien where maNV = N'" + txtb_tim.Text + "'";
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtb_maNV.Text = reader.GetString(0);
                    txtb_ten.Text = reader.GetString(1);
                    cbb_gioiTinh.Text = reader.GetString(2);
                    dtp_ngaySinh.Text = reader.GetDateTime(3).ToString();
                    txtb_sdt.Text = reader.GetString(4);
                    txtb_diaChi.Text = reader.GetString(5);
                }

                reader.Close();
            }
            
        }
    }
}
