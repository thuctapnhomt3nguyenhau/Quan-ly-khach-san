namespace QuanLyKhSan.GUI
{
    partial class ucSuDungDichVu
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
            this.dgvSDDV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.dtpNgaySD = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysudung = new System.Windows.Forms.Label();
            this.cboMadichvu = new System.Windows.Forms.ComboBox();
            this.cboMaThue = new System.Windows.Forms.ComboBox();
            this.lblmasudung = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMadichvu = new System.Windows.Forms.Label();
            this.lbMathue = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDDV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSDDV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 577);
            this.panel1.TabIndex = 0;
            // 
            // dgvSDDV
            // 
            this.dgvSDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSDDV.Location = new System.Drawing.Point(3, 290);
            this.dgvSDDV.Name = "dgvSDDV";
            this.dgvSDDV.Size = new System.Drawing.Size(1001, 284);
            this.dgvSDDV.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.lbDonGia);
            this.panel2.Controls.Add(this.dtpNgaySD);
            this.panel2.Controls.Add(this.lblNgaysudung);
            this.panel2.Controls.Add(this.cboMadichvu);
            this.panel2.Controls.Add(this.cboMaThue);
            this.panel2.Controls.Add(this.lblmasudung);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblMadichvu);
            this.panel2.Controls.Add(this.lbMathue);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 281);
            this.panel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuanLyKhSan.Properties.Resources.milk;
            this.btnBack.Location = new System.Drawing.Point(907, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 107);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(821, 119);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(111, 20);
            this.txtDonGia.TabIndex = 26;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(726, 118);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(80, 18);
            this.lbDonGia.TabIndex = 25;
            this.lbDonGia.Text = "Đặt Cọc :";
            // 
            // dtpNgaySD
            // 
            this.dtpNgaySD.Location = new System.Drawing.Point(501, 166);
            this.dtpNgaySD.Name = "dtpNgaySD";
            this.dtpNgaySD.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySD.TabIndex = 24;
            // 
            // lblNgaysudung
            // 
            this.lblNgaysudung.AutoSize = true;
            this.lblNgaysudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysudung.Location = new System.Drawing.Point(364, 165);
            this.lblNgaysudung.Name = "lblNgaysudung";
            this.lblNgaysudung.Size = new System.Drawing.Size(130, 18);
            this.lblNgaysudung.TabIndex = 23;
            this.lblNgaysudung.Text = "Ngày Sử Dụng : ";
            // 
            // cboMadichvu
            // 
            this.cboMadichvu.FormattingEnabled = true;
            this.cboMadichvu.Location = new System.Drawing.Point(501, 119);
            this.cboMadichvu.Name = "cboMadichvu";
            this.cboMadichvu.Size = new System.Drawing.Size(121, 21);
            this.cboMadichvu.TabIndex = 22;
            // 
            // cboMaThue
            // 
            this.cboMaThue.FormattingEnabled = true;
            this.cboMaThue.Location = new System.Drawing.Point(181, 166);
            this.cboMaThue.Name = "cboMaThue";
            this.cboMaThue.Size = new System.Drawing.Size(106, 21);
            this.cboMaThue.TabIndex = 21;
            // 
            // lblmasudung
            // 
            this.lblmasudung.AutoSize = true;
            this.lblmasudung.Location = new System.Drawing.Point(178, 128);
            this.lblmasudung.Name = "lblmasudung";
            this.lblmasudung.Size = new System.Drawing.Size(13, 13);
            this.lblmasudung.TabIndex = 20;
            this.lblmasudung.Text = "1";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyKhSan.Properties.Resources.huy;
            this.btnHuy.Location = new System.Drawing.Point(891, 209);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(57, 54);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::QuanLyKhSan.Properties.Resources.capnhat;
            this.btnCapNhat.Location = new System.Drawing.Point(793, 209);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(55, 54);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyKhSan.Properties.Resources.sua;
            this.btnSua.Location = new System.Drawing.Point(693, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 54);
            this.btnSua.TabIndex = 17;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyKhSan.Properties.Resources.xoa;
            this.btnXoa.Location = new System.Drawing.Point(599, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 54);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyKhSan.Properties.Resources.them;
            this.btnThem.Location = new System.Drawing.Point(501, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 56);
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(181, 239);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLyKhSan.Properties.Resources.search_icon;
            this.btnSearch.Location = new System.Drawing.Point(102, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 57);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMadichvu
            // 
            this.lblMadichvu.AutoSize = true;
            this.lblMadichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadichvu.Location = new System.Drawing.Point(385, 124);
            this.lblMadichvu.Name = "lblMadichvu";
            this.lblMadichvu.Size = new System.Drawing.Size(109, 18);
            this.lblMadichvu.TabIndex = 5;
            this.lblMadichvu.Text = "Mã Dịch Vụ  :";
            // 
            // lbMathue
            // 
            this.lbMathue.AutoSize = true;
            this.lbMathue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMathue.Location = new System.Drawing.Point(73, 170);
            this.lbMathue.Name = "lbMathue";
            this.lbMathue.Size = new System.Drawing.Size(88, 18);
            this.lbMathue.TabIndex = 4;
            this.lbMathue.Text = "Mã Thuê : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(19, 124);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 18);
            this.label.TabIndex = 3;
            this.label.Text = "Mã  SD Dịch Vụ  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sử Dụng Dịch Vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = global::QuanLyKhSan.Properties.Resources.dịchvu;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 581);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ucSuDungDichVu";
            this.Text = "Sử Dụng Dịch Vụ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSDDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgaySD;
        private System.Windows.Forms.Label lblNgaysudung;
        private System.Windows.Forms.ComboBox cboMadichvu;
        private System.Windows.Forms.ComboBox cboMaThue;
        private System.Windows.Forms.Label lblmasudung;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMadichvu;
        private System.Windows.Forms.Label lbMathue;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSDDV;
    }
}