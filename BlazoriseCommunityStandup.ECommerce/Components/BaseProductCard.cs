using Blazorise;
using BlazoriseCommunityStandup.ECommerce.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazoriseCommunityStandup.ECommerce.Components
{
    public abstract class BaseProductCard : ComponentBase
    {
        protected Task AddToCart()
        {
            return NotificationService.Success( $"Added {Product.Name} to your cart!" );
        }

        protected Task AddToWishList()
        {
            return NotificationService.Info( $"Added {Product.Name} to Wish List!" );
        }

        protected int FinalPrice => Product.GetFinalPrice();

        [Inject] private INotificationService NotificationService { get; set; }

        [Parameter] public Product Product { get; set; }
    }
}
