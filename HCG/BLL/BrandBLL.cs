using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class BrandBLL
    {
        private static BrandDAL brandDAL = new BrandDAL();
        public static List<BrandDTO> FindAll()
        {
            return brandDAL.FindAll();
        }
    }
}
