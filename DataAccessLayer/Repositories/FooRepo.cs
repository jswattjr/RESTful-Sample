using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories
{
    public class FooRepo : IFooRepo
    {
        FooAdo fooDb = new FooAdo();

        public IEnumerable<Foo> getAllFoo()
        {
            return fooDb.FooEntities;
        }

        Foo IFooRepo.createFoo(Foo entity)
        {
            entity.id = Guid.NewGuid();
            Foo existingElement = fooDb.FooEntities.Find(entity.id);
            if (null == existingElement)
            {
                fooDb.FooEntities.Add(entity);
                fooDb.SaveChanges();
            }
            return fooDb.FooEntities.Find(entity.id);
        }

        void IFooRepo.deleteFoo(Foo entity)
        {
            fooDb.FooEntities.Remove(entity);
            fooDb.SaveChanges();
        }

        IEnumerable<Foo> IFooRepo.getAllFoo()
        {
            return fooDb.FooEntities;
        }

        Foo IFooRepo.getFoo(Guid id)
        {
            return fooDb.FooEntities.Find(id);
        }

        Foo IFooRepo.setFoo(Foo entity)
        {
            Foo existing = fooDb.FooEntities.Find(entity.id);
            existing.text = entity.text;
            fooDb.SaveChanges();
            return existing;
        }
    }
}
