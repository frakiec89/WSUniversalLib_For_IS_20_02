using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Produt
    {
        public int ProdutId { get; set; }
        public float CoefficientProdut { get; set; }
    }

    public class ProdutsMock
    {
        public List<Produt> ProdutList { get; set; }
         = new List<Produt>
         {
            new Produt(){ ProdutId = 1, CoefficientProdut =1.1f},

            new Produt(){ ProdutId = 2, CoefficientProdut =2.5f},

              new Produt(){ ProdutId = 3, CoefficientProdut =8.43f},
         };
    }
}
