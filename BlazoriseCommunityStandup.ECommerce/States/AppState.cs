using BlazoriseCommunityStandup.ECommerce.Models;

using System.Collections.Generic;
using System.Linq;

namespace BlazoriseCommunityStandup.ECommerce.States
{
    public class AppState
    {
        public bool ProductsAsList { get; set; }

        public List<Product> Products = new List<Product>
        {
            new Product("Red T-Shirt", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false, "Nulla sodales sit amet orci eu vehicula. Curabitur metus velit, fermentum a velit ac, sodales egestas lacus. Etiam congue velit vel luctus dictum. Pellentesque at pellentesque sapien."),
            new Product("Grey T-Shirt", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false, "Maecenas suscipit volutpat gravida. Nulla hendrerit nisi a lectus blandit aliquam. Integer enim magna, consequat sed justo nec, auctor sagittis urna."),
            new Product("Black T-Shirt", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true, "Vivamus sapien eros, molestie sed lacus vitae, lacinia volutpat ipsum. Nam sollicitudin lorem eget ornare vulputate."),
            new Product("Green T-Shirt", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false, "Morbi lobortis velit non consectetur porta."),
            new Product("Red T-Shirt", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false, "Nulla sodales sit amet orci eu vehicula. Curabitur metus velit, fermentum a velit ac, sodales egestas lacus. Etiam congue velit vel luctus dictum. Pellentesque at pellentesque sapien."),
            new Product("Grey T-Shirt", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false, "Maecenas suscipit volutpat gravida. Nulla hendrerit nisi a lectus blandit aliquam. Integer enim magna, consequat sed justo nec, auctor sagittis urna."),
            new Product("Black T-Shirt", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true, "Vivamus sapien eros, molestie sed lacus vitae, lacinia volutpat ipsum. Nam sollicitudin lorem eget ornare vulputate."),
            new Product("Green T-Shirt", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false, "Morbi lobortis velit non consectetur porta."),
            new Product("Red T-Shirt", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false, "Nulla sodales sit amet orci eu vehicula. Curabitur metus velit, fermentum a velit ac, sodales egestas lacus. Etiam congue velit vel luctus dictum. Pellentesque at pellentesque sapien."),
            new Product("Grey T-Shirt", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false, "Maecenas suscipit volutpat gravida. Nulla hendrerit nisi a lectus blandit aliquam. Integer enim magna, consequat sed justo nec, auctor sagittis urna."),
            new Product("Black T-Shirt", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true, "Vivamus sapien eros, molestie sed lacus vitae, lacinia volutpat ipsum. Nam sollicitudin lorem eget ornare vulputate."),
            new Product("Green T-Shirt", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false, "Morbi lobortis velit non consectetur porta."),
        };

        public List<Order> Orders;

        public AppState()
        {
            Orders = new List<Order>()
            {
                new( 100, Products.Take( 3 ) ),
                new( 200, Products.Skip( 3 ).Take( 1 ) ),
                new( 300, Products.Skip( 6 ).Take( 2 ) )
            };
        }
    }
}
