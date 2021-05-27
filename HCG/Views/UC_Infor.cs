using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HCG.Views
{
    public partial class UC_Infor : UserControl
    {
        public UC_Infor()
        {
            InitializeComponent();
        }

        private void lbDocumentation_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = @"..\..\Documentation\BaoCao_BTL-HeChuyenGia_TuVanMuaDienThoai.pdf";
            p.StartInfo = pi;
            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
