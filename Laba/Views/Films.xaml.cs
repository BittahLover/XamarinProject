using Laba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Films : ContentPage
    {
        public Films()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MySettings.ChangeTheme();
            itemsList.Opacity = 0;
            itemsList.ItemsSource = App.Database.GetSortItems();
            await itemsList.FadeTo(1, 2000, Easing.CubicOut);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MyItem selectedItem = (MyItem)e.SelectedItem;
            ItemDetailPage itemPage = new ItemDetailPage();
            itemPage.BindingContext = selectedItem;
            if (MySettings.CurrentTheme)
            {
                itemPage.BackgroundColor = Color.FromHex("#D32F2F");
            }
            else itemPage.BackgroundColor = Color.FromHex("#6D4C41");
            await Navigation.PushAsync(itemPage);
        }

    }


}