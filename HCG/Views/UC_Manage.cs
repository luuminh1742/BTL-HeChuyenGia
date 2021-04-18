using HCG.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            dgvProduct.DataSource = MobileBLL.FindAll();
            this.dgvProduct.Columns["Id"].Visible = false;
            this.dgvProduct.Columns[1].Width = 200;
            List<string> rules = new List<string>(); 
            RulesBLL.FindAll().ForEach(rule => {
                rules.Add(string.Join("^",rule.Left)+" -> "+ rule.Right);
            });
            dgvRules.DataSource = rules.Select(x => new { Value = x }).ToList();
            dgvRules.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
