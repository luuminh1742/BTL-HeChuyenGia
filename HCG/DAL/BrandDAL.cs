using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class BrandDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<BrandDTO> FindAll()
        {
            var query = db.Brands.Select(x =>
                new BrandDTO
                {
                    Id = x.Id,
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
