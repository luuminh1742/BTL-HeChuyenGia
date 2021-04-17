using HCG.BLL;
using HCG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<string> rules = new List<string>(); 
            RulesBLL.FindAll().ForEach(rule => {
                rules.Add(string.Join("^",rule.Left)+"->"+ string.Join("^", rule.Right));
            });
            dgvRules.DataSource = rules.Select(x => new { Value = x }).ToList();
        }
    }
}
