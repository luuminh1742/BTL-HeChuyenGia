using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class ColorDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<ColorDTO> FindAll()
        {
            var query = db.Colors.Select(x =>
                new ColorDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
