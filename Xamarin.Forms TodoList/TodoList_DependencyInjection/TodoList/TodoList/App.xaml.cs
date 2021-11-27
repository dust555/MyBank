using System;
using System.Collections.Generic;
using TodoList.Model;
using TodoList.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList
{
    public partial class App : Application
    {

        

        public App()
        {

           DependencyService.Register<MockDataStore>();


            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
