using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class CarClient
    {
        private ISedan sedan;
        private ISuv suv;

        public CarClient(ICarFactory factory, string segment)
        {
            sedan = factory.ManufactureSedan(segment);
            suv = factory.ManufactureSuv(segment);
        }

        public string GetManufacturedSedanName()
        {
            return sedan.Name();
        }

        public string GetManufacturedSuvName()
        {
            return suv.Name();
        }
    }
}
