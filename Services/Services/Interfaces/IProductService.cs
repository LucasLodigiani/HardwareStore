﻿using Services.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    internal interface IProductService
    {
        bool NewProduct(Product product);

    }
}
