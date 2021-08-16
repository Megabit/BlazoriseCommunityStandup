using Blazorise;
using BlazoriseCommunityStandup.ECommerce.Models;
using BlazoriseCommunityStandup.ECommerce.States;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseCommunityStandup.ECommerce.Pages
{
    public partial class ProductPage
    {
        protected override void OnInitialized()
        {
            Product = AppState.Products.FirstOrDefault( x => x.Id == ProductId );

            base.OnInitialized();
        }

        protected Task BuyNow()
        {
            AppState.CustomerCart.AddProduct( Product );
            NavigationManager.NavigateTo( "e-commerce/checkout" );

            return Task.CompletedTask;
        }

        protected async Task AddToCart()
        {
            AppState.CustomerCart.AddProduct( Product );
            await NotificationService.Success( $"Added {Product.Name} to your cart!" );
        }

        protected Task AddToWishList()
        {
            return NotificationService.Info( $"Added {Product.Name} to Wish List!" );
        }

        [Inject] private INotificationService NotificationService { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        private int FinalPrice => Product?.GetFinalPrice() ?? 0;

        private Product Product { get; set; }

        [CascadingParameter] private AppState AppState { get; set; }

        [Parameter] public int ProductId { get; set; }
    }
}
