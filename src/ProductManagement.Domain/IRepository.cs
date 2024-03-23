﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain
{
    public interface IRepository
    {
        Task<int> SaveChangesAsync();
    }
}
