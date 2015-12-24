using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Models
{
    public class Foo
    {
        [Key]
        public Guid id { get; set; }
        public String text { get; set; }

    }
}