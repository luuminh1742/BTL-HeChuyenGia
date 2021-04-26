using HCG.BLL;
using HCG.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace HCG.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            uC_Home1.BringToFront();
            
        }

        private void panelHeader2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            uC_Home1.BringToFront();
            lbTitle.Text = " Trang chủ";
        }

        
        private void btnConsultant_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnConsultant.Height;
            SidePanel.Top = btnConsultant.Top;
            uC_Consultant1.BringToFront();
            lbTitle.Text = " Tư vấn";
        }
        private void btnCloseApp_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCloseApp_MouseHover(object sender, System.EventArgs e)
        {
            //btnCloseApp.BackColor = Color.Red;
        }

        private void btnCloseApp_MouseLeave(object sender, System.EventArgs e)
        {
            //btnCloseApp.BackColor = Color.White;
        }

        private void btnInfor_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnInfor.Height;
            SidePanel.Top = btnInfor.Top;
            uC_Infor1.BringToFront();
            lbTitle.Text = " Thông tin";
        }

        private void btnManager_Click(object sender, System.EventArgs e)
        {
            SidePanel.Height = btnManager.Height;
            SidePanel.Top = btnManager.Top;
            uC_Manage1.BringToFront();
            lbTitle.Text = " Quản lý";
        }

        private void btnFullScreen_Click(object sender, System.EventArgs e)
        {
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimized_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
