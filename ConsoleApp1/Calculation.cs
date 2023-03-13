using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Calculation
    {
        static void Main(string[] args)
        {
            
        }

        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {

            if(productType == 0 || materialType == 0 || count == 0 || width <= 0 || length <= 0)
            {
                return -1;
            }
            float productTypeCoefficient = 0f;
            float materialScrapRate = 0f; // процент брака материала

            switch (productType)
            {
                case 1: productTypeCoefficient = 1.1f;
                    break;
                case 2: productTypeCoefficient = 2.5f;
                    break;
                case 3: productTypeCoefficient = 8.43f;
                    break;
            }
            if (productTypeCoefficient == 0f)
            {
                return -1;
            }
            
            switch (materialType)
            {
                case 1: materialScrapRate = 0.3f;
                    break;
                case 2: materialScrapRate = 0.12f;
                    break;
            }
            if (materialScrapRate == 0f)
            {
                return -1;
            }

            float square = SquareCalculation(width, length);

            float qualityRawMaterials = QualityRawMaterialsCalculation(square, productTypeCoefficient, count);
            float materialScrape = (float)Math.Ceiling((qualityRawMaterials * materialScrapRate) / 100);

            int result = Convert.ToInt32(Math.Ceiling(qualityRawMaterials + materialScrape));

            return result;
        }
        public float SquareCalculation(float width, float length)
        {
            return width * length;
        }

        public float QualityRawMaterialsCalculation(float square, float productTypeCoefficient, int count)
        {
            return square * productTypeCoefficient * count;
        }
    }
}
