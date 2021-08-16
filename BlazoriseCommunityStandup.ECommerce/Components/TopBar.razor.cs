using BlazoriseCommunityStandup.ECommerce.States;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazoriseCommunityStandup.ECommerce.Components
{
    public partial class TopBar
    {

        protected override void OnInitialized()
        {
            AppState.CustomerCart.CartChanged += CartChanged;

            base.OnInitialized();
        }

        public void Dispose()
        {
            AppState.CustomerCart.CartChanged -= CartChanged;
        }

        private void CartChanged( object sender, EventArgs eventArgs )
        {
            InvokeAsync( StateHasChanged );
        }

        [Inject] private NavigationManager NavigationManager { get; set; }

        [CascadingParameter] public AppState AppState { get; set; }
    }
}
