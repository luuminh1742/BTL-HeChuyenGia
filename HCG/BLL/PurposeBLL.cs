using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class PurposeBLL
    {
        private static PurposeDAL purposeDAL = new PurposeDAL();
        public static List<PurposeDTO> FindAll()
        {
            var purposeDTO = new PurposeDTO();
            purposeDTO.Id = "PP0";
            purposeDTO.Name = "Không biết";
            var result = purposeDAL.FindAll();
            result.Add(purposeDTO);
            return result;
        }
    }
}