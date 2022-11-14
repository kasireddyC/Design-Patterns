using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class ToyotaCompactSuv: ISuv
    {
        public string Name()
        {
            return "Toyota Rav-4";
        }
    }
}
