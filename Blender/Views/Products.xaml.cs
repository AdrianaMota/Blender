using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;

namespace Blender.Views
{
    public partial class Products : ContentPage
    {
        public Products()
        {
            InitializeComponent();

            background.Source = ImageSource.FromResource("Blender.Images.Background1.png");
        }

        async Task CallApi()
        {
            var nsAPI = RestService.For<IMakeupApi>("http://makeup-api.herokuapp.com");
            var makeup = await nsAPI.GetMakeups();
        }
    }
}
