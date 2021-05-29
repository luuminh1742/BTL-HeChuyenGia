using HCG.BLL;
using HCG.DTO;
using HCG.Utils;
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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            List<RuleDTO> listRule = RulesBLL.FindAll();
            List<RuleDEMO> rules1 = new List<RuleDEMO>();

            int count = 1;
            listRule.ForEach(rule => {
                RuleDEMO ruleTMP = new RuleDEMO();
                ruleTMP.STT = count++;
                ruleTMP.Id = rule.Id;
                ruleTMP.Rule = string.Join("^", rule.Left) + " -> " + rule.Right;
                rules1.Add(ruleTMP);
            });



            dgvRule.DataSource = rules1;
            dgvRule.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            List<RuleDEMO> rules = new List<RuleDEMO>();
            count = 1;
            ForwardChainingUtil.OptimizeRule(listRule).ForEach(rule=>{
                RuleDEMO ruleTMP = new RuleDEMO();
                ruleTMP.STT = count++;
                ruleTMP.Id = rule.Id;
                ruleTMP.Rule = string.Join("^", rule.Left) + " -> " + rule.Right;
                rules.Add(ruleTMP);
            });
            
            dgvTest.DataSource = rules;
            dgvTest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }


        class RuleDEMO
        {
            public int STT { get; set; }
            public int Id { get; set; }
            public string Rule { get; set; }
        }
    }
}
