using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Dtos
{
    public class ResultProductDto //sql den gelen tablo propertyleri tutulacak
        //dto :data transfer object sql de propertyleri  C#' taki propertyler ile eşleştirmek
    {
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
