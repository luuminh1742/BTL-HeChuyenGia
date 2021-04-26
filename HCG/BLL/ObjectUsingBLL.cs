using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class ObjectUsingBLL
    {
        private static ObjectUsingDAL objectUsingDAL = new ObjectUsingDAL();
        public static List<ObjectUsingDTO> FindAll()
        {
            ObjectUsingDTO objectsUsingDTO = new ObjectUsingDTO();
            objectsUsingDTO.Id = "OU0";
            objectsUsingDTO.Name = "Không biết";
            var result = objectUsingDAL.FindAll();
            result.Add(objectsUsingDTO);
            return result;
        }
    }
}
