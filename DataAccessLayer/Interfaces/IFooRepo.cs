using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IFooRepo
    {
        IEnumerable<Foo> getAllFoo();

        Foo getFoo(Guid id);

        Foo setFoo(Foo entity);

        Foo createFoo(Foo entity);

        void deleteFoo(Foo entity);
    }
}
