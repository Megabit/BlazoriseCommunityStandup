using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazoriseCommunityStandup.ECommerce.Models
{
    public enum OrderPaymentMethod
    {
        CreditCard,
        PayPal
    }

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
            this.orderItems = products.Select(x=> new ProductOrderItem(x)).ToList();
        }

        private List<ProductOrderItem> orderItems;
        public IEnumerable<ProductOrderItem> OrderItems => orderItems?.AsEnumerable();

        public int OrderId { get; private set; }
        public int CustomerId { get; }

        #region Simplified Order Information --> These should be separate entities

        //Customer Entity or Contact Entity
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }

        //Shipping Entity (BaseAddress Entity)
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }

        //Billing entity (BaseAddress Entity)
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCountry { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }

        //Payment Details Entity
        public OrderPaymentMethod PaymentMethod { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear{ get; set; }
        public int CVV { get; set; }

        #endregion

        public OrderState OrderState { get; private set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }

        public void AddProduct( Product product )
        {
            orderItems ??= new();
            orderItems.Add( new(product) );
        }

        public void SetBillingSameAsShipping()
        {
            BillingName = ShippingName;
            BillingAddress = ShippingAddress;
            BillingAddress2= ShippingAddress2;
            BillingCountry= ShippingCountry;
            BillingState= ShippingState;
            BillingZip= ShippingZip;
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
            => orderItems.Sum( x => x.GetOrderItemPrice() );

    }
}
