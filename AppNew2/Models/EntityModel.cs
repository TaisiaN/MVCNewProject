using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppNew2.Models
{
    public class EntityModel: DbContext
    {
        public DbSet<CustomerOrderModel> CustomerOrderModels { get; set; }
    }
}