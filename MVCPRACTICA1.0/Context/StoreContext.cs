using MVCPRACTICA1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCPRACTICA1._0.Context
{
    public class StoreContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}