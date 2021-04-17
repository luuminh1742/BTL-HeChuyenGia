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
            return priceDAL.FindAll();
        }
    }
}
