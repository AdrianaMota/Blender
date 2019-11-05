using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Blender.Views
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            background.Source = ImageSource.FromResource("Blender.Images.BackgroundMP.png");
            blendy.Source = ImageSource.FromResource("Blender.Images.blendy.png");
            prod.Source = ImageSource.FromResource("Blender.Images.Products.png");
            brand.Source = ImageSource.FromResource("Blender.Images.Brands.png");
            tag.Source = ImageSource.FromResource("Blender.Images.Tags.png");
            wishlist.Source = ImageSource.FromResource("Blender.Images.WishList.png");
        }
         void ProductsClicked(object sender, EventArgs args)
        {
           Navigation.PushAsync(new Products());
        }
    }
}
