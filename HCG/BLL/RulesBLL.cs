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

        public static RuleDTO FindByID(int id)
        {
            return rulesDAL.FindById(id);
        }
        public static bool Insert(string left,string right)
        {
            return rulesDAL.Insert(left,right);
        }

        public static bool Delete(int id)
        {
            return rulesDAL.Delete(id);
        }
    }
}
