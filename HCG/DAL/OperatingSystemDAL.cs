using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class OperatingSystemDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<OperatingSystemDTO> FindAll()
        {
            var query = db.OperatingSystems.Select(x =>
                new OperatingSystemDTO
                {
                    Id = x.Id,
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
