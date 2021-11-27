using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.ViewModel;
using Xamarin.Forms;

namespace TodoList
{
    public partial class MainPage : ContentPage
    {

        MainViewmodel vm;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = vm = new MainViewmodel();
        }

        protected override void OnAppearing()
        {
            vm.FillTodo();
        }


    }
}
