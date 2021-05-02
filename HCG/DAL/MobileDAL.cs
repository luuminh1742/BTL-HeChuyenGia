using HCG.DTO;
using System.Collections.Generic;
using System.Linq;

namespace HCG.DAL
{
    class MobileDAL
    {
        private dbDataContext db = new dbDataContext();

        /**
         * Phuong thuc lay toan bo dien thoai trong database
         */
        public List<MobileDTO> FindAll()
        {
            var query = db.Mobiles.Select(x =>
                new MobileDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.Name,
                    Price = (int)x.Price,
                    Brand = x.Brand,
                    Color = x.Color,
                    Screen = x.Screen,
                    Ram = x.Ram,
                    Camera = x.Camera,
                    Storage = x.Storage,
                    OperatingSystem = x.OperatingSystem
                }
            ).ToList();
            return query;
        }

        public MobileDTO FindById(string id)
        {
            var query = db.Mobiles.Select(x =>
                new MobileDTO
                {
                    Id = x.Id.Trim(),
                    Name = x.Name,
                    Price = (int)x.Price,
                    Brand = x.Brand,
                    Color = x.Color,
                    Screen = x.Screen,
                    Ram = x.Ram,
                    Camera = x.Camera,
                    Storage = x.Storage,
                    OperatingSystem = x.OperatingSystem
                }
            ).Where(x=> x.Id.Equals(id)).SingleOrDefault();
            return query;
        }


    }
}
