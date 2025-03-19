using System;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormCuaHang : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();
        private int index;
        private CuaHang ch;
        private bool isAddingMode = false;

        public FormCuaHang()
        {
            InitializeComponent();
            kho.LoadData();

            ResetTextBoxes();
        }

        private void SetNCCInfo(CuaHang ch)
        {
            this.ch = ch;
        }

        private void ResetTextBoxes()
        {
            txtId.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        private void ToggleTextBoxState(bool enabled)
        {
            txtId.Enabled = enabled;
            txtTen.Enabled = enabled;
            txtSDT.Enabled = enabled;
            txtDiaChi.Enabled = enabled;
        }

        #region Event
        private void btnthem_Click(object sender, EventArgs e)
        {
            isAddingMode = true;
            ResetTextBoxes();
            ToggleTextBoxState(true);
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            index = dataCH.CurrentCell.RowIndex;
            kho.ds_cua_hang.RemoveAt(index);
            dataCH.Rows.RemoveAt(index);
            kho.LuuDanhSachCH();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= kho.ds_ncc.Count)
            {
                MessageBox.Show("Vui lòng chọn một cửa hàng để cập nhật!", "Thông báo");
                return;
            }

            DataGridViewRow selectedRow = dataCH.Rows[index];
            selectedRow.Cells[0].Value = txtId.Text;
            selectedRow.Cells[1].Value = txtTen.Text;
            selectedRow.Cells[2].Value = txtSDT.Text;
            selectedRow.Cells[3].Value = txtDiaChi.Text;

            CuaHang chToUpdate = kho.ds_cua_hang[index];
            chToUpdate.id_ch = txtId.Text;
            chToUpdate.ten_ch = txtTen.Text;
            chToUpdate.sdt_ch = txtSDT.Text;
            chToUpdate.dia_chi_ch = txtDiaChi.Text;


            dataCH.Refresh();
            kho.LuuDanhSachCH();

            MessageBox.Show("Cập nhật thành công!", "Thông báo");

            ResetTextBoxes();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAddingMode)
            {
                string id = txtId.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;

                CuaHang ch = new CuaHang(id, ten, sdt, diaChi);
                kho.ds_cua_hang.Add(ch);
                dataCH.Rows.Add(id, ten, sdt, diaChi);

                kho.LuuDanhSachCH();

                MessageBox.Show("Đã lưu thành công!", "Thông báo");


                isAddingMode = false;


                ResetTextBoxes();
            }
            else
            {
                MessageBox.Show("Hãy nhấn nút Thêm trước khi lưu!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAddingMode = false;
            ResetTextBoxes();
        }

        private void dataCH1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            index = e.RowIndex;
            DataGridViewRow row = dataCH.Rows[index];

            if (row != null && row.Cells.Count >= 4)
            {
                txtId.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txtTen.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtSDT.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtDiaChi.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            }
        }

        private void dataCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            index = e.RowIndex;
            DataGridViewRow row = dataCH.Rows[index];

            if (row != null && row.Cells.Count >= 4)
            {
                txtId.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                txtTen.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                txtSDT.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtDiaChi.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            }
        }

        private void FormCuaHang_Load(object sender, EventArgs e)
        {
            foreach (CuaHang ch in kho.ds_cua_hang)
            {
                dataCH.Rows.Add(ch.id_ch, ch.ten_ch, ch.sdt_ch, ch.dia_chi_ch);
            }

            dataCH.Enabled = dataCH.Rows.Count > 0;
        }
        #endregion

        private void dataCH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tenCHlabel_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void daichichlabel_Click(object sender, EventArgs e)
        {

        }

        private void sdtchlabel_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
