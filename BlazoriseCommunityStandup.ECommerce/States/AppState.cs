using BlazoriseCommunityStandup.ECommerce.Models;
using System.Collections.Generic;

namespace BlazoriseCommunityStandup.ECommerce.States
{
    public class AppState
    {
        public bool ProductsAsList { get; set; }

        public List<Product> Products = new List<Product>
        {
            new Product("", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false),
            new Product("", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false),
            new Product("", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true),
            new Product("", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false),
            new Product("", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false),
            new Product("", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false),
            new Product("", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true),
            new Product("", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false),
            new Product("", "img/e-commerce/products/tshirt_red_480x400.webp", 200, 10, true, false),
            new Product("", "img/e-commerce/products/tshirt_grey_480x400.webp", 475, null, false, false),
            new Product("", "img/e-commerce/products/tshirt_black_480x400.webp", 350, 20, true, true),
            new Product("", "img/e-commerce/products/tshirt_green_480x400.webp", 10, null, false, false),
        };
    }
}
