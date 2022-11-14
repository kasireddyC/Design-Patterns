using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public class HondaCompactSedan:ISedan
    {
        public string Name()
        {
            return "Honda Amaze";
        }
    }
}
