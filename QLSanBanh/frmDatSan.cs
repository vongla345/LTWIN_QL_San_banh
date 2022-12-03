using QLSanBanh.Object;
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
    public partial class frmDatSan : Form
    {
        // sql
        SqlConnection sqlcon;
        SqlCommand cmd;
        string query;
        string insert;
        public string maNhanVien, tenNhanVien;


        // key-value: masan-thoiGianDat  -> để check xem sân có trống không.
        Hashtable ht = new Hashtable();


        // count để lúc cuối insert
        int countDon;   // số Don để +1



        // 2 dòng này dư ...
        public delegate void sendBack(string send);
        public sendBack sendData;

        // connect SQL
        public frmDatSan()
        {
            InitializeComponent();
            //connect database
            sqlcon = sqlcon = new SqlConnection("Data Source=DESKTOP-MQ15825\\VONGLA; Initial Catalog=QLSanbanh;Integrated Security=True;MultipleActiveResultSets=True") ;
            sqlcon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlcon;
        }

        // load variable
        private void datSan_Load(object sender, EventArgs e)
        {
            // hien du lieu thoi gian
            txtTime.Text = "phút";
            txtTime.ForeColor = Color.Gray;

            // thêm sân vào comboBox
            cbType.Items.Add("Sân cỏ nhân tạo");
            cbType.Items.Add("Sân cỏ thật");
            cbType.Items.Add("Sân futsal");


            // thêm size vào comboBox
            cbSize.Items.Add("5");
            cbSize.Items.Add("7");
            cbSize.Items.Add("11");
            /*
            // load data cho hashTable - format của thời gian chỉnh như z để khúc sau so sánh
            query = "select maSan, concat(DATEPART(year,thoiGianDat),'-',DATEPART(month,thoiGianDat),'-',DATEPART(day,thoiGianDat), ' ', DATEPART(hour,thoiGianDat),':',DATEPART(minute,thoiGianDat)), thoiLuong from DonDatSan";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (ht.ContainsKey(reader[0]))
                    {
                        ht[reader[0]] = ht[reader[0]] + "|" + reader[1].ToString() + "~" + reader[2].ToString();
                        // nếu key đã có sân thì nối với nhau bằng dấu '|' -> lúc sau tách ra bằng split
                    }
                    else
                    {
                        ht.Add(reader[0], reader[1].ToString() + "~" + reader[2].ToString());
                        // key: maSan
                        // value: thoiGianDat~keoDai 
                        // khúc sau dùng split tách ra
                    }
                }
                reader.Close();
            }
            */
            
            //countDon
            query = "select count(*) from DonDatSan";
            cmd.CommandText = query;
            var scalar = cmd.ExecuteScalar();
            countDon = int.Parse(scalar.ToString());
            
            /*
            // countNV
            query = "select count(*) from NhanVien";
            cmd.CommandText = query;
            scalar = cmd.ExecuteScalar();
            countNV = int.Parse(scalar.ToString());
            */
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == "" || txtTime.Text.Trim() == "" || cbType.SelectedIndex == -1 || cbSize.SelectedIndex == -1|| cbSelect.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đặt sân?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    query = "select maSan, giaTien from San where tenSan = N'" + cbSelect.Text + "' and loaiSan = N'" + cbType.Text + "' and kichThuoc = '" + cbSize.Text + "'";
                    cmd.CommandText = query;

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            double money = (double.Parse(reader[1].ToString()) * double.Parse(txtTime.Text)) / 60;
                            // txtTime tính bằng phút
                            // giá tiền tính cho mỗi 60 phút
                            insert = "insert into DonDatSan values('" + (++countDon).ToString() + "','" + reader[0].ToString() + "','" + maNhanVien + "',N'" + txtName.Text + "','" + dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txtTime.Text + "','" + money.ToString() + "')";

                            reader.Close();
                            cmd.CommandText = insert;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            bool check = true;
            // kiểm tra đã điền đủ thông tin

            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }

            if (cbType.Text == "")
            {
                errorProvider2.SetError(cbType, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorProvider2.SetError(cbType, "");
            }

            if (cbSize.Text == "")
            {
                errorProvider3.SetError(cbSize, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorProvider3.SetError(cbSize, "");
            }

            if (txtTime.Text == "")
            {
                errorProvider4.SetError(txtTime, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorProvider4.SetError(txtTime, "");
            }


            if (check)
            {

                cbSelect.Items.Clear(); // dọn
                List<string> listSan = new List<string>();

                query = "select maSan, tenSan from San where loaiSan =  N'" + cbType.Text + "' and kichThuoc = '" + cbSize.Text + "'";
                cmd.CommandText = query;

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listSan.Add(reader[0].ToString());
                        /*
                        if (ht.ContainsKey(reader[0])) // nếu sân đã có lịch thì check: ngày, thời gian
                        {
                            bool checkAdd = true;

                            var values = ht[reader[0]].ToString().Split('|'); //tách ra từng lịch đặt [ngày, [giờ, kéo dài]]

                            for (int i = 0; i < values.Length; i++)
                            {
                                // split cái tự chọn
                                var splitDtp = dtpDate.Text.Split(' '); // [ngày, giờ-phút]
                                var splitDtpMore = splitDtp[1].Split(':');// [giờ, phút]

                                double bookingTimeA = double.Parse(splitDtpMore[0]) * 60 + double.Parse(splitDtpMore[1]);
                                double bookingTimeB = bookingTimeA + double.Parse(txtTime.Text);



                                // split từng lịch đã lấy ở trên
                                var splitValue = values[i].Split(' ');  // [ngày, [giờ, kéo dài]]
                                var splitValueMore = splitValue[1].Split('~'); // [giờ, kéo dài]
                                var hourMinute = splitValueMore[0].Split(':');// [giờ, phút]


                                double bookedTimeA = double.Parse(hourMinute[0]) * 60 + double.Parse(hourMinute[1]);
                                double bookedTimeB = bookedTimeA + double.Parse(splitValueMore[1]);




                                if (splitDtp[0] == splitValue[0])
                                {
                                // https://drive.google.com/file/d/1t2-dbXoHCaE4xKJr0qCTXzsqw2ILEcjC/view?usp=share_link
                                // này là ý tưởng tui check thôi, ai có cách xịn hơn hay sài datetime thì đổi lại
                                // A,B là cái đang chọn (booking)
                                // a,b là cái đẵ đặt (booked)
                                    if ((bookingTimeA > bookedTimeA && bookingTimeA < bookedTimeB) ||
                                       (bookingTimeB > bookedTimeA && bookingTimeB < bookedTimeB) ||
                                       (bookedTimeA > bookingTimeA && bookedTimeB < bookingTimeB))
                                    {
                                        checkAdd = false;
                                        break;
                                    }

                                }
                            }

                            if (checkAdd)
                            {
                                cbSelect.Items.Add(reader[1]);
                            }
                        }
                        else // nếu sân chân có lịch nào thì add vào cbSelect
                        {
                            cbSelect.Items.Add(reader[1]);
                        }
                    
                        */
                    }
                    reader.Close();
                    List<string> listMaSan = new List<string>();
                    foreach (string maSan in listSan)
                    {
                        string thoiGianDat = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        int thoiGian = int.Parse(txtTime.Text);
                        query = "select D.maDon, S.maSan, S.tenSan, D.thoiGianDat from San as S, DonDatSan as D where S.maSan = D.maSan  and S.maSan = '" + maSan + " ' and(D.thoiGianDat  between '" + thoiGianDat + "' and DATEADD(minute, 90, '" + thoiGianDat + "') and dateadd(minute, D.thoiLuong, D.thoiGianDat)  between '" + thoiGianDat + "' and DATEADD(minute, 90, '" + thoiGianDat + "'))";

                        cmd.CommandText = query;
                        var readerSan = cmd.ExecuteReader();

                        if (!readerSan.HasRows) listMaSan.Add(maSan);
                        readerSan.Close();
                    }

                    foreach (string maSan in listMaSan)
                    {
                        query = "select tenSan from San where maSan = '" + maSan + "' ";
                        cmd.CommandText = query;
                        var readerTenSan = cmd.ExecuteReader();

                        if (readerTenSan.HasRows)
                        {
                            while(readerTenSan.Read())
                            {
                                cbSelect.Items.Add(readerTenSan[0].ToString());
                            }
                        }
                        readerTenSan.Close();
                    }
                }

                if (cbSelect.Items.Count == 0)
                {
                    MessageBox.Show("Không có sân phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Lọc thành công, hãy chọn tên sân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        // clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            cbType.Text = "";
            cbSize.Text = "";
            cbSelect.Text = "";
            cbSelect.Items.Clear();
        }

        // quit
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ràng buộc txtTime là số
        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                errorProvider4.SetError(txtTime, "Chỉ nhập số");
                e.Handled = true;
            }
            else
            {
                errorProvider4.SetError(txtTime, "");
            }
        }

        private void txtTime_Enter(object sender, EventArgs e)
        {
            if (txtTime.Text =="phút")
            {
                txtTime.Text = "";
                txtTime.ForeColor = Color.Black;
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (txtTime.Text=="")
            {
                txtTime.Text = "phút";
                txtTime.ForeColor = Color.Gray;
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
