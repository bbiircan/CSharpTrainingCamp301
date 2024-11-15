﻿namespace CSharpTrainingCamp301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
