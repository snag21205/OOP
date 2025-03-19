using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormHangHoa : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();
        private HangHoa hh;
        private string img_filepath;
        private FormTrangChu formTrangChu;

        public FormHangHoa(HangHoa hh, FormTrangChu formTrangChu)
        {
            InitializeComponent();
            
            this.formTrangChu = formTrangChu;
            this.hh = hh;
            kho.LoadData();
        }

        #region Event
        private void bt_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh hàng hóa",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                ptb_anhhanghoa.Image = Image.FromFile(filePath);
                bt_anh.Visible = false;
                img_filepath = @".\" + filePath.Substring(filePath.IndexOf("Resources"));
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text.Length > 4)
            {
                txt_id.Text = txt_id.Text.Substring(0, 4);
                txt_id.SelectionStart = txt_id.Text.Length;
            }
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            string text = txt_id.Text;
            if (!(text.StartsWith("DT") || text.StartsWith("GD") || text.StartsWith("TP")))
            {
                MessageBox.Show("ID phải bắt đầu bằng DT, GD, hoặc TP.", "Sai mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
            }

            HangHoa hh = kho.ds_hang_hoa.Find(x => x.id == txt_id.Text);
            if (hh != null)
            {
                MessageBox.Show("Hàng hoá đã tồn tại");
                txt_id.Text = "";
            }
        }

        private void keypress_txt_dongia(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_xacnhanthemhang_Click(object sender, EventArgs e)
        {
            string loai_hh = cbb_hanghoa.Text;
             

            if (txt_ten.Text == "" || txt_id.Text == "" || txt_dongia.Text == "" || cbb_hanghoa.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn thêm hàng hoá?", "Xác nhận", MessageBoxButtons.OKCancel);
                if (xacnhan == DialogResult.OK)
                {
                    if (loai_hh == "Điện tử")
                    {
                        hh = new DienTu(
                            txt_id.Text, 
                            txt_ten.Text,
                            Convert.ToUInt32(txt_soluong.Text), 
                            Convert.ToUInt64(txt_dongia.Text), 
                            img_filepath);

                        kho.them_hh(hh);
                    }

                    else if (loai_hh == "Gia dụng")
                    {
                        hh = new GiaDung(
                            txt_id.Text,
                            txt_ten.Text,
                            Convert.ToUInt32(txt_soluong.Text),
                            Convert.ToUInt64(txt_dongia.Text),
                            img_filepath);

                        kho.them_hh(hh);
                    }
                    else if (loai_hh == "Thực phẩm")
                    {
                        hh = new ThucPham(
                            txt_id.Text,
                            txt_ten.Text,
                            Convert.ToUInt32(txt_soluong.Text),
                            Convert.ToUInt64(txt_dongia.Text),
                            img_filepath);

                        kho.them_hh(hh);
                    }

                    formTrangChu.Reload_flp();
                    this.Close();
                } 
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xoá hàng hoá?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (xacnhan == DialogResult.OK)
            {
                hh = kho.ds_hang_hoa.Find(x => x.id == hh.id);
                kho.xoa_hh(hh);
                formTrangChu.Reload_flp();
                this.Close();
            }
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            cbb_hanghoa.Items.Add("Điện tử");
            cbb_hanghoa.Items.Add("Gia dụng");
            cbb_hanghoa.Items.Add("Thực phẩm");

            if (hh == null)
            {
                xoa_btn.Visible = false;
                txt_soluong.Text = "0";
                txt_soluong.Enabled = false;
            }
            else
            {
                if (hh.img != null)
                {
                    ptb_anhhanghoa.Image = Image.FromFile(hh.img);
                }
                bt_anh.Visible = false;
                txt_id.Text = hh.id;
                txt_ten.Text = hh.ten_hang;
                txt_soluong.Text = hh.so_luong.ToString();
                txt_dongia.Text = hh.don_gia.ToString();
                if (hh is DienTu)
                {
                    cbb_hanghoa.Text = "Điện tử";
                }
                else if (hh is ThucPham)
                {
                    cbb_hanghoa.Text = "Thực phẩm";
                }
                else if (hh is GiaDung)
                {
                    cbb_hanghoa.Text = "Gia dụng";
                }

                bt_anh.Enabled = false;
                txt_id.Enabled = false;
                txt_ten.Enabled = false;
                txt_dongia.Enabled = false;
                cbb_hanghoa.Enabled = false;
                txt_soluong.Enabled = false;
                bt_xacnhanthemhang.Visible = false;
                xoa_btn.Visible = true;
            }
        }
        #endregion
    }
}