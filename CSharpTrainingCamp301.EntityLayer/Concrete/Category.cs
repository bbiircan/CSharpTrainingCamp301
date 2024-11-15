﻿using System.Collections.Generic;

namespace CSharpTrainingCamp301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
