using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTrainingCamp301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock{ get; set; }
        public string ProductDescription{ get; set; }
        public virtual Category Category {  get; set; }
        public List<Order> Orders { get; set; }
    }
}
