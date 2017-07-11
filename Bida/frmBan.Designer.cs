namespace Bida
{
    partial class frmBan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            this.lblBan = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.comKH = new MetroFramework.Controls.MetroComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblnv = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picBan = new System.Windows.Forms.PictureBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(379, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 13);
            label2.TabIndex = 14;
            // 
            // lblBan
            // 
            this.lblBan.AutoScroll = true;
            this.lblBan.AutoScrollMinSize = new System.Drawing.Size(72, 38);
            this.lblBan.AutoSize = false;
            this.lblBan.BackColor = System.Drawing.SystemColors.Window;
            this.lblBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(192, 62);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(87, 38);
            this.lblBan.TabIndex = 1;
            this.lblBan.Text = "Bàn 1";
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.Location = new System.Drawing.Point(30, 208);
            this.txtTimeStart.Multiline = true;
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.ReadOnly = true;
            this.txtTimeStart.Size = new System.Drawing.Size(144, 31);
            this.txtTimeStart.TabIndex = 3;
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEnd.Location = new System.Drawing.Point(30, 254);
            this.txtTimeEnd.Multiline = true;
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.ReadOnly = true;
            this.txtTimeEnd.Size = new System.Drawing.Size(144, 31);
            this.txtTimeEnd.TabIndex = 5;
            // 
            // comKH
            // 
            this.comKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource, "Makh", true));
            this.comKH.DataSource = this.khachHangBindingSource;
            this.comKH.DisplayMember = "Tenkh";
            this.comKH.FormattingEnabled = true;
            this.comKH.ItemHeight = 23;
            this.comKH.Location = new System.Drawing.Point(144, 165);
            this.comKH.Name = "comKH";
            this.comKH.Size = new System.Drawing.Size(207, 29);
            this.comKH.TabIndex = 11;
            this.comKH.UseSelectable = true;
            this.comKH.ValueMember = "Makh";
            this.comKH.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(Bida.DTO.KhachHang);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(27, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Khách hàng : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblnv
            // 
            this.lblnv.AutoSize = true;
            this.lblnv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblnv.Location = new System.Drawing.Point(525, 24);
            this.lblnv.Name = "lblnv";
            this.lblnv.Size = new System.Drawing.Size(93, 25);
            this.lblnv.Style = MetroFramework.MetroColorStyle.Green;
            this.lblnv.TabIndex = 18;
            this.lblnv.Text = "Nhân Viên";
            this.lblnv.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(313, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Ngày : ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDate.Location = new System.Drawing.Point(374, 208);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.Style = MetroFramework.MetroColorStyle.Green;
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Ngày ";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtGio
            // 
            this.txtGio.BackColor = System.Drawing.Color.White;
            this.txtGio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(180, 321);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(290, 31);
            this.txtGio.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số giờ chơi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(23, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tổng tiền : ";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.txtGia.Location = new System.Drawing.Point(180, 376);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(290, 36);
            this.txtGia.TabIndex = 29;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Image = global::Bida.Properties.Resources.dollar_flat;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(428, 457);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(179, 57);
            this.btnPay.TabIndex = 30;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Image = global::Bida.Properties.Resources.exchange;
            this.btnChange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChange.Location = new System.Drawing.Point(515, 76);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(92, 72);
            this.btnChange.TabIndex = 23;
            this.btnChange.Text = "Chuyển bàn";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bida.Properties.Resources.user11;
            this.pictureBox1.Location = new System.Drawing.Point(497, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Bida.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(5, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 43);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnTinh.Enabled = false;
            this.btnTinh.FlatAppearance.BorderSize = 0;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.White;
            this.btnTinh.Image = global::Bida.Properties.Resources.time_;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinh.Location = new System.Drawing.Point(313, 252);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(157, 31);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính giờ";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnEnd.Enabled = false;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Image = global::Bida.Properties.Resources.end;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(180, 254);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(107, 31);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = global::Bida.Properties.Resources.play;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(180, 208);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 31);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picBan
            // 
            this.picBan.Location = new System.Drawing.Point(86, 17);
            this.picBan.Name = "picBan";
            this.picBan.Size = new System.Drawing.Size(100, 118);
            this.picBan.TabIndex = 0;
            this.picBan.TabStop = false;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.bttSave.FlatAppearance.BorderSize = 0;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.White;
            this.bttSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttSave.Location = new System.Drawing.Point(406, 165);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(64, 29);
            this.bttSave.TabIndex = 31;
            this.bttSave.Text = "Lưu";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Bida.Properties.Resources.add_user;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(357, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 29);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 537);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblnv);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(label2);
            this.Controls.Add(this.comKH);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.picBan);
            this.Name = "frmBan";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBan;
        private MetroFramework.Drawing.Html.HtmlLabel lblBan;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnBack;
        private MetroFramework.Controls.MetroComboBox comKH;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblnv;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChange;
        private MetroFramework.Controls.MetroLabel lblDate;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.Button btnAdd;
    }
}