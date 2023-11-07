using Quanlikho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlikho.Controller;
using Quanlikho.Utils;
namespace Quanlikho.Views
{

    public partial class SRM_BenhNhan : Form
    {
        BenhnhanController controller;
        List<Benhnhan> benhnhan;
        Benhnhan currentBenhnhan;
        List<Benhnhan> benhnhan2;
        public SRM_BenhNhan()
        {
            InitializeComponent();
            benhnhan2 = new List<Benhnhan>();
            controller = new BenhnhanController();
            benhnhan = new List<Benhnhan>();
            currentBenhnhan = new Benhnhan();
            Xem.ColumnCount = 5;
            Xem.Columns[0].Name = "Mã Bệnh Nhân";
            Xem.Columns[1].Name = "Tên Bệnh Nhân";
            Xem.Columns[2].Name = "Tuổi";
            Xem.Columns[3].Name = "Giới Tính";
            Xem.Columns[4].Name = "Địa Chỉ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Xem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Xem.SelectedRows)
                {
                    currentBenhnhan = new Benhnhan(text_mabenhnhan.Text, text_tenbenhnhan.Text, Convert.ToInt32(text_tuoi.Text), text_gioitinh.Text, text_diachi.Text);

                    bool updated = controller.update(currentBenhnhan);

                    if (updated)
                    {
                        MessageBox.Show("Đã sửa thành công!");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy đối tượng muốn sửa!");
            }
            button_load_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maKhoToSearch = text_tim.Text;
            if (!string.IsNullOrEmpty(maKhoToSearch))
            {
                benhnhan2 = benhnhan.Where(k => k.getMabenhnhan() == maKhoToSearch).ToList();
            }
            else
            {
                benhnhan2 = benhnhan;
            }
            Xem.Rows.Clear();
            foreach (Benhnhan kho in benhnhan2)
            {
                String[] row = { kho.getMabenhnhan(), kho.getTenbenhnhan(), kho.getTuoi().ToString() , kho.getGioitinh(), kho.getDiachi() };
                Xem.Rows.Add(row);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Xem.SelectedRows.Count == 0)
            {
                // Thông báo lỗi
                MessageBox.Show("Vui lòng chọn một hàng trong DataGridView.");
                return;
            }

            // Lấy đối tượng DataGridViewRow của hàng được chọn
            DataGridViewRow row = Xem.SelectedRows[0];

            // Lấy giá trị của các ô trong hàng được chọn
            text_mabenhnhan.Text = row.Cells[0].Value.ToString();
            text_tenbenhnhan.Text = row.Cells[1].Value.ToString();
            text_tuoi.Text = row.Cells[2].Value.ToString();
            text_gioitinh.Text = row.Cells[3].Value.ToString();
            text_diachi.Text = row.Cells[4].Value.ToString();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            currentBenhnhan = new Benhnhan(text_mabenhnhan.Text, text_tenbenhnhan.Text, Convert.ToInt32(text_tuoi.Text), text_gioitinh.Text, text_diachi.Text);
            bool test = controller.isExist(currentBenhnhan);
            if (test)
            {
                MessageBox.Show("Mã kho đã tồn tại!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(text_mabenhnhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân.");
                }
                else if (string.IsNullOrWhiteSpace(text_tenbenhnhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên bệnh nhân.");
                }
                else if (string.IsNullOrWhiteSpace(text_tuoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập tuổi bệnh nhân.");
                }
                else if (string.IsNullOrWhiteSpace(text_gioitinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập giới tính bệnh nhân.");
                }
                else if (string.IsNullOrWhiteSpace(text_diachi.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ bệnh nhân.");
                }
                else
                {
                    bool add = controller.insert(currentBenhnhan);

                    if (add)
                    {
                        MessageBox.Show("Đã thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                    button_load_Click(sender, e);
                }
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            benhnhan.Clear();
            benhnhan = controller.load();
            Xem.Rows.Clear();

            foreach (Benhnhan k in benhnhan)

            {
                String[] row = { k.getMabenhnhan(), k.getTenbenhnhan(), k.getTuoi().ToString(), k.getGioitinh(), k.getDiachi() };
                Xem.Rows.Add(row);
            }
        }
        public void clear()
        {
            text_mabenhnhan.Clear();
            text_tenbenhnhan.Clear();
            text_tuoi.Clear();
            text_gioitinh.Clear();
            text_diachi.Clear();
            text_tim.Clear();   
        }

        private void Xem_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (Xem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Xem.SelectedRows)
                {

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa bn " + text_tenbenhnhan.Text + " với mã bn là " + text_mabenhnhan.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool deleted = controller.delete(text_mabenhnhan.Text);

                        if (deleted)
                        {
                            MessageBox.Show("Đã xóa !!");
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đối tượng muốn xóa!");
            }
            button_load_Click(sender, e);

        }
    }

}
    

