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
            return purposeDAL.FindAll();
        }
    }
}
