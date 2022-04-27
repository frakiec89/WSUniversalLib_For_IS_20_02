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
            return 0;
        }
    }
}
