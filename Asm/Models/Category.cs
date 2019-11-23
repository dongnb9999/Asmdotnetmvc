using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Asm.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameVN { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}