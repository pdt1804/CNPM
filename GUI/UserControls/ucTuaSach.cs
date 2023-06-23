﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI.UserControls
{
    public partial class ucTuaSach : UserControl
    {
        public ucTuaSach()
        {
            InitializeComponent();
            comboTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comboTheLoai.DisplayMember = "TenTheLoai";
            comboTheLoai.ValueMember = "id";

        }
        public void Binding(List<TUASACH> TuaSachList)
        {

            
            TuaSachGrid.Rows.Clear();
            // Icon myIcon = new Icon("F:\\QLTV\\GUI\\Resources\\edit_icon.png");
            foreach (TUASACH tuasach in TuaSachList)
            {
                string tacgia = "";
                foreach (TACGIA tg in tuasach.TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);
                TuaSachGrid.Rows.Add(0, tuasach.id, tuasach.MaTuaSach, tuasach.TenTuaSach, tuasach.THELOAI.TenTheLoai, tacgia, tuasach.DaAn);
            }
        }
        private void ucTuaSach_Load(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

       


    }
}
