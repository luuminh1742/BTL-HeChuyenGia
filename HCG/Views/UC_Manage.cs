using HCG.BLL;
using HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCG.Views
{
    public partial class UC_Manage : UserControl
    {
        public int munberOfProduct = 0;
        MobileDTO mobileDTOTemp = null;
        RuleDTO ruleDTOTemp = null;
        public UC_Manage()
        {
            InitializeComponent();
        }
        private void UC_Manage_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadRule();
            LoadEvent();
        }

        private void LoadProduct()
        {
            dgvProduct.DataSource = MobileBLL.FindAll();
            this.dgvProduct.Columns["Id"].Visible = false;
            this.dgvProduct.Columns[1].Width = 200;
            munberOfProduct = MobileBLL.FindAll().Count();
        }

        private void LoadRule()
        {
            List<RuleTMP> listRule = new List<RuleTMP>();
            //List<string> rules = new List<string>(); 
            RulesBLL.FindAll().ForEach(rule => {
                //rules.Add(string.Join("^",rule.Left)+" -> "+ rule.Right);
                RuleTMP ruleTMP = new RuleTMP();
                ruleTMP.Id = rule.Id;
                ruleTMP.Rule = string.Join("^", rule.Left) + " -> " + rule.Right;
                listRule.Add(ruleTMP);
            });
            //dgvRules.DataSource = rules.Select(x => new { Rule = x }).ToList();
            dgvRules.DataSource = listRule;
            //this.dgvRules.Columns["Id"].Visible = false;
            dgvRules.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadEvent()
        {
            StringBuilder gd = new StringBuilder("");
            GenderBLL.FindAll().ForEach(x=>{
                gd.Append(x.ToString());
            });
            StringBuilder ou = new StringBuilder();
            ObjectUsingBLL.FindAll().ForEach(x =>
            {
                ou.Append(x.ToString());
            });
            StringBuilder pp = new StringBuilder();
            PurposeBLL.FindAll().ForEach(x =>
            {
                pp.Append(x.ToString());
            });
            StringBuilder pr = new StringBuilder();
            PriceBLL.FindAll().ForEach(x =>
            {
                pr.Append(x.ToString());
            });
            StringBuilder br = new StringBuilder();
            BrandBLL.FindAll().ForEach(x =>
            {
                br.Append(x.ToString());
            });
            StringBuilder cl = new StringBuilder();
            ColorBLL.FindAll().ForEach(x =>
            {
                cl.Append(x.ToString());
            });
            lbGD.Text = gd.ToString();
            lbOU.Text = ou.ToString();
            lbBR.Text = br.ToString();
            lbCL.Text = cl.ToString();
            lbPP.Text = pp.ToString();
            lbPR.Text = pr.ToString();
        }


        private MobileDTO getMobile()
        {
            MobileDTO mobileDTO = new MobileDTO();
            mobileDTO.Name = txtName.Text.Trim();
            mobileDTO.Price = int.Parse(txtPrice.Text.Trim());
            mobileDTO.Brand = txtBrand.Text.Trim();
            mobileDTO.Color = txtColor.Text.Trim();
            mobileDTO.Screen = txtScreen.Text.Trim();
            mobileDTO.Ram = txtRam.Text.Trim();
            mobileDTO.Camera = txtCamera.Text.Trim();
            mobileDTO.Storage = txtStorage.Text.Trim();
            mobileDTO.OperatingSystem = txtOS.Text.Trim();
            return mobileDTO;
        }



        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                MobileDTO mobileDTO = getMobile();
                mobileDTO.Id = "MB" + (munberOfProduct + 1);
                if (MobileBLL.Insert(mobileDTO))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!","Thông báo",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadProduct();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi nhập không đúng định dạng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            string Id = dgvProduct.Rows[row].Cells[0].Value.ToString();
            mobileDTOTemp = MobileBLL.FindById(Id);

            txtName.Text = mobileDTOTemp.Name;
            txtPrice.Text = mobileDTOTemp.Price.ToString();
            txtBrand.Text = mobileDTOTemp.Brand;
            txtColor.Text = mobileDTOTemp.Color;
            txtScreen.Text = mobileDTOTemp.Screen;
            txtRam.Text = mobileDTOTemp.Ram;
            txtCamera.Text = mobileDTOTemp.Camera;
            txtStorage.Text = mobileDTOTemp.Storage;
            txtOS.Text = mobileDTOTemp.OperatingSystem;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if(mobileDTOTemp != null)
            {
                if (MobileBLL.Delete(mobileDTOTemp))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProduct();
                    mobileDTOTemp = null;
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (mobileDTOTemp != null)
            {
                MobileDTO mobileDTO = getMobile();
                mobileDTO.Id = mobileDTOTemp.Id;
                if (MobileBLL.Update(mobileDTO))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProduct();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần cập nhật!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsertRule_Click(object sender, EventArgs e)
        {
            string left = txtRuleLeft.Text.Trim();
            string right = txtRuleRight.Text.Trim();
            if(RulesBLL.Insert(left, right))
            {
                MessageBox.Show("Thêm luật thành công!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRule();
            }
        }

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (ruleDTOTemp != null)
            {
                if (RulesBLL.Delete(ruleDTOTemp.Id))
                {
                    MessageBox.Show("Xóa luật thành công!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRule();
                    ruleDTOTemp = null;
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Xóa luật thất bại!", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvRules_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = int.Parse(dgvRules.Rows[row].Cells[0].Value.ToString());
            ruleDTOTemp = RulesBLL.FindByID(id);
            txtRuleLeft.Text = string.Join("^", ruleDTOTemp.Left);
            txtRuleRight.Text = ruleDTOTemp.Right.ToString();
        }


        class RuleTMP
        {
            public int Id { get; set; }
            public string Rule { get; set; }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
