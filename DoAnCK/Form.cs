using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            ngay_lbl.Text = "Ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            OpenChildForm(new FormTrangChu());
            ShowLoginForm();
            nhapxuat.Visible = false;
        }

        private NhanVien current_nv;
        private void ShowLoginForm()
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            if (formDangNhap.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                nhanvien_lbl.Text = "Nhân viên: " + formDangNhap.current_nv.ten_nv;
                ngay_lbl.Text = "Ngày " + DateTime.Now.ToString("dd/MM/yyyy");
                OpenChildForm(new FormTrangChu());
                current_nv = formDangNhap.current_nv;
            }
        }

        private System.Windows.Forms.Form currentFormChild;
        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private bool hoadonExpand = false;

        #region Event

        
        
        private async void hoadon_Click(object sender, EventArgs e)
        {
            nhapxuat.Visible = true;
            int startPosition = hoadon.Left - nhapxuat.Width; // Đặt ở bên trái
            nhapxuat.Left = startPosition;

            // Hiệu ứng trượt từ trái sang phải
            for (int i = 0; i <= nhapxuat.Width; i += 10)
            {
                nhapxuat.Left = startPosition + i;
                await Task.Delay(10);
            }
        }

        private async void nhapxuat_MouseLeave(object sender, EventArgs e)
        {
            await Task.Delay(3000); // Đợi xem chuột có quay lại không
            int startPosition = nhapxuat.Left;
            for (int i = nhapxuat.Width; i >= 0; i -= 10)
            {
                nhapxuat.Left = startPosition - (nhapxuat.Width - i);
                await Task.Delay(10);
            }
            nhapxuat.Visible = false;
        }

        private void trangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChu());
            trangchu.Checked = true;
            nhaphang.Checked = false;
            xuathang.Checked = false;
            cuahang.Checked = false;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = false;
        }
        

        private void nhaphang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapXuat(current_nv, true));
            trangchu.Checked = false;
            nhaphang.Checked = true;
            xuathang.Checked = false;
            cuahang.Checked = false;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = false;
        }

        private void xuathang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapXuat(current_nv, false));
            trangchu.Checked = false;
            nhaphang.Checked = false;
            xuathang.Checked = true;
            cuahang.Checked = false;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = false;
        }

        private void cuahang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCuaHang());
            trangchu.Checked = false;
            nhaphang.Checked = false;
            xuathang.Checked = false;
            cuahang.Checked = true;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = false;
        }

        private void nhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaCungCap());
            trangchu.Checked = false;
            nhaphang.Checked = false;
            xuathang.Checked = false;
            cuahang.Checked = false;
            nhacungcap.Checked = true;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = false;
        }
       

        private void hoadonnhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(true));
            trangchu.Checked = false;
            nhaphang.Checked = false;
            xuathang.Checked = false;
            cuahang.Checked = false;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = true;
            hoadonxuat.Checked = false;
        }

        private void hoadonxuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(false));
            trangchu.Checked = false;
            nhaphang.Checked = false;
            xuathang.Checked = false;
            cuahang.Checked = false;
            nhacungcap.Checked = false;
            hoadonnhap.Checked = false;
            hoadonxuat.Checked = true;
        }

        #endregion

        
    }
}
