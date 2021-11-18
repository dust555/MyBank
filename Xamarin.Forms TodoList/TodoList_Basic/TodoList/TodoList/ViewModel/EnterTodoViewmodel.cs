using System;
using System.Collections.Generic;
using System.Text;
using TodoList.Model;
using Xamarin.Forms;

namespace TodoList.ViewModel
{
    internal class EnterTodoViewmodel
    {

        public String Text { get; set; }
        public String Urgency { get; set; }
        Todo _todo;

        public Command SaveCommand { get; set; }

        public EnterTodoViewmodel()
        {
            SaveCommand = new Command(EnterTodoMethod);
        }

        public EnterTodoViewmodel(Todo todo)
        {
            _todo = todo;
            SaveCommand = new Command(EditTodoMethod);
            Text = todo.Text;
            Urgency = todo.Urgency.ToString();
        }

        public void EnterTodoMethod()
        {
            try
            {
                App.GlobalTodoList.Add(new Todo() { Text = Text, Urgency = Int32.Parse(Urgency) });
                App.Current.MainPage.Navigation.PopAsync();
            }
            catch
            {
                App.Current.MainPage.DisplayAlert("Error", "Invalid Urgency", "Ok");
            }

}

        public void EditTodoMethod()
        {
            _todo.Text = Text;
            try
            {
                _todo.Urgency = Int32.Parse(Urgency);
                App.Current.MainPage.Navigation.PopAsync();
            }
            catch
            {
                App.Current.MainPage.DisplayAlert("Error", "Invalid Urgency", "Ok");
            }

        }

    }
}
