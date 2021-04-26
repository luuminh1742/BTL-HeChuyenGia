using HCG.DAL;
using HCG.DTO;
using System.Collections.Generic;

namespace HCG.BLL
{
    class PriceBLL
    {
        private static PriceDAL priceDAL = new PriceDAL();
        public static List<PriceDTO> FindAll()
        {
            PriceDTO priceDTO = new PriceDTO();
            priceDTO.Id = "PR0";
            priceDTO.Name = "Không biết";
            var result = priceDAL.FindAll();
            result.Add(priceDTO);
            return result;
        }
    }
}
