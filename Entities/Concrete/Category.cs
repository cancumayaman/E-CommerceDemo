using Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
