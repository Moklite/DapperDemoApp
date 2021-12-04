using DapperDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemoApp.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
