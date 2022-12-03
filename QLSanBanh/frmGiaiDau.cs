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

namespace QLSanBanh
{
    public partial class frmGiaiDau : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        string query;
        string insert;
        string delete;
        string update;
        public string maNhanVien, tenNhanVien;
        int countDon;
        public frmGiaiDau()
        {
            InitializeComponent();
            //
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True");
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        private void bt_taoGiai_Click(object sender, EventArgs e)
        {
            int soDoi = int.Parse(txtb_soDoi.Text);
            int soNgay, soTranMoiNgay;
            if (soDoi%2==0)
            {
                soTranMoiNgay = soDoi / 2;
                soNgay = soDoi - 1;
            }
            else
            {
                soTranMoiNgay = (soDoi - 1) / 2;
                soNgay = soDoi;
            }

            DateTime ngayBatDau = dtp_ngayBatDau.Value;


            query = "select maSan from San where loaiSan =  N'" + cb_loaiSan.Text + "' and kichThuoc = '" + cb_kichThuoc.Text + "'";
            cmd.CommandText = query;
            List<string> maSanDuocChon = new List<string>();

            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int k = 0;
                while(reader.Read())
                {
                    maSanDuocChon.Add(reader[0].ToString());
                    k++;
                    if (k==soTranMoiNgay)
                    {
                        break;
                    }
                }
            }
            reader.Close();

            bool check = true;

            if (maSanDuocChon.Count < soTranMoiNgay)
            {
                MessageBox.Show("Không đủ sân");
                check = false;
            }

            DateTime dayMax = new DateTime();
            query = "select max(thoiGianDat) from DonDatSan";
            cmd.CommandText = query;
            var readerDay = cmd.ExecuteReader();
            if (readerDay.HasRows)
            {
                while(readerDay.Read())
                {
                    dayMax = DateTime.Parse(readerDay[0].ToString());
                }
            }
            readerDay.Close();
            
            if (ngayBatDau <= dayMax.AddMonths(1))
            {
                MessageBox.Show("Ngày không hợp lệ");
                check = false;
            }

           
            DateTime tmpDay = ngayBatDau;
            if (check)
            {
                for (int i = 1; i <= soNgay; i++)
                {
                    tmpDay = ngayBatDau.AddDays(i - 1);
                    for (int j = 1; j <= soTranMoiNgay; j++)
                    {
                        if (j != 1) tmpDay = tmpDay.AddHours(1.5);

                        insert = "insert into DonDatSan values('" + "GDVB" + (++countDon).ToString() + "','" + maSanDuocChon[j - 1] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";

                        cmd.CommandText = insert;
                        cmd.ExecuteNonQuery();


                    }
                }
                tmpDay = ngayBatDau.AddDays(soNgay);
                int soTranVongLoai = 3;
                if (cb_tranh34.Checked) soTranVongLoai += 1;

                // vong ban ket
                insert = "insert into DonDatSan values('" + "GDVBK" + (++countDon).ToString() + "','" + maSanDuocChon[0] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                //
                tmpDay = tmpDay.AddHours(1.5);
                insert = "insert into DonDatSan values('" + "GDBK" + (++countDon).ToString() + "','" + maSanDuocChon[1] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";
                cmd.CommandText = insert;
                cmd.ExecuteNonQuery();
                // neu co tranh 3 4
                if (cb_tranh34.Checked)
                {
                    tmpDay = ngayBatDau.AddDays(soNgay + 1);
                    insert = "insert into DonDatSan values('" + "GDBT" + (++countDon).ToString() + "','" + maSanDuocChon[0] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();

                    tmpDay = tmpDay.AddHours(1.5);
                    insert = "insert into DonDatSan values('" + "GDCK" + (++countDon).ToString() + "','" + maSanDuocChon[1] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    tmpDay = ngayBatDau.AddDays(soNgay + 1);
                    insert = "insert into DonDatSan values('" + "GDCK" + (++countDon).ToString() + "','" + maSanDuocChon[0] + "','" + maNhanVien + "',N'" + txtb_tenDaiDien.Text + "','" + tmpDay.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "90" + "','" + "0" + "')";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tạo giải đấu thành công");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void bt_info_Click(object sender, EventArgs e)
        {
            frmTheThuc ds = new frmTheThuc();
            ds.ShowDialog();
        }

        private void frmGiaiDau_Load(object sender, EventArgs e)
        {
            //
            cb_loaiSan.Items.Add("Sân cỏ thật");
            cb_loaiSan.Items.Add("Sân cỏ nhân tạo");
            cb_loaiSan.Items.Add("Sân futsal");
            //
            cb_kichThuoc.Items.Add("5");
            cb_kichThuoc.Items.Add("7");
            cb_kichThuoc.Items.Add("11");
            //countDon
            query = "select count(*) from DonDatSan";
            cmd.CommandText = query;
            var scalar = cmd.ExecuteScalar();
            countDon = int.Parse(scalar.ToString());
        }
    }
}
