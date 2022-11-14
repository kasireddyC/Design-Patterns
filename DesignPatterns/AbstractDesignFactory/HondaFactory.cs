using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class HondaFactory:ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            return new HondaCompactSedan();
        }

        public ISuv ManufactureSuv(string segment)
        {
            return new HondaCompactSuv();
        }
    }



    public class ToyotaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            return new ToyotaCompactSedan();
        }

        public ISuv ManufactureSuv(string segment)
        {
            return new ToyotaCompactSuv();
        }
    }
}
