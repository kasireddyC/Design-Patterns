using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class HondaCompactSuv : ISuv
    {
        public string Name()
        {
            return "Honda CR-V";
        }
    }
}
