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
    }
}
