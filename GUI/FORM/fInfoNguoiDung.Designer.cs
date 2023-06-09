﻿namespace GUI
{
    partial class fInfoNguoiDung
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
            this.errorDia = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.butChange = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMaNd = new System.Windows.Forms.Label();
            this.labelNhomND = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelTenDN = new System.Windows.Forms.Label();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorDia
            // 
            this.errorDia.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.errorDia.Caption = null;
            this.errorDia.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;
            this.errorDia.Parent = null;
            this.errorDia.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
            this.errorDia.Text = null;
            // 
            // butChange
            // 
            this.butChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butChange.BorderColor = System.Drawing.Color.Transparent;
            this.butChange.BorderRadius = 15;
            this.butChange.BorderThickness = 2;
            this.butChange.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butChange.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.butChange.CheckedState.FillColor = System.Drawing.Color.Lavender;
            this.butChange.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.butChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butChange.FillColor = System.Drawing.Color.RoyalBlue;
            this.butChange.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChange.ForeColor = System.Drawing.Color.White;
            this.butChange.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butChange.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butChange.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butChange.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butChange.Location = new System.Drawing.Point(257, 415);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(183, 46);
            this.butChange.TabIndex = 4;
            this.butChange.Text = "Sửa thông tin";
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(147, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÔNG TIN NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(30, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhóm Người Dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(30, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(30, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(30, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(30, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Đăng Nhập";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.siticonePanel1.BorderRadius = 50;
            this.siticonePanel1.BorderThickness = 2;
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.tableInfo);
            this.siticonePanel1.Controls.Add(this.butChange);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Location = new System.Drawing.Point(78, 76);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(696, 513);
            this.siticonePanel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.log_in;
            this.pictureBox1.Location = new System.Drawing.Point(84, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // tableInfo
            // 
            this.tableInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableInfo.ColumnCount = 2;
            this.tableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.83537F));
            this.tableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.16463F));
            this.tableInfo.Controls.Add(this.label3, 0, 1);
            this.tableInfo.Controls.Add(this.label4, 0, 2);
            this.tableInfo.Controls.Add(this.label5, 0, 3);
            this.tableInfo.Controls.Add(this.label6, 0, 4);
            this.tableInfo.Controls.Add(this.label7, 0, 5);
            this.tableInfo.Controls.Add(this.label11, 0, 0);
            this.tableInfo.Controls.Add(this.labelMaNd, 1, 0);
            this.tableInfo.Controls.Add(this.labelNhomND, 1, 1);
            this.tableInfo.Controls.Add(this.labelHoTen, 1, 2);
            this.tableInfo.Controls.Add(this.labelNgaySinh, 1, 3);
            this.tableInfo.Controls.Add(this.labelChucVu, 1, 4);
            this.tableInfo.Controls.Add(this.labelTenDN, 1, 5);
            this.tableInfo.Location = new System.Drawing.Point(6, 112);
            this.tableInfo.Margin = new System.Windows.Forms.Padding(6);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.tableInfo.RowCount = 6;
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableInfo.Size = new System.Drawing.Size(684, 263);
            this.tableInfo.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(30, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Người Dùng";
            // 
            // labelMaNd
            // 
            this.labelMaNd.AutoSize = true;
            this.labelMaNd.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMaNd.Location = new System.Drawing.Point(301, 7);
            this.labelMaNd.Name = "labelMaNd";
            this.labelMaNd.Size = new System.Drawing.Size(24, 31);
            this.labelMaNd.TabIndex = 0;
            this.labelMaNd.Text = "x";
            // 
            // labelNhomND
            // 
            this.labelNhomND.AutoSize = true;
            this.labelNhomND.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhomND.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNhomND.Location = new System.Drawing.Point(301, 49);
            this.labelNhomND.Name = "labelNhomND";
            this.labelNhomND.Size = new System.Drawing.Size(24, 31);
            this.labelNhomND.TabIndex = 0;
            this.labelNhomND.Text = "z";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelHoTen.Location = new System.Drawing.Point(301, 91);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(24, 31);
            this.labelHoTen.TabIndex = 0;
            this.labelHoTen.Text = "x";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNgaySinh.Location = new System.Drawing.Point(301, 133);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(24, 31);
            this.labelNgaySinh.TabIndex = 0;
            this.labelNgaySinh.Text = "x";
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChucVu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelChucVu.Location = new System.Drawing.Point(301, 175);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(24, 31);
            this.labelChucVu.TabIndex = 0;
            this.labelChucVu.Text = "x";
            // 
            // labelTenDN
            // 
            this.labelTenDN.AutoSize = true;
            this.labelTenDN.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTenDN.Location = new System.Drawing.Point(301, 217);
            this.labelTenDN.Name = "labelTenDN";
            this.labelTenDN.Size = new System.Drawing.Size(24, 31);
            this.labelTenDN.TabIndex = 0;
            this.labelTenDN.Text = "x";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.siticoneControlBox1.Location = new System.Drawing.Point(797, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(57, 45);
            this.siticoneControlBox1.TabIndex = 14;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.MidnightBlue;
            this.siticoneControlBox2.Location = new System.Drawing.Point(742, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(55, 45);
            this.siticoneControlBox2.TabIndex = 13;
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // fInfoNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 659);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInfoNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInfoNguoiDung";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableInfo.ResumeLayout(false);
            this.tableInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog errorDia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.TableLayoutPanel tableInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMaNd;
        private System.Windows.Forms.Label labelNhomND;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelTenDN;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}