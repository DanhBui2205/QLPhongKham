namespace Quanlikho.Views
{
    partial class SRM_BenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.Xem = new System.Windows.Forms.DataGridView();
            this.text_mabenhnhan = new System.Windows.Forms.TextBox();
            this.text_tenbenhnhan = new System.Windows.Forms.TextBox();
            this.text_tim = new System.Windows.Forms.TextBox();
            this.text_tuoi = new System.Windows.Forms.TextBox();
            this.text_gioitinh = new System.Windows.Forms.TextBox();
            this.text_diachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Xem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BỆNH NHÂN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Bệnh Nhân:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Bệnh Nhân:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tuổi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa Chỉ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timkiem.Location = new System.Drawing.Point(83, 194);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(138, 32);
            this.button_timkiem.TabIndex = 6;
            this.button_timkiem.Text = "Tìm Kiếm ";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(232, 250);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 29);
            this.button_them.TabIndex = 7;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(345, 250);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 29);
            this.button_load.TabIndex = 8;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(476, 250);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 29);
            this.button_sua.TabIndex = 9;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(593, 250);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 29);
            this.button_xoa.TabIndex = 10;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // Xem
            // 
            this.Xem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Xem.Location = new System.Drawing.Point(83, 303);
            this.Xem.Name = "Xem";
            this.Xem.RowHeadersWidth = 51;
            this.Xem.RowTemplate.Height = 24;
            this.Xem.Size = new System.Drawing.Size(729, 150);
            this.Xem.TabIndex = 11;
            this.Xem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Xem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Xem_MouseDoubleClick);
            // 
            // text_mabenhnhan
            // 
            this.text_mabenhnhan.Location = new System.Drawing.Point(245, 89);
            this.text_mabenhnhan.Name = "text_mabenhnhan";
            this.text_mabenhnhan.Size = new System.Drawing.Size(168, 22);
            this.text_mabenhnhan.TabIndex = 12;
            // 
            // text_tenbenhnhan
            // 
            this.text_tenbenhnhan.Location = new System.Drawing.Point(245, 142);
            this.text_tenbenhnhan.Name = "text_tenbenhnhan";
            this.text_tenbenhnhan.Size = new System.Drawing.Size(168, 22);
            this.text_tenbenhnhan.TabIndex = 13;
            // 
            // text_tim
            // 
            this.text_tim.Location = new System.Drawing.Point(245, 201);
            this.text_tim.Name = "text_tim";
            this.text_tim.Size = new System.Drawing.Size(168, 22);
            this.text_tim.TabIndex = 14;
            this.text_tim.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_tuoi
            // 
            this.text_tuoi.Location = new System.Drawing.Point(577, 85);
            this.text_tuoi.Name = "text_tuoi";
            this.text_tuoi.Size = new System.Drawing.Size(186, 22);
            this.text_tuoi.TabIndex = 15;
            this.text_tuoi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // text_gioitinh
            // 
            this.text_gioitinh.Location = new System.Drawing.Point(577, 141);
            this.text_gioitinh.Name = "text_gioitinh";
            this.text_gioitinh.Size = new System.Drawing.Size(186, 22);
            this.text_gioitinh.TabIndex = 16;
            // 
            // text_diachi
            // 
            this.text_diachi.Location = new System.Drawing.Point(577, 199);
            this.text_diachi.Name = "text_diachi";
            this.text_diachi.Size = new System.Drawing.Size(186, 22);
            this.text_diachi.TabIndex = 17;
            // 
            // SRM_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 479);
            this.Controls.Add(this.text_diachi);
            this.Controls.Add(this.text_gioitinh);
            this.Controls.Add(this.text_tuoi);
            this.Controls.Add(this.text_tim);
            this.Controls.Add(this.text_tenbenhnhan);
            this.Controls.Add(this.text_mabenhnhan);
            this.Controls.Add(this.Xem);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SRM_BenhNhan";
            this.Text = "SRM_BenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.Xem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.DataGridView Xem;
        private System.Windows.Forms.TextBox text_mabenhnhan;
        private System.Windows.Forms.TextBox text_tenbenhnhan;
        private System.Windows.Forms.TextBox text_tim;
        private System.Windows.Forms.TextBox text_tuoi;
        private System.Windows.Forms.TextBox text_gioitinh;
        private System.Windows.Forms.TextBox text_diachi;
    }
}