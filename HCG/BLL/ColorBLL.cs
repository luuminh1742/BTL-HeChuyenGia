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
            var result = colorDAL.FindAll();
            ColorDTO colorDTO = new ColorDTO();
            colorDTO.Id = "CL0";
            colorDTO.Name = "Không biết";
            result.Add(colorDTO);
            return result;
        }
    }
}
