namespace QL_DanhSachSinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMaSinhVien = new TextBox();
            textBoxHoTen = new TextBox();
            textBoxEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonLamMoi = new Button();
            dataGridViewHienThiDanhSachSinhVien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHienThiDanhSachSinhVien).BeginInit();
            SuspendLayout();
            // 
            // textBoxMaSinhVien
            // 
            textBoxMaSinhVien.Location = new Point(195, 63);
            textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            textBoxMaSinhVien.ReadOnly = true;
            textBoxMaSinhVien.Size = new Size(213, 27);
            textBoxMaSinhVien.TabIndex = 0;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(195, 124);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(213, 27);
            textBoxHoTen.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(195, 192);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(213, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(525, 78);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 4;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(696, 78);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 5;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(881, 78);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 6;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Location = new Point(1069, 78);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(94, 29);
            buttonLamMoi.TabIndex = 7;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = true;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // dataGridViewHienThiDanhSachSinhVien
            // 
            dataGridViewHienThiDanhSachSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHienThiDanhSachSinhVien.Location = new Point(185, 338);
            dataGridViewHienThiDanhSachSinhVien.Name = "dataGridViewHienThiDanhSachSinhVien";
            dataGridViewHienThiDanhSachSinhVien.RowHeadersWidth = 51;
            dataGridViewHienThiDanhSachSinhVien.Size = new Size(915, 332);
            dataGridViewHienThiDanhSachSinhVien.TabIndex = 8;
            dataGridViewHienThiDanhSachSinhVien.SelectionChanged += dataGridViewHienThiDanhSachSinhVien_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 63);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 9;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 127);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 199);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 278);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 12;
            label4.Text = "Ngày sinh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 697);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewHienThiDanhSachSinhVien);
            Controls.Add(buttonLamMoi);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxHoTen);
            Controls.Add(textBoxMaSinhVien);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHienThiDanhSachSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMaSinhVien;
        private TextBox textBoxHoTen;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePicker1;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonLamMoi;
        private DataGridView dataGridViewHienThiDanhSachSinhVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
