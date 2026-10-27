using Microsoft.EntityFrameworkCore;
using QL_DanhSachSinhVien.Models;

namespace QL_DanhSachSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();

            ToggleButtons(false);
        }

        private void LoadData()
        {
            using (var context = new DanhSachSV_dbContext())
            {
                dataGridViewHienThiDanhSachSinhVien.DataSource = context.SinhVien.ToList();
            }
        }

        private void dataGridViewHienThiDanhSachSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHienThiDanhSachSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewHienThiDanhSachSinhVien.SelectedRows[0];

                textBoxMaSinhVien.Text = row.Cells["MaSV"].Value.ToString();
                textBoxHoTen.Text = row.Cells["HoTen"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                dateTimePicker1.Text = row.Cells["NgaySinh"].Value.ToString();

                ToggleButtons(true);
            }
            else
            {
                ToggleButtons(false);
            }
        }

        private void ClearForm()
        {
            textBoxMaSinhVien.Clear();
            textBoxHoTen.Clear();
            textBoxEmail.Clear();
            dateTimePicker1.Value = DateTime.Now;

            ToggleButtons(false);

            dataGridViewHienThiDanhSachSinhVien.ClearSelection();
        }

        private bool ValidateNhapXuat()
        {
            string tenSV = textBoxHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (var context = new DanhSachSV_dbContext())
            {
                bool isExists = context.SinhVien.Any(t => t.HoTen.ToLower() == tenSV.ToLower());
                if (isExists)
                {
                    MessageBox.Show("Tên sinh viên này đã tồn tại trong cơ sở dữ liệu." +
                        "vui lòng nhập tên khác!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxHoTen.Focus();
                    return false;
                }
            }
            return true;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ToggleButtons(bool isSelected)
        {
            buttonThem.Enabled = !isSelected;
            buttonSua.Enabled = isSelected;
            buttonXoa.Enabled = isSelected;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!ValidateNhapXuat()) return;
            using (var context = new DanhSachSV_dbContext())
            {
                try
                {
                    var newItem = new SinhVien
                    {
                        HoTen = textBoxHoTen.Text.Trim(),
                        Email = textBoxEmail.Text.Trim(),
                        NgaySinh = dateTimePicker1.Value
                    };

                    context.SinhVien.Add(newItem);
                    context.SaveChanges();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            using (var context = new DanhSachSV_dbContext())
            {
                try
                {
                    int maSV = int.Parse(textBoxMaSinhVien.Text);
                    var existingItem = context.SinhVien.Find(maSV);

                    if (existingItem != null)
                    {
                        existingItem.HoTen = textBoxHoTen.Text.Trim();
                        existingItem.Email = textBoxEmail.Text.Trim();
                        existingItem.NgaySinh = dateTimePicker1.Value;

                        context.SaveChanges();
                        MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if(dialogResult == DialogResult.Yes)
            {
                using (var context = new DanhSachSV_dbContext())
                {
                    try
                    {
                        int maSV = int.Parse(textBoxMaSinhVien.Text);
                        var itemToDelete = context.SinhVien.Find(maSV);

                        if (itemToDelete != null)
                        {
                            context.SinhVien.Remove(itemToDelete);

                            context.SaveChanges();
                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }

                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {
                    }
                }
                
            }

        }
    }
}
