using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class GenderBLL
    {
        private static GenderDAL genderDAL = new GenderDAL();
        public static List<GenderDTO> FindAll()
        {
            GenderDTO genderDTO = new GenderDTO();
            genderDTO.Id = "GD0";
            genderDTO.Name = "Khác";
            var result = genderDAL.FindAll();
            result.Add(genderDTO);
            return result;
        }
    }
}
