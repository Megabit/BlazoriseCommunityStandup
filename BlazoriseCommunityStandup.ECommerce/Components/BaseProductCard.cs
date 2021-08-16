using Blazorise;
using BlazoriseCommunityStandup.ECommerce.Models;
using BlazoriseCommunityStandup.ECommerce.States;

using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazoriseCommunityStandup.ECommerce.Components
{
    public abstract class BaseProductCard : ComponentBase
    {
        protected async Task AddToCart()
        {
            AppState.CustomerCart.AddProduct( Product );
            await NotificationService.Success( $"Added {Product.Name} to your cart!" );
        }

        protected Task AddToWishList()
        {
            return NotificationService.Info( $"Added {Product.Name} to Wish List!" );
        }

        protected int FinalPrice => Product.GetFinalPrice();

        [Inject] private INotificationService NotificationService { get; set; }

        [Parameter] public Product Product { get; set; }
        [CascadingParameter] public AppState AppState { get; set; }
    }
}
