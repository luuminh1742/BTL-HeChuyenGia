using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class PurposeDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<PurposeDTO> FindAll()
        {
            var query = db.Purposes.Select(x =>
                new PurposeDTO
                {
                    Id = x.Id,
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
