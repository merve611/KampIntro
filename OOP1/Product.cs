using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product   
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }         //Ürünün hangi kategoride olduğunu belirten ıd (bilgisyar kategorisi - giyim kategorisi )
        public string ProductName { get; set; }     //ürün
        public double UnitPrice { get; set; }       //ürünün birim fiyatı
        public int UnitsInStock { get; set; }       //Stok adeti

    }
}
