using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Laba.Models;
using Laba.Views;
using Laba.SQLite;
using System.IO;

namespace Laba
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "items.db";
        public static ItemRepository database;

        public static ItemRepository Database
        {
            get
            {
                if(database == null)
                {
                    database = new ItemRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        async protected override void OnStart()
        {
            if(!WorkWithFile.IsExist())
            {
                StartData.FillWithData();
                await WorkWithFile.SaveData("11");
            }

            WorkWithFile.ChangeSettings(WorkWithFile.ReadData());

            MySettings.CurrentImage = 1;
            MySettings.CurrentSortType = 2;
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
