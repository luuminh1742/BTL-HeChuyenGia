using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

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
