using HCG.BLL;
using HCG.DTO;
using HCG.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HCG.Views
{
    public partial class UC_Consultant : UserControl
    {
        public UC_Consultant()
        {
            InitializeComponent();
        }

        private void UC_Consultant_Load(object sender, EventArgs e)
        {
            this.dgvResult.Visible = false;
            // Option for brand
            cbbBrand.DataSource = BrandBLL.FindAll();
            cbbBrand.DisplayMember = "Name";
            cbbBrand.ValueMember = "Name";
            // Option for purpose
            cbbPurpose.DataSource = PurposeBLL.FindAll();
            cbbPurpose.DisplayMember = "Name";
            cbbPurpose.ValueMember = "Name";
            // Option for Price
            cbbPrice.DataSource = PriceBLL.FindAll();
            cbbPrice.DisplayMember = "Name";
            cbbPrice.ValueMember = "Name";
            // Option for OperatingSystem
            cbbOS.DataSource = OperatingSystemBLL.FindAll();
            cbbOS.DisplayMember = "Name";
            cbbOS.ValueMember = "Name";
            // Option for color
            cbbColor.DataSource = ColorBLL.FindAll();
            cbbColor.DisplayMember = "Name";
            cbbColor.ValueMember = "Name";

        }

        private void btnCounselling_Click(object sender, EventArgs e)
        {
            var assumptions = new List<string>();
            PurposeDTO purpose = (PurposeDTO)cbbPurpose.SelectedItem;
            BrandDTO brand = (BrandDTO)cbbBrand.SelectedItem;
            PriceDTO price = (PriceDTO)cbbPrice.SelectedItem;
            OperatingSystemDTO operatingSystem = (OperatingSystemDTO)cbbOS.SelectedItem;
            ColorDTO color = (ColorDTO)cbbColor.SelectedItem;
            assumptions.Add(purpose.Id.Trim());
            assumptions.Add(brand.Id.Trim());
            assumptions.Add(price.Id.Trim());
            assumptions.Add(operatingSystem.Id.Trim());
            assumptions.Add(color.Id.Trim());
            if(assumptions.Contains("B1") && assumptions.Contains("D4"))
            {
                MessageBox.Show("Bạn cần nhập lại hãng điện thoại hoặc hệ điều hành vì Apple không phải là hệ điều hành Android!","Lỗi",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(assumptions.Contains("B2") && !assumptions.Contains("D4"))
            {
                MessageBox.Show("Bạn cần nhập lại hãng điện thoại hặc hệ điều hành!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var mobiles = ForwardChainingUtil.Result(assumptions);

            if(mobiles.Count == 0)
            {
                MessageBox.Show("Chúng tôi xin lỗi vì không có loại điện thoại theo mô tả của bạn!", "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.dgvResult.Visible = true;
            this.dgvResult.DataSource = mobiles;
            this.dgvResult.Columns["Id"].Visible = false;
        }

       
    }
}
