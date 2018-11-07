﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
