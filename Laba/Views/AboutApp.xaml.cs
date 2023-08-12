using System;
using Laba.Models;
using Laba.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laba.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutApp : ContentPage
    {
        public AboutApp()
        {
            InitializeComponent();
        }

        protected void GoToSO(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://vk.com/mirarius"));
        }

        protected void GoToSOO(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://instagram.com/mirarius?igshid=2bn3rvqzllvr"));
        }

        protected void GoToSOOO(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://t.me/BittahLover"));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MySettings.ChangeTheme();
            SwapLanguage();
        }

        private void SwapLanguage()
        {
            if(MySettings.CurrentLanguage)
            {
                EProg.Text = Rus.t_EProg;
                ProgE.Text = Rus.t_ProgE;
                ArtAndDesign.Text = Rus.t_ArtAndDesign;
                ProjM.Text = Rus.t_ProjM;
            }
            else
            {   
                EProg.Text = Eng.t_EProg;
                ProgE.Text = Eng.t_ProgE;
                ArtAndDesign.Text = Eng.t_ArtAndDesign;
                ProjM.Text = Eng.t_ProjM;
            }
        }

    }
}