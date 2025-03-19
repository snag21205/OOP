namespace DoAnCK
{
    partial class FormHangHoa
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
            this.ptb_anhhanghoa = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bt_anh = new Guna.UI2.WinForms.Guna2Button();
            this.bt_xacnhanthemhang = new Guna.UI2.WinForms.Guna2Button();
            this.lb_thongtinhanghoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_ten = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_dongia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_loaihang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dongia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_hanghoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_soluong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_soluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.xoa_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_anhhanghoa
            // 
            this.ptb_anhhanghoa.ImageRotate = 0F;
            this.ptb_anhhanghoa.Location = new System.Drawing.Point(35, 30);
            this.ptb_anhhanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptb_anhhanghoa.Name = "ptb_anhhanghoa";
            this.ptb_anhhanghoa.Size = new System.Drawing.Size(222, 299);
            this.ptb_anhhanghoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_anhhanghoa.TabIndex = 0;
            this.ptb_anhhanghoa.TabStop = false;
            // 
            // bt_anh
            // 
            this.bt_anh.BackColor = System.Drawing.Color.Transparent;
            this.bt_anh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_anh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_anh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_anh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_anh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_anh.FillColor = System.Drawing.Color.Transparent;
            this.bt_anh.Font = new System.Drawing.Font("Arial", 9F);
            this.bt_anh.ForeColor = System.Drawing.Color.DimGray;
            this.bt_anh.Location = new System.Drawing.Point(44, 37);
            this.bt_anh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_anh.Name = "bt_anh";
            this.bt_anh.Size = new System.Drawing.Size(205, 282);
            this.bt_anh.TabIndex = 1;
            this.bt_anh.Text = "+Thêm ảnh....";
            this.bt_anh.Click += new System.EventHandler(this.bt_anh_Click);
            // 
            // bt_xacnhanthemhang
            // 
            this.bt_xacnhanthemhang.BorderRadius = 15;
            this.bt_xacnhanthemhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xacnhanthemhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_xacnhanthemhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_xacnhanthemhang.FillColor = System.Drawing.Color.DarkGray;
            this.bt_xacnhanthemhang.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_xacnhanthemhang.ForeColor = System.Drawing.Color.White;
            this.bt_xacnhanthemhang.Location = new System.Drawing.Point(473, 315);
            this.bt_xacnhanthemhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_xacnhanthemhang.Name = "bt_xacnhanthemhang";
            this.bt_xacnhanthemhang.Size = new System.Drawing.Size(118, 33);
            this.bt_xacnhanthemhang.TabIndex = 2;
            this.bt_xacnhanthemhang.Text = "Thêm hàng";
            this.bt_xacnhanthemhang.Click += new System.EventHandler(this.bt_xacnhanthemhang_Click);
            // 
            // lb_thongtinhanghoa
            // 
            this.lb_thongtinhanghoa.AutoSize = false;
            this.lb_thongtinhanghoa.BackColor = System.Drawing.Color.Transparent;
            this.lb_thongtinhanghoa.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtinhanghoa.Location = new System.Drawing.Point(338, 20);
            this.lb_thongtinhanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_thongtinhanghoa.Name = "lb_thongtinhanghoa";
            this.lb_thongtinhanghoa.Size = new System.Drawing.Size(209, 30);
            this.lb_thongtinhanghoa.TabIndex = 3;
            this.lb_thongtinhanghoa.Text = "Thông Tin Hàng Hóa";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = false;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_id.Location = new System.Drawing.Point(300, 65);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(105, 20);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID hàng hoá:";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = false;
            this.lbl_ten.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ten.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_ten.Location = new System.Drawing.Point(300, 138);
            this.lbl_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(105, 20);
            this.lbl_ten.TabIndex = 5;
            this.lbl_ten.Text = "Tên hàng hoá:";
            // 
            // lbl_dongia
            // 
            this.lbl_dongia.AutoSize = false;
            this.lbl_dongia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dongia.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_dongia.Location = new System.Drawing.Point(300, 215);
            this.lbl_dongia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(105, 20);
            this.lbl_dongia.TabIndex = 6;
            this.lbl_dongia.Text = "Đơn giá:";
            // 
            // lbl_loaihang
            // 
            this.lbl_loaihang.AutoSize = false;
            this.lbl_loaihang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loaihang.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_loaihang.Location = new System.Drawing.Point(454, 215);
            this.lbl_loaihang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_loaihang.Name = "lbl_loaihang";
            this.lbl_loaihang.Size = new System.Drawing.Size(119, 20);
            this.lbl_loaihang.TabIndex = 7;
            this.lbl_loaihang.Text = "Loại hàng:";
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(300, 85);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(124, 26);
            this.txt_id.TabIndex = 8;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // txt_ten
            // 
            this.txt_ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ten.DefaultText = "";
            this.txt_ten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ten.Location = new System.Drawing.Point(300, 158);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.PasswordChar = '\0';
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.SelectedText = "";
            this.txt_ten.Size = new System.Drawing.Size(282, 26);
            this.txt_ten.TabIndex = 9;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dongia.DefaultText = "";
            this.txt_dongia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dongia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dongia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dongia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dongia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dongia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dongia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dongia.Location = new System.Drawing.Point(300, 236);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PasswordChar = '\0';
            this.txt_dongia.PlaceholderText = "";
            this.txt_dongia.SelectedText = "";
            this.txt_dongia.Size = new System.Drawing.Size(124, 26);
            this.txt_dongia.TabIndex = 10;
            this.txt_dongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress_txt_dongia);
            // 
            // cbb_hanghoa
            // 
            this.cbb_hanghoa.BackColor = System.Drawing.Color.Transparent;
            this.cbb_hanghoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_hanghoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_hanghoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_hanghoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_hanghoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_hanghoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_hanghoa.ItemHeight = 30;
            this.cbb_hanghoa.Location = new System.Drawing.Point(458, 236);
            this.cbb_hanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_hanghoa.Name = "cbb_hanghoa";
            this.cbb_hanghoa.Size = new System.Drawing.Size(121, 36);
            this.cbb_hanghoa.TabIndex = 11;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = false;
            this.lbl_soluong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_soluong.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_soluong.Location = new System.Drawing.Point(458, 65);
            this.lbl_soluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(106, 20);
            this.lbl_soluong.TabIndex = 12;
            this.lbl_soluong.Text = "Số lượng:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.DefaultText = "";
            this.txt_soluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Location = new System.Drawing.Point(458, 85);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.PlaceholderText = "";
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(124, 26);
            this.txt_soluong.TabIndex = 13;
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.SystemColors.Control;
            this.xoa_btn.BorderRadius = 15;
            this.xoa_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoa_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoa_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoa_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoa_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.xoa_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.xoa_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xoa_btn.Location = new System.Drawing.Point(473, 315);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(118, 33);
            this.xoa_btn.TabIndex = 14;
            this.xoa_btn.Text = "Xoá hàng";
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.lbl_soluong);
            this.Controls.Add(this.cbb_hanghoa);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_loaihang);
            this.Controls.Add(this.lbl_dongia);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lb_thongtinhanghoa);
            this.Controls.Add(this.bt_xacnhanthemhang);
            this.Controls.Add(this.bt_anh);
            this.Controls.Add(this.ptb_anhhanghoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHangHoa";
            this.Text = "FormThemHang";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhhanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_thongtinhanghoa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_ten;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dongia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_loaihang;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_soluong;
        private Guna.UI2.WinForms.Guna2Button bt_anh;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_ten;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_hanghoa;
        private Guna.UI2.WinForms.Guna2TextBox txt_dongia;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_anhhanghoa;
        private Guna.UI2.WinForms.Guna2Button bt_xacnhanthemhang;
        private Guna.UI2.WinForms.Guna2TextBox txt_soluong;
        private Guna.UI2.WinForms.Guna2Button xoa_btn;
    }
}