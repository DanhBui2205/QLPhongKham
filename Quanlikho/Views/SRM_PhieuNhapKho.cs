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
    public partial class PhieuNhapKho : Form
    {
        KhoController khoController;//kho controller
        HangHoaController hanghoaController;// HangHoaController
        List<KHO> ds_kho;//danh sach kho
        List<HANGHOA> ds_HangHoa;//danh sach hang hoa
        public PhieuNhapKho()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //column index 0 là mặt hàng
            if (e.ColumnIndex == 0)
            {
                String id = DTGV.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                DTGV.Rows[e.RowIndex].Cells[1].Value = hanghoaController.get(id).getMamathang();

            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sl = int.Parse(DTGV.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                int dg = int.Parse(DTGV.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                DTGV.Rows[e.RowIndex].Cells[5].Value = sl * dg;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PhieuNhapKho_Load(object sender, EventArgs e)
        {
            ds_kho = new List<KHO>(); //chứa danh sách kho
            khoController = new KhoController();//Kho controller
            ds_kho = khoController.load();
            ds_HangHoa = new List<HANGHOA>();
            hanghoaController = new HangHoaController();
            ds_HangHoa = hanghoaController.load();


            foreach (KHO k in ds_kho)
            {
                cb_makho.Items.Add(k.getMakho());

            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "ID";
            comboboxColumn.HeaderText = "Mã hàng";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 90;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (HANGHOA k in ds_HangHoa)
            {
                comboboxColumn.Items.Add(k.getMamathang());
            }
            DTGV.Columns.Clear();
            DTGV.Columns.Add(comboboxColumn);//Ma hang
            //tên hàng
            DataGridViewTextBoxColumn colTenHang = new DataGridViewTextBoxColumn();
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.HeaderText = "Tên hàng";
            DTGV.Columns.Add(colTenHang);
            // Đơn vị tính
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "DVT";
            colDVT.HeaderText = "Đơn vị tính";
            DTGV.Columns.Add(colDVT);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            DTGV.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            DTGV.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            DTGV.Columns.Add(colThanhTien);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
