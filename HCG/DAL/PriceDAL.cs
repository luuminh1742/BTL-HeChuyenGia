using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class PriceDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<PriceDTO> FindAll()
        {
            var query = db.Prices.Select(x =>
                new PriceDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.MinToMaxPrice
                }
            ).ToList();
            return query;
        }
    }
}
