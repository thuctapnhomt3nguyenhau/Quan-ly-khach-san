namespace QuanLyKhSan.GUI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnSuDungDichVu = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnSuDungDichVu);
            this.panel1.Controls.Add(this.btnDichVu);
            this.panel1.Controls.Add(this.btnLoaiPhong);
            this.panel1.Controls.Add(this.btnThuePhong);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Controls.Add(this.btnPhong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 445);
            this.panel1.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = global::QuanLyKhSan.Properties.Resources.nhanvien2;
            this.btnNhanVien.Location = new System.Drawing.Point(52, 15);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(137, 132);
            this.btnNhanVien.TabIndex = 16;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHoaDon.BackColor = System.Drawing.Color.White;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = global::QuanLyKhSan.Properties.Resources.tt;
            this.btnHoaDon.Location = new System.Drawing.Point(390, 324);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(263, 106);
            this.btnHoaDon.TabIndex = 15;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnSuDungDichVu
            // 
            this.btnSuDungDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuDungDichVu.BackColor = System.Drawing.Color.White;
            this.btnSuDungDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuDungDichVu.Image = global::QuanLyKhSan.Properties.Resources.SDV1;
            this.btnSuDungDichVu.Location = new System.Drawing.Point(52, 324);
            this.btnSuDungDichVu.Name = "btnSuDungDichVu";
            this.btnSuDungDichVu.Size = new System.Drawing.Size(277, 106);
            this.btnSuDungDichVu.TabIndex = 14;
            this.btnSuDungDichVu.Text = "Sử Dụng Dịch Vụ";
            this.btnSuDungDichVu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSuDungDichVu.UseVisualStyleBackColor = false;
            this.btnSuDungDichVu.Click += new System.EventHandler(this.btnSuDungDichVu_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDichVu.BackColor = System.Drawing.Color.White;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.Image = global::QuanLyKhSan.Properties.Resources.D;
            this.btnDichVu.Location = new System.Drawing.Point(513, 172);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(140, 125);
            this.btnDichVu.TabIndex = 13;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoaiPhong.BackColor = System.Drawing.Color.White;
            this.btnLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiPhong.Image = global::QuanLyKhSan.Properties.Resources.loai;
            this.btnLoaiPhong.Location = new System.Drawing.Point(282, 172);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Size = new System.Drawing.Size(146, 125);
            this.btnLoaiPhong.TabIndex = 12;
            this.btnLoaiPhong.Text = "Loại Phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThuePhong.BackColor = System.Drawing.Color.White;
            this.btnThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuePhong.Image = global::QuanLyKhSan.Properties.Resources.DV;
            this.btnThuePhong.Location = new System.Drawing.Point(52, 172);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(137, 125);
            this.btnThuePhong.TabIndex = 11;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThuePhong.UseVisualStyleBackColor = false;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKhachHang.BackColor = System.Drawing.Color.White;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Image = global::QuanLyKhSan.Properties.Resources.family;
            this.btnKhachHang.Location = new System.Drawing.Point(513, 15);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(140, 132);
            this.btnKhachHang.TabIndex = 10;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhong.BackColor = System.Drawing.Color.White;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.Image = global::QuanLyKhSan.Properties.Resources.phong;
            this.btnPhong.Location = new System.Drawing.Point(282, 15);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(146, 132);
            this.btnPhong.TabIndex = 9;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhSan.Properties.Resources.pool1;
            this.ClientSize = new System.Drawing.Size(748, 469);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnSuDungDichVu;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnPhong;
    }
}