using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MenuQuanLyHocSinh_Click(sender, e);
        }

        private void MenuQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            FrmQuanLyHocSinh frmQLHS = new FrmQuanLyHocSinh();
            frmQLHS.MdiParent = this;
           
            frmQLHS.Show();
        }

        private void MenuNhapDiem_Click(object sender, EventArgs e)
        {
            FrmNhapDiem frmNhapDiem = new FrmNhapDiem();
            frmNhapDiem.MdiParent = this;
           
            frmNhapDiem.Show();
        }

        private void MenuInBangDiem_Click(object sender, EventArgs e)
        {
            FrmInBangDiem frmInBangDiem = new FrmInBangDiem();
            frmInBangDiem.MdiParent = this;
         
            frmInBangDiem.Show();
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả các form con
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            // Hiển thị lại form đăng nhập
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

       
        private void MenuThongTinSV_Click(object sender, EventArgs e)
        {
            FrmThongTinSinhVien frmThongTin = new FrmThongTinSinhVien();
            frmThongTin.MdiParent = this;
         
            frmThongTin.Show();
        }
    }
}
