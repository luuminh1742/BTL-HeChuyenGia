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

        private void ConvertDataMobile(Mobile mobile, MobileDTO mobileDTO)
        {
            mobile.Name = mobileDTO.Name;
            mobile.Price = mobileDTO.Price;
            mobile.Brand = mobileDTO.Brand;
            mobile.Color = mobileDTO.Color;
            mobile.Screen = mobileDTO.Screen;
            mobile.Ram = mobileDTO.Ram;
            mobile.Camera = mobileDTO.Camera;
            mobile.Storage = mobileDTO.Storage;
            mobile.OperatingSystem = mobileDTO.OperatingSystem;
        }

        public bool Insert(MobileDTO mobileDTO)
        {
            Mobile mobile = new Mobile();
            mobile.Id = mobileDTO.Id;
            ConvertDataMobile(mobile, mobileDTO);
            db.Mobiles.InsertOnSubmit(mobile);
            db.SubmitChanges();
            return true;
        }

        public bool Update (MobileDTO mobileDTO)
        {
            Mobile mobile = db.Mobiles.Single(mb => mb.Id.Equals(mobileDTO.Id));
            ConvertDataMobile(mobile, mobileDTO);
            db.SubmitChanges();
            return true;
        }

        public bool Delete(MobileDTO mobileDTO)
        {
            Mobile mobile = db.Mobiles.Single(mb => mb.Id.Equals(mobileDTO.Id));
            db.Mobiles.DeleteOnSubmit(mobile);
            db.SubmitChanges();
            return true;
        }

    }
}
