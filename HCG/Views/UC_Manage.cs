using HCG.BLL;
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
        }

        private void LoadRule()
        {
            List<string> rules = new List<string>(); 
            RulesBLL.FindAll().ForEach(rule => {
                rules.Add(string.Join("^",rule.Left)+" -> "+ rule.Right);
            });
            dgvRules.DataSource = rules.Select(x => new { Rule = x }).ToList();
            dgvRules.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadEvent()
        {
            StringBuilder gd = new StringBuilder("");
            GenderBLL.FindAll().ForEach(x=>{
                gd.Append(x.Id+" : "+x.Name+"\n");
            });
            StringBuilder ou = new StringBuilder();
            ObjectUsingBLL.FindAll().ForEach(x =>
            {
                ou.Append(x.Id + " : " + x.Name + "\n");
            });
            StringBuilder pp = new StringBuilder();
            PurposeBLL.FindAll().ForEach(x =>
            {
                pp.Append(x.Id + " : " + x.Name + "\n");
            });
            StringBuilder pr = new StringBuilder();
            PriceBLL.FindAll().ForEach(x =>
            {
                pr.Append(x.Id + " : " + x.Name + "\n");
            });
            StringBuilder br = new StringBuilder();
            BrandBLL.FindAll().ForEach(x =>
            {
                br.Append(x.Id + " : " + x.Name + "\n");
            });
            StringBuilder cl = new StringBuilder();
            ColorBLL.FindAll().ForEach(x =>
            {
                cl.Append(x.Id + " : " + x.Name + "\n");
            });
            lbGD.Text = gd.ToString();
            lbOU.Text = ou.ToString();
            lbBR.Text = br.ToString();
            lbCL.Text = cl.ToString();
            lbPP.Text = pp.ToString();
            lbPR.Text = pr.ToString();
        }
    }
}
