using System;
using System.Windows.Forms;

namespace DoAnCK
{

    public partial class FormDangNhap : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();

        public NhanVien current_nv;

        public FormDangNhap()
        {
            InitializeComponent();

            kho.LoadData();
        }

        #region Event
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            current_nv = kho.dang_nhap(username, password);

            if (current_nv != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

      
    }
}