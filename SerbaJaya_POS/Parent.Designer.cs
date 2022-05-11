namespace SerbaJaya_POS
{
    partial class Parent
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.KasirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripGudang = new System.Windows.Forms.ToolStripMenuItem();
            this.gudangCek = new System.Windows.Forms.ToolStripMenuItem();
            this.gudangKonfirmasi = new System.Windows.Forms.ToolStripMenuItem();
            this.stripManager = new System.Windows.Forms.ToolStripMenuItem();
            this.managerEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.managerPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.managerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.stripUser = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripKasir,
            this.stripGudang,
            this.stripManager,
            this.stripUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripKasir
            // 
            this.stripKasir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KasirMenu});
            this.stripKasir.Name = "stripKasir";
            this.stripKasir.Size = new System.Drawing.Size(65, 29);
            this.stripKasir.Text = "Kasir";
            this.stripKasir.Visible = false;
            // 
            // KasirMenu
            // 
            this.KasirMenu.Name = "KasirMenu";
            this.KasirMenu.Size = new System.Drawing.Size(201, 34);
            this.KasirMenu.Text = "Menu Kasir";
            this.KasirMenu.Click += new System.EventHandler(this.KasirMenu_Click);
            // 
            // stripGudang
            // 
            this.stripGudang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gudangCek,
            this.gudangKonfirmasi});
            this.stripGudang.Name = "stripGudang";
            this.stripGudang.Size = new System.Drawing.Size(119, 29);
            this.stripGudang.Text = "WareHouse";
            this.stripGudang.Visible = false;
            // 
            // gudangCek
            // 
            this.gudangCek.Name = "gudangCek";
            this.gudangCek.Size = new System.Drawing.Size(258, 34);
            this.gudangCek.Text = "Cek Gudang";
            // 
            // gudangKonfirmasi
            // 
            this.gudangKonfirmasi.Name = "gudangKonfirmasi";
            this.gudangKonfirmasi.Size = new System.Drawing.Size(258, 34);
            this.gudangKonfirmasi.Text = "Konfirmasi Barang";
            // 
            // stripManager
            // 
            this.stripManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerEmployee,
            this.managerPurchase,
            this.managerReport});
            this.stripManager.Name = "stripManager";
            this.stripManager.Size = new System.Drawing.Size(98, 29);
            this.stripManager.Text = "Manager";
            this.stripManager.Visible = false;
            // 
            // managerEmployee
            // 
            this.managerEmployee.Name = "managerEmployee";
            this.managerEmployee.Size = new System.Drawing.Size(242, 34);
            this.managerEmployee.Text = "Menu Employee";
            // 
            // managerPurchase
            // 
            this.managerPurchase.Name = "managerPurchase";
            this.managerPurchase.Size = new System.Drawing.Size(242, 34);
            this.managerPurchase.Text = "Menu Purchase";
            // 
            // managerReport
            // 
            this.managerReport.Name = "managerReport";
            this.managerReport.Size = new System.Drawing.Size(242, 34);
            this.managerReport.Text = "Cetak Report";
            // 
            // stripUser
            // 
            this.stripUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stripUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfile,
            this.changePasswordToolStripMenuItem,
            this.userLogOut});
            this.stripUser.Name = "stripUser";
            this.stripUser.Size = new System.Drawing.Size(115, 32);
            this.stripUser.Text = "Nama User";
            // 
            // userProfile
            // 
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(270, 34);
            this.userProfile.Text = "Setting Profil";
            this.userProfile.Click += new System.EventHandler(this.userProfile_Click);
            // 
            // userLogOut
            // 
            this.userLogOut.Name = "userLogOut";
            this.userLogOut.Size = new System.Drawing.Size(270, 34);
            this.userLogOut.Text = "Log Out";
            this.userLogOut.Click += new System.EventHandler(this.userLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 412);
            this.panel1.TabIndex = 3;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.Text = "Serba Jaya";
            this.Load += new System.EventHandler(this.Parent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripKasir;
        private System.Windows.Forms.ToolStripMenuItem KasirMenu;
        private System.Windows.Forms.ToolStripMenuItem stripGudang;
        private System.Windows.Forms.ToolStripMenuItem gudangCek;
        private System.Windows.Forms.ToolStripMenuItem gudangKonfirmasi;
        private System.Windows.Forms.ToolStripMenuItem stripManager;
        private System.Windows.Forms.ToolStripMenuItem managerEmployee;
        private System.Windows.Forms.ToolStripMenuItem managerPurchase;
        private System.Windows.Forms.ToolStripMenuItem managerReport;
        private System.Windows.Forms.ToolStripMenuItem stripUser;
        private System.Windows.Forms.ToolStripMenuItem userProfile;
        private System.Windows.Forms.ToolStripMenuItem userLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}

