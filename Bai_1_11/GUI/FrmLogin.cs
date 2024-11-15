using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
namespace GUI
{
    public partial class FrmLogin : Form
    {
        bll_Login ql =null;
        public FrmLogin()
        {
            InitializeComponent();
            ql=new bll_Login();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ql.Login(txtTaiKhoan.Text, txtMatKhau.Text).Rows[0]["ErrCode"].ToString() == "1")
            {
                FrmMain formMain = new FrmMain();
                formMain.Show();
                this.Hide();
                txtMatKhau.Clear();

            }
            else
            {

                lbThongBao.Text = ql.Login(txtTaiKhoan.Text, txtMatKhau.Text).Rows[0]["ErrMsg"].ToString();

                btnHuy_Click(sender, e);
            }
        }

       

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbThongBao_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void chbViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chbViewPassword.Checked;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }
    }
}
