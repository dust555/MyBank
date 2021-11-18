using System;
using System.Collections.Generic;
using TodoList.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList
{
    public partial class App : Application
    {

        public static List<Todo> GlobalTodoList = new List<Todo>();

        public App()
        {

            GlobalTodoList.Add(new Todo() { Text = "Todo1", Urgency = 1 });
            GlobalTodoList.Add(new Todo() { Text = "Todo2", Urgency = 2 });

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
