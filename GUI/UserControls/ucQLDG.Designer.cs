﻿namespace GUI.UserControls
{
    partial class ucQLDG
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.butLoaiDG = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butDocGia = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BorderColor = System.Drawing.Color.RoyalBlue;
            this.container.BorderRadius = 30;
            this.container.BorderThickness = 2;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.AliceBlue;
            this.container.Location = new System.Drawing.Point(0, 38);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(997, 614);
            this.container.TabIndex = 5;
            this.container.Text = "siticoneContainerControl2";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.siticoneGradientPanel1.Controls.Add(this.siticoneContainerControl1);
            this.siticoneGradientPanel1.Controls.Add(this.butLoaiDG);
            this.siticoneGradientPanel1.Controls.Add(this.butDocGia);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(997, 38);
            this.siticoneGradientPanel1.TabIndex = 4;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Location = new System.Drawing.Point(3, 62);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(229, 200);
            this.siticoneContainerControl1.TabIndex = 1;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // butLoaiDG
            // 
            this.butLoaiDG.BackColor = System.Drawing.Color.Transparent;
            this.butLoaiDG.BorderColor = System.Drawing.Color.GhostWhite;
            this.butLoaiDG.BorderRadius = 20;
            this.butLoaiDG.BorderThickness = 2;
            this.butLoaiDG.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butLoaiDG.CheckedState.CustomBorderColor = System.Drawing.Color.Lavender;
            this.butLoaiDG.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.butLoaiDG.CheckedState.ForeColor = System.Drawing.Color.Lavender;
            this.butLoaiDG.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butLoaiDG.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butLoaiDG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLoaiDG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLoaiDG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLoaiDG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLoaiDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.butLoaiDG.FillColor = System.Drawing.Color.DodgerBlue;
            this.butLoaiDG.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLoaiDG.ForeColor = System.Drawing.Color.Lavender;
            this.butLoaiDG.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butLoaiDG.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butLoaiDG.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butLoaiDG.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butLoaiDG.Location = new System.Drawing.Point(180, 0);
            this.butLoaiDG.Name = "butLoaiDG";
            this.butLoaiDG.PressedColor = System.Drawing.Color.Transparent;
            this.butLoaiDG.Size = new System.Drawing.Size(180, 38);
            this.butLoaiDG.TabIndex = 1;
            this.butLoaiDG.Text = "Loại độc giả";
            this.butLoaiDG.Click += new System.EventHandler(this.butLoaiDG_Click);
            // 
            // butDocGia
            // 
            this.butDocGia.BackColor = System.Drawing.Color.Transparent;
            this.butDocGia.BorderColor = System.Drawing.Color.GhostWhite;
            this.butDocGia.BorderRadius = 20;
            this.butDocGia.BorderThickness = 2;
            this.butDocGia.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butDocGia.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butDocGia.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.butDocGia.CheckedState.ForeColor = System.Drawing.Color.Lavender;
            this.butDocGia.CustomBorderColor = System.Drawing.Color.Transparent;
            this.butDocGia.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.butDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDocGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.butDocGia.FillColor = System.Drawing.Color.DodgerBlue;
            this.butDocGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDocGia.ForeColor = System.Drawing.Color.Lavender;
            this.butDocGia.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butDocGia.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butDocGia.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butDocGia.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butDocGia.Location = new System.Drawing.Point(0, 0);
            this.butDocGia.Name = "butDocGia";
            this.butDocGia.PressedColor = System.Drawing.Color.Transparent;
            this.butDocGia.Size = new System.Drawing.Size(180, 38);
            this.butDocGia.TabIndex = 0;
            this.butDocGia.Text = "Độc giả";
            this.butDocGia.Click += new System.EventHandler(this.butDocGia_Click);
            // 
            // ucQLDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucQLDG";
            this.Size = new System.Drawing.Size(997, 652);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDocGia;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butLoaiDG;
    }
}
