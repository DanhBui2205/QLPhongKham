using Quanlikho.Controller;
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

namespace Quanlikho.Views
{
    public partial class SRM_PhieuNhap : Form
    {
        BenhnhanController benhnhanController;
        ThuocController thuocController;
        PhieunhaptoathuocController phieunhaptoathuocController;
        ChitiettoathuocController chitiettoathuocController;
        List<Benhnhan> benhnhan;
        List<Thuoc> thuoc;
        Phieunhaptoathuoc currentPN;
        public SRM_PhieuNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SRM_PhieuNhap_Load(object sender, EventArgs e)
        {
            benhnhan = new List<Benhnhan>(); 
            benhnhanController = new BenhnhanController();
            benhnhan = benhnhanController.load();
            thuoc = new List<Thuoc>();
            thuocController = new ThuocController();
            thuoc = thuocController.load();
            phieunhaptoathuocController = new PhieunhaptoathuocController();
            chitiettoathuocController = new ChitiettoathuocController();
            foreach (Benhnhan k in benhnhan)
            {
                cbb_benhnhan.Items.Add(k.getMabenhnhan());

            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "ID";
            comboboxColumn.HeaderText = "Mã thuốc";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 90;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (Thuoc k in thuoc)
            {
                comboboxColumn.Items.Add(k.getMathuoc());
            }
            DGV_PN.Columns.Clear();
            DGV_PN.Columns.Add(comboboxColumn);//Ma hang
            //tên hàng
            DataGridViewTextBoxColumn colTenThuoc = new DataGridViewTextBoxColumn();
            colTenThuoc.DataPropertyName = "TenThuoc";
            colTenThuoc.HeaderText = "Tên thuốc";
            DGV_PN.Columns.Add(colTenThuoc);
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "LoaiThuoc";
            colDVT.HeaderText = "Loại thuốc";
            DGV_PN.Columns.Add(colDVT);
            //tên hàng
            DataGridViewTextBoxColumn colStt = new DataGridViewTextBoxColumn();
            colStt.DataPropertyName = "Stt";
            colStt.HeaderText = "Stt";
            DGV_PN.Columns.Add(colStt);
            //Liều dùng
            DataGridViewTextBoxColumn colLieudung = new DataGridViewTextBoxColumn();
            colLieudung.DataPropertyName = "LieuDung";
            colLieudung.HeaderText = "Liều dùng";
            DGV_PN.Columns.Add(colLieudung);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            DGV_PN.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            DGV_PN.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            DGV_PN.Columns.Add(colThanhTien);
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, currentPN);
        }

        private void button1_Click(object sender, EventArgs e, Phieunhaptoathuoc currentPN)
        {
            currentPN = new Phieunhaptoathuoc(txt_sophieu.Text,txt_soHD.Text, cbb_benhnhan.Text, Convert.ToDateTime(txt_ngaykham.Text), Convert.ToDateTime(txt_ngayhd.Text), txt_diachi.Text);
            phieunhaptoathuocController.insert(currentPN);

            //2. Lưu chi tiết phiếu nhập
            for (int i = 0; i < DGV_PN.Rows.Count - 1; i++)
            {
                Chitiettoathuoc ct = new Chitiettoathuoc();
                ct.setMaphieunhap(txt_sophieu.Text);
                ct.setMathuoc(DGV_PN.Rows[i].Cells[0].Value.ToString());
                ct.setStt(Convert.ToInt32(DGV_PN.Rows[i].Cells[3].Value.ToString()));
                ct.setSoluong(Convert.ToInt32(DGV_PN.Rows[i].Cells[5].Value.ToString()));
                ct.setDongia(Convert.ToInt32(DGV_PN.Rows[i].Cells[6].Value.ToString()));
                ct.setLieudung(DGV_PN.Rows[i].Cells[4].Value.ToString());

                chitiettoathuocController.insert(ct);
            }
            MessageBox.Show("Đã lưu thành công!");
            

        }
        private void DGV_PN_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //column index 0 là mặt hàng
            if (e.ColumnIndex == 0)
            {
                String id = DGV_PN.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                DGV_PN.Rows[e.RowIndex].Cells[1].Value = thuocController.get(id).getTenthuoc();
                DGV_PN.Rows[e.RowIndex].Cells[2].Value = thuocController.get(id).getLoaithuoc();

            }
            //column index 6 là đơn giá
            if (e.ColumnIndex == 6)
            {
                int sl = int.Parse(DGV_PN.Rows[e.RowIndex].Cells[5].Value.ToString().Trim());
                int dg = int.Parse(DGV_PN.Rows[e.RowIndex].Cells[6].Value.ToString().Trim());
                DGV_PN.Rows[e.RowIndex].Cells[7].Value = sl * dg;

            }
        }

        private void DGV_PN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_soHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
