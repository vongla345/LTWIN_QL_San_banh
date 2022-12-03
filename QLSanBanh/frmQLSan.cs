using QLSanBanh;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLy_San
{
    public partial class frmQLSan : Form
    {

        SqlConnection sqlcon;
        SqlCommand cmd;
        string query;
        string insert;
        string delete;
        string update;
        public string maNhanVien, tenNhanVien;
        public bool admin = false;
        public frmQLSan()
        {
            InitializeComponent();

            //connect database
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            query = "select * from San";
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();
            
            while(reader.Read())
            {
                ListViewItem tmpItem = new ListViewItem(reader[0].ToString());
                tmpItem.SubItems.Add(reader[1].ToString());
                tmpItem.SubItems.Add(reader[2].ToString());
                tmpItem.SubItems.Add(reader[3].ToString());
                tmpItem.SubItems.Add(reader[4].ToString());
                listView1.Items.Add(tmpItem);
            }
            reader.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            da.Fill(ds);

            // thêm sân vào comboBox
            cbbox_loai.Items.Add("Sân cỏ nhân tạo");
            cbbox_loai.Items.Add("Sân cỏ thật");
            cbbox_loai.Items.Add("Sân futsal");


            // thêm size vào comboBox
            cbbox_kichthuoc.Items.Add("5");
            cbbox_kichthuoc.Items.Add("7");
            cbbox_kichthuoc.Items.Add("11");
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var x = listView1.SelectedItems[0];

                txt_thongtin_ma.Text = x.SubItems[0].Text;
                txt_thongtin_ten.Text = x.SubItems[1].Text;
                cbbox_loai.Text = x.SubItems[2].Text;
                cbbox_kichthuoc.Text = x.SubItems[3].Text;
                txt_thongtin_giatien.Text = x.SubItems[4].Text;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == txt_thongtin_ma.Text)
                {
                    MessageBox.Show("Mã sân đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }
            }

            bool check = true;
            if (txt_thongtin_ma.Text.Trim() == "" || cbbox_loai.Text.Trim() == "" || txt_thongtin_giatien.Text.Trim() == "" || txt_thongtin_giatien.Text.Trim() == "" || txt_thongtin_ten.Text.Trim() == "")
                check = false;
            
            //
            if (check)
            {
                ListViewItem tmpItem = new ListViewItem(txt_thongtin_ma.Text);
                tmpItem.SubItems.Add(txt_thongtin_ten.Text);
                tmpItem.SubItems.Add(cbbox_loai.Text);
                tmpItem.SubItems.Add(cbbox_kichthuoc.Text);
                tmpItem.SubItems.Add(txt_thongtin_giatien.Text);
                listView1.Items.Add(tmpItem);

                insert = "insert into San values(N'" + txt_thongtin_ma.Text + "',N'" + txt_thongtin_ten.Text + "',N'" + cbbox_loai.Text + "','" + cbbox_kichthuoc.Text + "','" + txt_thongtin_giatien.Text + "')";
                cmd.CommandText = insert;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_thongtin_ma.Text = "";
                txt_thongtin_ten.Text = "";
                cbbox_loai.Text = "";
                cbbox_kichthuoc.Text = "";
                txt_thongtin_giatien.Text = "";
            }
            else
            {
                MessageBox.Show("Thiếu thông tin");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();

                delete = "delete from San where maSan = N'"+txt_thongtin_ma.Text+"'";
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = txt_thongtin_ten.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cbbox_loai.Text;
                listView1.SelectedItems[0].SubItems[3].Text = cbbox_kichthuoc.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txt_thongtin_giatien.Text;

                update = "update San set tenSan = N'" + txt_thongtin_ten.Text + "', loaiSan = N'" + cbbox_loai.Text + "', kichThuoc = '" + cbbox_kichthuoc.Text + "', giaTien = '" + txt_thongtin_giatien.Text + "' where maSan = N'" + txt_thongtin_ma.Text + "'";
                cmd.CommandText = update;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txt_thongtin_ma_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txt_thongtin_ma.Text.Trim() == "")
            {
                errorProvider2.SetError(ctr, "Không bỏ trống");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txt_thongtin_ten_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control )sender;
            if (txt_thongtin_ten.Text.Trim() == "")
            {
                this.errorProvider5.SetError(ctr, "Không bỏ trống");
            }
            else
            {
                this.errorProvider5.Clear();
            }
        }

        private void cbbox_loai_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control )sender;
            if (cbbox_loai.Text.Trim() == "")
            {
                errorProvider3.SetError(ctr, "Không bỏ trống");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void cbbox_kichthuoc_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control )sender;
            if (cbbox_kichthuoc.Text.Trim() == "")
            {
                this.errorProvider6.SetError(ctr, "Không bỏ trống");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txt_thongtin_giatien_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control )sender;
            if (txt_thongtin_giatien.Text.Trim() == "")
            {
                errorProvider4.SetError(ctr, "Không bỏ trống");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_tim_ma.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                query = "select * from San where maSan = N'" + txt_tim_ma.Text + "'";
                cmd.CommandText = query;
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_thongtin_ma.Text = reader.GetString(0);
                        txt_thongtin_ten.Text = reader.GetString(1);
                        cbbox_loai.Text = reader.GetString(2);
                        cbbox_kichthuoc.Text = reader.GetString(3);
                        txt_thongtin_giatien.Text = reader.GetString(4);
                    }

                    reader.Close();
                }
            }
        }

        private void bt_quayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu ds = new frmMenu();
            ds.tk = maNhanVien;
            ds.tenNV = tenNhanVien;
            ds.FormClosed += (s, args) =>this.Close();
            ds.ShowDialog();
        }
    }
}
