using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class RulesDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<RuleDTO> FindAll()
        {
            var query = db.Rules.Select(x =>
                new RuleDTO
                {
                    Id = x.Id,
                    Left = x.RLeft.Split('^'),
                    Right = x.RRight.Split('^')
                }
            ).ToList();
            return query;
        }
    }
}
