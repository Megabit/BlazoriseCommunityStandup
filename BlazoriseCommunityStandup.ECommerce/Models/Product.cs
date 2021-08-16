using System.Text;
using System.Threading.Tasks;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    //An actual Order item based on a Product definition
    public class ProductOrderItem 
    {
        public ProductOrderItem( Product product)
            => Product = product;

        public void IncreaseQuantity()
        {
            //Evaluate max allowed...etc...
            Quantity++;
        }

        public Product Product { get; private set; }

        public int Quantity { get; set; } = 1;

        public decimal GetOrderItemPrice()
            => Product.GetFinalPrice() * Quantity;

        public decimal GetOrderItemDiscount()
            => Product.Discount ?? 0 * Quantity;
    }
    
    //A product definition
    public class Product
    {
        private static int productIdIncrementer;

        public Product( string name, string imageUrl, int price, int? discount, bool isNew, bool isHot, string description = null )
        {
            Name = name;
            ImageUrl = imageUrl;
            Price = price;
            Discount = discount;
            IsNew = isNew;
            IsHot = isHot;
            Description = description;
            Id = productIdIncrementer++;
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
