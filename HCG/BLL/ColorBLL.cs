using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class ColorBLL
    {
        private static ColorDAL colorDAL = new ColorDAL();
        public static List<ColorDTO> FindAll()
        {
            return colorDAL.FindAll();
        }
    }
}
