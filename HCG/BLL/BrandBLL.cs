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
            BrandDTO brandDTO = new BrandDTO();
            brandDTO.Id = "BR0";
            brandDTO.Name = "Không biết";
            var result = brandDAL.FindAll();
            result.Add(brandDTO);
            return result;
        }
    }
}
