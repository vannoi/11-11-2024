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
    public partial class FrmQuanLyHocSinh : Form
    {
        bllHocSinh hs = null;
        public FrmQuanLyHocSinh()
        {
            InitializeComponent();
            hs = new bllHocSinh();
            LoadLop();
        }
        public void LoadLop()
        {
            var danhSachLop = hs.Load_Lop();
            cbLop.DataSource = danhSachLop;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maLop = cbLop.SelectedIndex;
            dgvHocSinh.DataSource = hs.Load_Hocsinh_TheoLop(maLop);

        }
        public void DSHocSinh()
        {
            dgvHocSinh.DataSource = hs.DSHocSinh();
        }

        private void FrmQuanLyHocSinh_Load(object sender, EventArgs e)
        {
            DSHocSinh();
        }
    }
}
