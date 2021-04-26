using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class GenderDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<GenderDTO> FindAll()
        {
            var query = db.Genders.Select(x =>
                new GenderDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
