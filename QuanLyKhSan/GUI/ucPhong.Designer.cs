namespace QuanLyKhSan.GUI
{
    partial class ucPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMaL = new System.Windows.Forms.ComboBox();
            this.lblMaphong = new System.Windows.Forms.Label();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblMaP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPhong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPhong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 525);
            this.panel1.TabIndex = 0;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(0, 297);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(1023, 228);
            this.dgvPhong.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.cboMaL);
            this.panel2.Controls.Add(this.lblMaphong);
            this.panel2.Controls.Add(this.btnHuy1);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblGia);
            this.panel2.Controls.Add(this.lblMaLoai);
            this.panel2.Controls.Add(this.txtGiaThue);
            this.panel2.Controls.Add(this.txtTenPhong);
            this.panel2.Controls.Add(this.lblTenPhong);
            this.panel2.Controls.Add(this.lblMaP);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 296);
            this.panel2.TabIndex = 1;
            // 
            // cboMaL
            // 
            this.cboMaL.FormattingEnabled = true;
            this.cboMaL.Location = new System.Drawing.Point(720, 154);
            this.cboMaL.Name = "cboMaL";
            this.cboMaL.Size = new System.Drawing.Size(180, 21);
            this.cboMaL.TabIndex = 18;
            // 
            // lblMaphong
            // 
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Location = new System.Drawing.Point(197, 142);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(13, 13);
            this.lblMaphong.TabIndex = 17;
            this.lblMaphong.Text = "1";
            // 
            // btnHuy1
            // 
            this.btnHuy1.Image = global::QuanLyKhSan.Properties.Resources.huy;
            this.btnHuy1.Location = new System.Drawing.Point(875, 217);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(61, 58);
            this.btnHuy1.TabIndex = 16;
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::QuanLyKhSan.Properties.Resources.capnhat;
            this.btnReset.Location = new System.Drawing.Point(782, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 58);
            this.btnReset.TabIndex = 15;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyKhSan.Properties.Resources.huy;
            this.btnHuy.Location = new System.Drawing.Point(1170, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(60, 58);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::QuanLyKhSan.Properties.Resources.capnhat;
            this.btnCapNhat.Location = new System.Drawing.Point(1074, 217);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(56, 58);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyKhSan.Properties.Resources.xoa;
            this.btnXoa.Location = new System.Drawing.Point(689, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 58);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyKhSan.Properties.Resources.sua;
            this.btnSua.Location = new System.Drawing.Point(607, 217);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 58);
            this.btnSua.TabIndex = 11;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyKhSan.Properties.Resources.them;
            this.btnThem.Location = new System.Drawing.Point(520, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 58);
            this.btnThem.TabIndex = 10;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(193, 255);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLyKhSan.Properties.Resources.search_icon;
            this.btnSearch.Location = new System.Drawing.Point(118, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(604, 180);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(97, 18);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "Giá Phòng :";
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.Location = new System.Drawing.Point(570, 151);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(131, 18);
            this.lblMaLoai.TabIndex = 6;
            this.lblMaLoai.Text = "Mã Loại Phòng :";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(720, 181);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(180, 20);
            this.txtGiaThue.TabIndex = 4;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(193, 178);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(163, 20);
            this.txtTenPhong.TabIndex = 3;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(78, 177);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(99, 18);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên Phòng :";
            // 
            // lblMaP
            // 
            this.lblMaP.AutoSize = true;
            this.lblMaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaP.Location = new System.Drawing.Point(83, 138);
            this.lblMaP.Name = "lblMaP";
            this.lblMaP.Size = new System.Drawing.Size(94, 18);
            this.lblMaP.TabIndex = 1;
            this.lblMaP.Text = "Mã Phòng :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.lblPhong);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1023, 118);
            this.panel3.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuanLyKhSan.Properties.Resources._1124959648_203;
            this.btnBack.Location = new System.Drawing.Point(913, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 115);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(187, 34);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(169, 55);
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhSan.Properties.Resources.b5eb743fc3c361bf11c480e5aabbae0f;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 533);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ucPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblMaP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMaphong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cboMaL;
    }
}