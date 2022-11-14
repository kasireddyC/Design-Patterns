﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    public interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }
}
