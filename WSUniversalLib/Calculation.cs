using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {

        /// <summary>
        ///  рассчитывать целое количество сырья, необходимого для производства определенного количества (count) продукции
        /// </summary>
        /// <param name="productType"> Тип продукции  </param>
        /// <param name="materialType">Тип материала</param>
        /// <param name="count">Кол-во</param>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длинна</param>
        /// <returns>целое количество необходимого сырья, -1 если не  корректные  данные </returns>
        public int GetQuantityForProduct (int productType, int materialType, int count, float width, float length)
        {
            #region проверки

            if (count <= 0)
                return -1;

            if (width <= 0)
                return -1;

            if (length <= 0)
                return -1;

            MaterialsMock material = new MaterialsMock ();
            ProdutsMock produts = new ProdutsMock ();   

            if( material.Materials.Any(x=>x.MaterialId == materialType)==false)
                return -1;

            if(produts.ProdutList.Any(x=>x.ProdutId==productType) == false)
                 return -1;
            #endregion

            float coefProdect = produts.ProdutList.Single(x => x.ProdutId == productType).CoefficientProdut;

            float defect = material.Materials.Single(x => x.MaterialId == materialType).DefectMaterial;

            float materialCountNotDefect = (float) ((float)count *( coefProdect * width * length));

            int materialCountNotDefectInt = (int ) Math.Ceiling(materialCountNotDefect);

            int  defectCountInt = (int ) Math.Ceiling(materialCountNotDefectInt * defect);

            int  itog = materialCountNotDefectInt + defectCountInt;
           
            return itog;
        }
    }
}
