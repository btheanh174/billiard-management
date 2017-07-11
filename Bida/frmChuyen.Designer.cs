namespace Bida
{
    partial class frmChuyen
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Tab1 = new MetroFramework.Controls.MetroTabPage();
            this.Tab2 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNV = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Tab1);
            this.metroTabControl1.Controls.Add(this.Tab2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(10, 89);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(747, 511);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Tab1
            // 
            this.Tab1.AutoScroll = true;
            this.Tab1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Tab1.ForeColor = System.Drawing.Color.Black;
            this.Tab1.HorizontalScrollbar = true;
            this.Tab1.HorizontalScrollbarBarColor = true;
            this.Tab1.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab1.HorizontalScrollbarSize = 30;
            this.Tab1.Location = new System.Drawing.Point(4, 44);
            this.Tab1.Name = "Tab1";
            this.Tab1.Size = new System.Drawing.Size(739, 463);
            this.Tab1.Style = MetroFramework.MetroColorStyle.Red;
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Khu vực 1";
            this.Tab1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Tab1.VerticalScrollbar = true;
            this.Tab1.VerticalScrollbarBarColor = true;
            this.Tab1.VerticalScrollbarHighlightOnWheel = false;
            this.Tab1.VerticalScrollbarSize = 10;
            this.Tab1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // Tab2
            // 
            this.Tab2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Tab2.HorizontalScrollbarBarColor = true;
            this.Tab2.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab2.HorizontalScrollbarSize = 10;
            this.Tab2.Location = new System.Drawing.Point(4, 44);
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(739, 463);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Khu vực 2";
            this.Tab2.VerticalScrollbarBarColor = true;
            this.Tab2.VerticalScrollbarHighlightOnWheel = false;
            this.Tab2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(76, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chọn bàn cần chuyển";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bida.Properties.Resources.user11;
            this.pictureBox1.Location = new System.Drawing.Point(623, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNV.Location = new System.Drawing.Point(651, 20);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(93, 25);
            this.lblNV.Style = MetroFramework.MetroColorStyle.Green;
            this.lblNV.TabIndex = 24;
            this.lblNV.Text = "Nhân Viên";
            this.lblNV.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::Bida.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(10, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 43);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 626);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmChuyen";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.frmChuyen_Load);
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Tab1;
        private MetroFramework.Controls.MetroTabPage Tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblNV;
        private System.Windows.Forms.Button btnBack;
    }
}