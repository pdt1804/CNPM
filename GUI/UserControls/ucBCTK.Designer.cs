﻿namespace GUI.UserControls
{
    partial class ucBCTK
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
            this.butTraTre = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butTheLoai = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.AliceBlue;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.container.Location = new System.Drawing.Point(0, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(997, 602);
            this.container.TabIndex = 5;
            this.container.Text = "siticoneContainerControl2";
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.siticoneGradientPanel1.Controls.Add(this.siticoneContainerControl1);
            this.siticoneGradientPanel1.Controls.Add(this.butTraTre);
            this.siticoneGradientPanel1.Controls.Add(this.butTheLoai);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(997, 50);
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
            // butTraTre
            // 
            this.butTraTre.BackColor = System.Drawing.Color.Transparent;
            this.butTraTre.BorderColor = System.Drawing.Color.GhostWhite;
            this.butTraTre.BorderRadius = 25;
            this.butTraTre.BorderThickness = 2;
            this.butTraTre.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTraTre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.butTraTre.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butTraTre.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.butTraTre.CheckedState.ForeColor = System.Drawing.Color.Lavender;
            this.butTraTre.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTraTre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butTraTre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butTraTre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butTraTre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butTraTre.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTraTre.FillColor = System.Drawing.Color.DodgerBlue;
            this.butTraTre.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTraTre.ForeColor = System.Drawing.Color.Lavender;
            this.butTraTre.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butTraTre.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butTraTre.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butTraTre.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butTraTre.Location = new System.Drawing.Point(239, 0);
            this.butTraTre.Name = "butTraTre";
            this.butTraTre.Size = new System.Drawing.Size(239, 50);
            this.butTraTre.TabIndex = 1;
            this.butTraTre.Text = "Sách trả trễ";
            this.butTraTre.Click += new System.EventHandler(this.butTraTre_Click);
            // 
            // butTheLoai
            // 
            this.butTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.butTheLoai.BorderColor = System.Drawing.Color.GhostWhite;
            this.butTheLoai.BorderRadius = 25;
            this.butTheLoai.BorderThickness = 2;
            this.butTheLoai.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.butTheLoai.CheckedState.BorderColor = System.Drawing.Color.White;
            this.butTheLoai.CheckedState.CustomBorderColor = System.Drawing.Color.Lavender;
            this.butTheLoai.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.CheckedState.ForeColor = System.Drawing.Color.Lavender;
            this.butTheLoai.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.butTheLoai.DisabledState.BorderColor = System.Drawing.Color.White;
            this.butTheLoai.DisabledState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.DisabledState.FillColor = System.Drawing.Color.GhostWhite;
            this.butTheLoai.DisabledState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.Dock = System.Windows.Forms.DockStyle.Left;
            this.butTheLoai.FillColor = System.Drawing.Color.DodgerBlue;
            this.butTheLoai.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTheLoai.ForeColor = System.Drawing.Color.Lavender;
            this.butTheLoai.HoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.HoverState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.butTheLoai.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.butTheLoai.Location = new System.Drawing.Point(0, 0);
            this.butTheLoai.Name = "butTheLoai";
            this.butTheLoai.Size = new System.Drawing.Size(239, 50);
            this.butTheLoai.TabIndex = 0;
            this.butTheLoai.Text = "Mượn theo thể loại";
            this.butTheLoai.Click += new System.EventHandler(this.butTheLoai_Click);
            // 
            // ucBCTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "ucBCTK";
            this.Size = new System.Drawing.Size(997, 652);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl container;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTraTre;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butTheLoai;
    }
}
