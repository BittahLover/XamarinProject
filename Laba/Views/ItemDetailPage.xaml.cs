using System;
using Laba.Models;
using Laba.SQLite;
using Laba.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using Xamarin.Essentials;

namespace Laba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    { 
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(MySettings.CurrentLanguage)
            {
                desyear.Text = Rus.t_detail_year;
                descountry.Text = Rus.t_detail_country;
                desmotto.Text = Rus.t_detail_motto;
                desproduser.Text = Rus.t_detail_producer;
                desgenre.Text = Rus.t_detail_genre;
                desmainroles.Text = Rus.t_detail_mainroles;
                desdescription.Text = Rus.t_detail_description;
                b1.Text = Rus.t_view_fav;
                b2.Text = Rus.t_view_delete;
                b3.Text = Rus.t_view_back;
            }
            else
            {
                desyear.Text = Eng.t_detail_year;
                descountry.Text = Eng.t_detail_country;
                desmotto.Text = Eng.t_detail_motto;
                desproduser.Text = Eng.t_detail_producer;
                desgenre.Text = Eng.t_detail_genre;
                desmainroles.Text = Eng.t_detail_mainroles;
                desdescription.Text = Eng.t_detail_description;
                b1.Text = Eng.t_view_fav;
                b2.Text = Eng.t_view_delete;
                b3.Text = Eng.t_view_back;
            }
            var item = (MyItem)BindingContext;
            switch(item.Country)
            {
                case 1: bindkin.Text = "Usa"; break;
                case 2: bindkin.Text = "France"; break;
                case 3: bindkin.Text = "Germany"; break;
                case 4: bindkin.Text = "Britain"; break;
                case 5: bindkin.Text = "Italy"; break;
                case 6: bindkin.Text = "Ussr"; break;
            }
            if (MySettings.CurrentTheme)
            {
                BackgroundColor = Color.FromHex("#CD5C5C");
                b1.BackgroundColor = Color.FromHex("#CD5C5C");
                b2.BackgroundColor = Color.FromHex("#CD5C5C");
                b3.BackgroundColor = Color.FromHex("#CD5C5C");
            }
            else
            {
                BackgroundColor = Color.FromHex("#4682B4");
                b1.BackgroundColor = Color.FromHex("#4682B4");
                b2.BackgroundColor = Color.FromHex("#4682B4");
                b3.BackgroundColor = Color.FromHex("#4682B4");
            }
            if (item.IsFavorite)
            {
                b1.TextColor = Color.SkyBlue;
            }
            else b1.TextColor = Color.Black;
        }

        private void b2_Clicked(object sender, EventArgs e)
        {
            var item = (MyItem)BindingContext;
            App.Database.DeleteItem(item.id);
            this.Navigation.PopAsync();
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            var item = (MyItem)BindingContext;
            if (item.IsFavorite)
            {
                item.IsFavorite = false;
                b1.TextColor = Color.Black;
            }
            else
            {
                item.IsFavorite = true;
                b1.TextColor = Color.SkyBlue;
            }
            App.Database.SaveItem(item);
        }

        private void b3_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}