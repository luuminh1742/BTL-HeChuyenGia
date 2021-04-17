using HCG.DAL;
using HCG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCG.BLL
{
    class RulesBLL
    {
        private static RulesDAL rulesDAL = new RulesDAL();
        public static List<RuleDTO> FindAll()
        {
            return rulesDAL.FindAll();
        }
    }
}
