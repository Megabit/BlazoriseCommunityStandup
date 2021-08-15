using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    public class Order
    {
        private static int OrderIdIncrementer;
        public Order( int customerId )
        {
            CustomerId = customerId;
            OrderState = OrderState.Created;
            DateCreated = DateTime.Now;
            OrderId = OrderIdIncrementer++;
        }


        public Order( int customerId, IEnumerable<Product> products ) : this( customerId )
        {
            this.products = products.ToList();
        }

        private List<Product> products;
        public IEnumerable<Product> Products => products.AsEnumerable();

        public int OrderId { get; private set; }
        public int CustomerId { get; }
        public OrderState OrderState { get; private set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }

        public void AddProduct( Product product )
        {
            products ??= new();
            products.Add( product );
        }

        public void SetOrderState( OrderState orderState )
        {
            //if ( (int)orderState < (int)OrderState )
                //throw new Exception( "Cannot move the order to a previous state." );
            OrderState = orderState;
        }

        public void NextOrderState()
        {
            if ( OrderState != OrderState.Completed )
                OrderState = (OrderState)( (int)OrderState + 1 );

            if (OrderState == OrderState.Cancelled)
                OrderState = (OrderState)( (int)OrderState + 1 );
        }

        public decimal GetOrderTotalPrice
            => products.Sum( x => x.GetFinalPrice() );

    }
}
