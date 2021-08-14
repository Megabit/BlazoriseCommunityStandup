using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    public class Product
    {
        public Product( string name, string imageUrl, int price, int? discount, bool isNew, bool isHot, string description = null )
        {
            Name = name;
            ImageUrl = imageUrl;
            Price = price;
            Discount = discount;
            IsNew = isNew;
            IsHot = isHot;
            Description = description;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int Price { get; set; }

        public int? Discount { get; set; }

        public bool IsNew { get; set; }

        public bool IsHot { get; set; }

        public string Description { get; set; }

        public int GetFinalPrice()
             => (int)( Price - ( Price * Discount.GetValueOrDefault( 0 ) / 100m ) );
    }
}
