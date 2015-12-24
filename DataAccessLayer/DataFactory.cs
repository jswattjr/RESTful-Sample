using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;

namespace DataAccessLayer
{
    public class DataFactory
    {
        public static IFooRepo getFooRepo()
        {
            return new FooRepo();
        }
    }
}
