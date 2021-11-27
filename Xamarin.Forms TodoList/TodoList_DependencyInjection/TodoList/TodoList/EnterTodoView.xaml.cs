using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Model;
using TodoList.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterTodoView : ContentPage
    {
        EnterTodoViewmodel vm;

        public EnterTodoView()
        {
            InitializeComponent();

            BindingContext = vm = new EnterTodoViewmodel();
        }

        public EnterTodoView(Todo todo)
        {
            InitializeComponent();

            BindingContext = vm = new EnterTodoViewmodel(todo);
        }
    }
}