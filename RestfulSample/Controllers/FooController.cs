using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer;

namespace RestfulSample.Controllers
{
    // default route for this controller will be /api/example
    // .net by default ignores "controller" on the end of the class name and uses the remainder as a route
    // routing rules are set in WebApiConfig.cs
    // custom routing can be added to an individual method using the [Route("/custompath/custom/{param}/otherthing")] function decoration
    public class FooController : ApiController
    {
        private IFooRepo fooRepo = DataFactory.getFooRepo();

        public IHttpActionResult get()
        {
            return Ok(fooRepo.getAllFoo());
        }

        public IHttpActionResult post()
        {
            Foo randomFoo = new Foo();
            randomFoo.text = "your text goes here";
            Foo databaseFoo = fooRepo.createFoo(randomFoo);
            return Ok(databaseFoo);
        }

        [Route("api/foo/{guid}")]
        public IHttpActionResult getFoo(string guid)
        {
            // this line could be replaced by DB query
            Foo target = fooRepo.getFoo(new Guid(guid));

            // return result
            if (null == target)
            {
                return NotFound();
            }
            return Ok(target);
        }
    }
}
