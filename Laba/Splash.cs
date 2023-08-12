using System;
using Laba.Models;
using Laba.Views;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Emit;
using Xamarin.Forms;

namespace Laba
{
    public class Splash : ContentPage
    {
        Image splashImage;

        public Splash()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "launcher_foreground.png",
                WidthRequest = 110,
                HeightRequest = 110
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#CD5C5C");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 900);
            await splashImage.RotateTo(360, 950);
            await splashImage.ScaleTo(0.5, 1000, Easing.Linear);
            await splashImage.ScaleTo(85, 900, Easing.CubicIn);
            //await Navigation.PushModalAsync(new MainPage());
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
