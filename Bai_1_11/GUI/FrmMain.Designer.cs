namespace GUI
{
    partial class FrmMain
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
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuanLyHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.MenuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThongTinSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChucNang,
            this.MenuInBangDiem,
            this.MenuThongTinSV});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(824, 28);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // MenuChucNang
            // 
            this.MenuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuQuanLyHocSinh,
            this.MenuNhapDiem,
            this.đăngXuấtToolStripMenuItem,
            this.MenuDangXuat});
            this.MenuChucNang.Name = "MenuChucNang";
            this.MenuChucNang.Size = new System.Drawing.Size(93, 24);
            this.MenuChucNang.Text = "Chức năng";
            // 
            // MenuQuanLyHocSinh
            // 
            this.MenuQuanLyHocSinh.Name = "MenuQuanLyHocSinh";
            this.MenuQuanLyHocSinh.Size = new System.Drawing.Size(224, 26);
            this.MenuQuanLyHocSinh.Text = "QL Học sinh";
            this.MenuQuanLyHocSinh.Click += new System.EventHandler(this.MenuQuanLyHocSinh_Click);
            // 
            // MenuNhapDiem
            // 
            this.MenuNhapDiem.Name = "MenuNhapDiem";
            this.MenuNhapDiem.Size = new System.Drawing.Size(224, 26);
            this.MenuNhapDiem.Text = "Nhập Điểm";
            this.MenuNhapDiem.Click += new System.EventHandler(this.MenuNhapDiem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // MenuDangXuat
            // 
            this.MenuDangXuat.Name = "MenuDangXuat";
            this.MenuDangXuat.Size = new System.Drawing.Size(224, 26);
            this.MenuDangXuat.Text = "Đăng xuất";
            this.MenuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // MenuInBangDiem
            // 
            this.MenuInBangDiem.Name = "MenuInBangDiem";
            this.MenuInBangDiem.Size = new System.Drawing.Size(111, 24);
            this.MenuInBangDiem.Text = "In bảng điểm";
            this.MenuInBangDiem.Click += new System.EventHandler(this.MenuInBangDiem_Click);
            // 
            // MenuThongTinSV
            // 
            this.MenuThongTinSV.Name = "MenuThongTinSV";
            this.MenuThongTinSV.Size = new System.Drawing.Size(147, 24);
            this.MenuThongTinSV.Text = "Thông tin sinh viên";
            this.MenuThongTinSV.Click += new System.EventHandler(this.MenuThongTinSV_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 629);
            this.Controls.Add(this.MenuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMain;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem MenuQuanLyHocSinh;
        private System.Windows.Forms.ToolStripMenuItem MenuNhapDiem;
        private System.Windows.Forms.ToolStripSeparator đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem MenuInBangDiem;
        private System.Windows.Forms.ToolStripMenuItem MenuThongTinSV;
    }
}