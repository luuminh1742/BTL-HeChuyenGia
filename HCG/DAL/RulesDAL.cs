using HCG.DTO;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
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
                    Left = x.RLeft.Trim().Split('^'),
                    Right = x.RRight.Trim()
                }
            ).ToList();
            return query;
        }

        public RuleDTO FindById(int id)
        {
            var query = db.Rules.Select(x =>
                new RuleDTO
                {
                    Id = x.Id,
                    Left = x.RLeft.Trim().Split('^'),
                    Right = x.RRight.Trim()
                }
            ).Where(x => x.Id == id).SingleOrDefault();
            return query;
        }

        public bool Insert(string left, string right)
        {
            Rule rule = new Rule();

            rule.RLeft = left;
            rule.RRight = right;
            db.Rules.InsertOnSubmit(rule);
            db.SubmitChanges();
            return true;
        }
        public bool Update(int id,string left, string right)
        {
            Rule rule = new Rule();
            rule.Id = id;
            rule.RLeft = left;
            rule.RRight = right;
            db.Rules.InsertOnSubmit(rule);
            db.SubmitChanges();
            return true;
        }

        public bool Delete(int id)
        {
            Rule  rule = db.Rules.Single(mb => mb.Id == id);
            db.Rules.DeleteOnSubmit(rule);
            db.SubmitChanges();
            return true;
        }
    }
}
