﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
namespace QuanLyNhaThuoc
{
    public partial class frm_trangchu : Form
    {
        private frm_dangNhap ff;
        public nguoiDung nd = new nguoiDung();
        public string test = "sss";
        public frm_trangchu(frm_dangNhap f)
        {
            InitializeComponent();
            ff = f;
            // userControl_taikhoan1.ParentForm = this;
          
        }

        private void userControl_thuoc1_Load(object sender, EventArgs e)
        {
            userControl_thuoc1.btn_them.Enabled = false;
        }

        private void frm_trangchu_Load(object sender, EventArgs e)
        {
            panel_side.Height = btn_thuoc.Height;
            panel_side.Top = btn_thuoc.Top;
            userControl_thuoc1.BringToFront();
            label2.Text = ff.nd.Ten;
            //userControl_taikhoan1.nd = ff.nd;
            nd = ff.nd;
            userControl_taikhoan1.lb_id.Text = ff.nd.Ten;
            userControl_taikhoan1.lb_quyentruycap.Text = ff.nd.Quyen;
            userControl_taikhoan1.txtpassword.Text = "" + ff.nd.Matkhau;

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
                ff.Close();
            }
            
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_thuoc.Height;
            panel_side.Top = btn_thuoc.Top;
            userControl_thuoc1.BringToFront();
           // MessageBox.Show("s");
            
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_banhang.Height;
            userControl_banhang1.BringToFront();
            panel_side.Top = btn_banhang.Top;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_taikhoan.Height;
            userControl_taikhoan1.BringToFront();
            panel_side.Top = btn_taikhoan.Top;
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_kho.Height;
            userControl_banhang1.BringToFront();
            panel_side.Top = btn_kho.Top;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_nhanvien.Height;
            userControl_banhang1.BringToFront();
            panel_side.Top = btn_nhanvien.Top;
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_khachhang.Height;
            userControl_khachhang1.BringToFront();
            panel_side.Top = btn_khachhang.Top;
        }
    }
}
