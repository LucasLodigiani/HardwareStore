﻿using Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class Repository
    {
        private readonly ApplicationDbContext _context; 
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
