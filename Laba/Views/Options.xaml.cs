using System;
using Laba.Themes;
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
    public partial class Options : ContentPage
    {
        public Options()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MySettings.ChangeTheme();
            SwapLanguage();
            /*list.Opacity = 0;
            await list.FadeTo(1, 2000, Easing.CubicOut);*/
        }

        private void SwapLanguage()
        {
            if (MySettings.CurrentLanguage)
            {
                table_title1.Title = Rus.t_tab_title1;
                table_title2.Title = Rus.t_tab_title2;
                table_switch1.Text = Rus.t_tab_switch1;
                table_switch2.Text = Rus.t_tab_switch2;
                table_switch3.Text = Rus.t_tab_switch3;
                this.Title = Rus.t_options_title;
            }
            else
            {
                table_title1.Title = Eng.t_tab_title1;
                table_title2.Title = Eng.t_tab_title2;
                table_switch1.Text = Eng.t_tab_switch1;
                table_switch2.Text = Eng.t_tab_switch2;
                table_switch3.Text = Eng.t_tab_switch3;
                this.Title = Eng.t_options_title;
            }
        }

        async private void table_switch1_Clicked(object sender, EventArgs e)
        {
            MySettings.CurrentLanguage = !MySettings.CurrentLanguage;
            SwapLanguage();
            await WorkWithFile.SaveData(WorkWithFile.PrepareToSave());
        }

        async private void table_switch2_Clicked(object sender, EventArgs e)
        {
            MySettings.CurrentTheme = !MySettings.CurrentTheme;
            MySettings.ChangeTheme();
            await WorkWithFile.SaveData(WorkWithFile.PrepareToSave());
        }

        async private void table_switch3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutApp());
            await WorkWithFile.SaveData(WorkWithFile.PrepareToSave());
        }
    }
}