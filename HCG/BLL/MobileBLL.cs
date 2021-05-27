using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class MobileBLL
    {
        private static MobileDAL mobileDAL = new MobileDAL();

        public static List<MobileDTO> FindAll()
        {
            return mobileDAL.FindAll();
        }
        public static MobileDTO FindById(string id)
        {
            return mobileDAL.FindById(id);
        }

        public static bool Insert(MobileDTO mobileDTO)
        {
            return mobileDAL.Insert(mobileDTO);
        }
        public static bool Update(MobileDTO mobileDTO)
        {
            return mobileDAL.Update(mobileDTO);
        }
        public static bool Delete(MobileDTO mobileDTO)
        {
            return mobileDAL.Delete(mobileDTO);
        }
    }
}
