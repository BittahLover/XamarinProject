using System;
using Laba.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        async protected override void OnAppearing()
        {
            base.OnAppearing();
            MySettings.ChangeTheme();
            if(MySettings.CurrentLanguage)
            {
                searchbar.Placeholder = Rus.t_input;
                labelfavorite.Text = Rus.t_favorites;
                picker.Title = Rus.t_picker_title;
            }
            else
            {
                searchbar.Placeholder = Eng.t_input;
                labelfavorite.Text = Eng.t_favorites;
                picker.Title = Eng.t_picker_title;
            }
            itemsList1.Opacity = 0;
            itemsList1.ItemsSource = App.Database.GetSortItems1();
            await itemsList1.FadeTo(1, 2000, Easing.CubicOut);
        }

        private void searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            MySettings.my_input = searchbar.Text;
            UpdateList();
        }

        async private void UpdateList()
        {
            await itemsList1.FadeTo(0, 1000, Easing.BounceIn);
            itemsList1.Opacity = 0;
            itemsList1.ItemsSource = App.Database.GetSortItems1();
            await itemsList1.FadeTo(1, 2000, Easing.SpringOut);
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = picker.SelectedIndex;
            switch (i)
            {
                case 0: MySettings.my_contry = 7; break;
                case 1: MySettings.my_contry = 1; break;
                case 2: MySettings.my_contry = 2; break;
                case 3: MySettings.my_contry = 3; break;
                case 4: MySettings.my_contry = 4; break;
                case 5: MySettings.my_contry = 5; break;
                case 6: MySettings.my_contry = 6; break;

            }
            UpdateList();
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

        private void switch1_Toggled(object sender, ToggledEventArgs e)
        {
            MySettings.my_favorite = !MySettings.my_favorite;
            UpdateList();
        }
    }
}