using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class MainPage : TabbedPage
    { 
        public MainPage()
        {
            InitializeComponent();

            this.CurrentPageChanged += CurrentPageHasChanged;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (MySettings.CurrentLanguage)
            {
                p_main.Title = Rus.t_films_title;
            }
            else p_main.Title = Eng.t_films_title;
        }

        void CurrentPageHasChanged(object sender, EventArgs e)
        {
            if (MySettings.CurrentLanguage)
            {
                if (CurrentPage == Children[0])
                {
                    p_main.Title = Rus.t_films_title;
                    p_search.Title = "";
                    p_settings.Title = "";
                }
                else if (CurrentPage == Children[1])
                {
                    p_main.Title = "";
                    p_search.Title = Rus.t_search_title;
                    p_settings.Title = "";
                }
                else if (CurrentPage == Children[2])
                {
                    p_main.Title = "";
                    p_search.Title = "";
                    p_settings.Title = Rus.t_options_title;
                }
            }
            else
            {
                if (CurrentPage == Children[0])
                {
                    p_main.Title = Eng.t_films_title;
                    p_search.Title = "";
                    p_settings.Title = "";
                }
                else if (CurrentPage == Children[1])
                {
                    p_main.Title = "";
                    p_search.Title = Eng.t_search_title;
                    p_settings.Title = "";
                }
                else if (CurrentPage == Children[2])
                {
                    p_main.Title = "";
                    p_search.Title = "";
                    p_settings.Title = Eng.t_options_title;
                }
            }
        }
    }
}
