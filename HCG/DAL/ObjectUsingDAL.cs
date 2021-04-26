using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class ObjectUsingDAL
    {
        private dbDataContext db = new dbDataContext();
        public List<ObjectUsingDTO> FindAll()
        {
            var query = db.ObjectsUsings.Select(x =>
                new ObjectUsingDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.Name
                }
            ).ToList();
            return query;
        }
    }
}
