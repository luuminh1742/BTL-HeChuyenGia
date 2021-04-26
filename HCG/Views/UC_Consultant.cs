using HCG.BLL;
using HCG.DTO;
using HCG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
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
            
            LoadData();
            this.dgvResult.Visible = false;
        }

        private void LoadData()
        {
            // Option for brand
            cbbBrand.DataSource = BrandBLL.FindAll();
            cbbBrand.DisplayMember = "Name";
            cbbBrand.ValueMember = "Name";
            //cbbBrand.Hide();
            // Option for purpose
            cbbPurpose.DataSource = PurposeBLL.FindAll();
            cbbPurpose.DisplayMember = "Name";
            cbbPurpose.ValueMember = "Name";
            // Option for Price
            cbbPrice.DataSource = PriceBLL.FindAll();
            cbbPrice.DisplayMember = "Name";
            cbbPrice.ValueMember = "Name";
            //cbbPrice.Hide();
            // Option for color
            cbbColor.DataSource = ColorBLL.FindAll();
            cbbColor.DisplayMember = "Name";
            cbbColor.ValueMember = "Name";
            //cbbColor.Hide();
            // Option for gender
            cbbGender.DataSource = GenderBLL.FindAll();
            cbbGender.DisplayMember = "Name";
            cbbGender.ValueMember = "Name";
            // Option for Object using 
            cbbObjectUsing.DataSource = ObjectUsingBLL.FindAll();
            cbbObjectUsing.DisplayMember = "Name";
            cbbObjectUsing.ValueMember = "Name";
        }

        private void btnCounselling_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            var assumptions = new List<string>();
            PurposeDTO purpose = (PurposeDTO)cbbPurpose.SelectedItem;
            BrandDTO brand = (BrandDTO)cbbBrand.SelectedItem;
            PriceDTO price = (PriceDTO)cbbPrice.SelectedItem;
            ColorDTO color = (ColorDTO)cbbColor.SelectedItem;
            ObjectUsingDTO objectUsing = (ObjectUsingDTO)cbbObjectUsing.SelectedItem;
            GenderDTO gender = (GenderDTO)cbbGender.SelectedItem;
            if (color.Id.Equals("CL0"))
            {
                assumptions.Add(gender.Id.Trim());
            }
            else
            {
                assumptions.Add(color.Id.Trim());
            }
            if (brand.Id.Equals("BR0"))
            {
                assumptions.Add(purpose.Id.Trim());
            }
            else
            {
                assumptions.Add(brand.Id.Trim());
            }
            if (price.Id.Equals("PR0"))
            {
                assumptions.Add(objectUsing.Id.Trim());
            }
            else
            {
                assumptions.Add(price.Id.Trim());
            }
            
      
            
            
            
            /*if (assumptions.Contains("OS1") && assumptions.Contains("BR4"))
            {
                MessageBox.Show("Bạn cần nhập lại hãng điện thoại hoặc hệ điều hành vì Apple không phải là hệ điều hành Android!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            if (assumptions.Contains("OS2") && !assumptions.Contains("BR4"))
            {
                MessageBox.Show("Bạn cần nhập lại hãng điện thoại hặc hệ điều hành!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mobiles = ForwardChainingUtil.Result(assumptions);

            if (mobiles.Count == 0)
            {
                MessageBox.Show("Chúng tôi xin lỗi vì không có loại điện thoại theo mô tả của bạn!", "Thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.dgvResult.Visible = true;
            /*List<string> checkRule = new List<string>();
            ForwardChainingUtil.testRule().ForEach(rule =>
            {
                checkRule.Add(string.Join("^", rule.Left) + " -> " + rule.Right);
            });
            this.dgvResult.DataSource = checkRule.Select(x => new { Value = x }).ToList();*/
            this.dgvResult.DataSource = mobiles;
            this.dgvResult.Columns["Id"].Visible = false;
        }
    }
}
