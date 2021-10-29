using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

 namespace Entities.Concrete
 {
   public class Product:IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
 }

