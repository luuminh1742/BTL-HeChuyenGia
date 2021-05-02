
namespace HCG.Views
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnInfor = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnConsultant = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.uC_Home1 = new HCG.Views.UC_Home();
            this.uC_Consultant1 = new HCG.Views.UC_Consultant();
            this.uC_Infor1 = new HCG.Views.UC_Infor();
            this.uC_Manage1 = new HCG.Views.UC_Manage();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.panelSidebar.Controls.Add(this.btnInfor);
            this.panelSidebar.Controls.Add(this.btnManager);
            this.panelSidebar.Controls.Add(this.btnConsultant);
            this.panelSidebar.Controls.Add(this.SidePanel);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(299, 770);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnInfor
            // 
            this.btnInfor.FlatAppearance.BorderSize = 0;
            this.btnInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfor.ForeColor = System.Drawing.Color.White;
            this.btnInfor.Image = global::HCG.Properties.Resources.information_25px;
            this.btnInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.Location = new System.Drawing.Point(12, 425);
            this.btnInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(287, 66);
            this.btnInfor.TabIndex = 6;
            this.btnInfor.Text = "         Thông tin";
            this.btnInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.UseVisualStyleBackColor = true;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // btnManager
            // 
            this.btnManager.FlatAppearance.BorderSize = 0;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.White;
            this.btnManager.Image = global::HCG.Properties.Resources.manager_25px;
            this.btnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Location = new System.Drawing.Point(12, 356);
            this.btnManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(287, 66);
            this.btnManager.TabIndex = 5;
            this.btnManager.Text = "         Quản lý";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnConsultant
            // 
            this.btnConsultant.FlatAppearance.BorderSize = 0;
            this.btnConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultant.ForeColor = System.Drawing.Color.White;
            this.btnConsultant.Image = global::HCG.Properties.Resources.consultation_25px;
            this.btnConsultant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultant.Location = new System.Drawing.Point(12, 287);
            this.btnConsultant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultant.Name = "btnConsultant";
            this.btnConsultant.Size = new System.Drawing.Size(287, 66);
            this.btnConsultant.TabIndex = 3;
            this.btnConsultant.Text = "         TƯ VẤN";
            this.btnConsultant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultant.UseVisualStyleBackColor = true;
            this.btnConsultant.Click += new System.EventHandler(this.btnConsultant_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 219);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 66);
            this.SidePanel.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::HCG.Properties.Resources.windows_client_25px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 218);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(287, 66);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "         TRANG CHỦ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(299, 212);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "MUA ĐIỆN THOẠI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "TƯ VẤN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = global::HCG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Location = new System.Drawing.Point(299, 0);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(1213, 6);
            this.panelHeader1.TabIndex = 1;
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.White;
            this.panelHeader2.Controls.Add(this.btnMinimized);
            this.panelHeader2.Controls.Add(this.btnFullScreen);
            this.panelHeader2.Controls.Add(this.lbTitle);
            this.panelHeader2.Controls.Add(this.btnCloseApp);
            this.panelHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader2.Location = new System.Drawing.Point(299, 6);
            this.panelHeader2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader2.Name = "panelHeader2";
            this.panelHeader2.Size = new System.Drawing.Size(1213, 39);
            this.panelHeader2.TabIndex = 3;
            this.panelHeader2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader2_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = global::HCG.Properties.Resources.subtract_20px;
            this.btnMinimized.Location = new System.Drawing.Point(1030, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(61, 39);
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Image = global::HCG.Properties.Resources.full_screen_20px;
            this.btnFullScreen.Location = new System.Drawing.Point(1091, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(61, 39);
            this.btnFullScreen.TabIndex = 2;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(130, 29);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Trang chủ";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Image = global::HCG.Properties.Resources.delete_15px;
            this.btnCloseApp.Location = new System.Drawing.Point(1152, 0);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(61, 39);
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            this.btnCloseApp.MouseLeave += new System.EventHandler(this.btnCloseApp_MouseLeave);
            this.btnCloseApp.MouseHover += new System.EventHandler(this.btnCloseApp_MouseHover);
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_Home1.BackgroundImage")));
            this.uC_Home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(299, 45);
            this.uC_Home1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1213, 725);
            this.uC_Home1.TabIndex = 4;
            // 
            // uC_Consultant1
            // 
            this.uC_Consultant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Consultant1.Location = new System.Drawing.Point(0, 0);
            this.uC_Consultant1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Consultant1.Name = "uC_Consultant1";
            this.uC_Consultant1.Size = new System.Drawing.Size(1512, 770);
            this.uC_Consultant1.TabIndex = 5;
            // 
            // uC_Infor1
            // 
            this.uC_Infor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Infor1.Location = new System.Drawing.Point(0, 0);
            this.uC_Infor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Infor1.Name = "uC_Infor1";
            this.uC_Infor1.Size = new System.Drawing.Size(1512, 770);
            this.uC_Infor1.TabIndex = 7;
            // 
            // uC_Manage1
            // 
            this.uC_Manage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Manage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Manage1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Manage1.Name = "uC_Manage1";
            this.uC_Manage1.Size = new System.Drawing.Size(1512, 770);
            this.uC_Manage1.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 770);
            this.Controls.Add(this.uC_Home1);
            this.Controls.Add(this.panelHeader2);
            this.Controls.Add(this.panelHeader1);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.uC_Consultant1);
            this.Controls.Add(this.uC_Infor1);
            this.Controls.Add(this.uC_Manage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            this.panelHeader2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnConsultant;
        private UC_Home uC_Home1;
        private UC_Consultant uC_Consultant1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnInfor;
        private UC_Infor uC_Infor1;
        private UC_Manage uC_Manage1;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnMinimized;
    }
}