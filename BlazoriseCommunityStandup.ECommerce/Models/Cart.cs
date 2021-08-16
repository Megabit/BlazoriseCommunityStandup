using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    public class Cart
    {
        public event EventHandler CartChanged;

        public int CustomerId { get; }

        private List<ProductOrderItem> orderItems = new();
        public IEnumerable<ProductOrderItem> OrderItems => orderItems?.AsEnumerable();

        public void AddProduct( Product product )
        {
            var existingProductOrderItem = orderItems.FirstOrDefault( x => x.Product.Id == product.Id );
            if ( existingProductOrderItem is not null )
                existingProductOrderItem.IncreaseQuantity();
            else
                orderItems.Add( new( product ) );

            CartChanged?.Invoke( this, EventArgs.Empty );
        }

        public void RemoveProduct( Product product )
        {
            orderItems.RemoveAll( x => x.Product.Id == product.Id );

            CartChanged?.Invoke( this, EventArgs.Empty );
        }

        public decimal GetCartTotalPrice()
            => orderItems?.Sum( x => x.GetOrderItemPrice() ) ?? 0;

        public decimal GetCartTotalDiscount()
            => orderItems?.Sum( x => x.GetOrderItemDiscount() * x.Quantity ) ?? 0;
    }
}
