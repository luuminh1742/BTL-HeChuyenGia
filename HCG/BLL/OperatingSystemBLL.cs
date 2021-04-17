using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class OperatingSystemBLL
    {
        private static OperatingSystemDAL osDAL = new OperatingSystemDAL();
        public static List<OperatingSystemDTO> FindAll()
        {
            return osDAL.FindAll();
        }
    }
}
