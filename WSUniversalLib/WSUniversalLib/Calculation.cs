using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {

            if (productType != 1 && productType != 2 && productType != 3)
            {
                return -1;
            }

            if (materialType != 1 && materialType != 2)
            {
                return -1;
            }

            if (width <= 0 || length <= 0 || count <= 0)
            {
                return -1;
            }


            // Расчет без учета типов
            double quantity = width * length * count;


            if (productType == 1)
            {
                quantity = quantity * 1.1;
            }

            if (productType == 2)
            {
                quantity = quantity * 2.5;
            }

            if (productType == 3)
            {
                quantity = quantity * 8.43;
            }

            if (materialType == 1)
            {
                quantity = quantity / (1 - 0.003);
            }

            if (materialType == 2)
            {
                quantity = quantity / (1 - 0.0012);
            }
            return (int)Math.Ceiling(quantity);
        }
    }
}
