using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TodoList.Model;
using Xamarin.Forms;

namespace TodoList.ViewModel
{
    internal class MainViewmodel : INotifyPropertyChanged
    {
        String _text;
        public String Text
        {
            get { return _text; }
            set { _text = value;
                PropertyChangedMethod();
            }
        }

        public Command AddCommand { get; set; }
        public Command EditCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public Command RefreshCommand { get; set; }
        public Todo SelectedTodo { get; set; }

        public ObservableCollection<Todo> TodoList { get; set; } = new ObservableCollection<Todo>();

        public MainViewmodel()
        {
            Text = "Hello from this";

            AddCommand = new Command(AddMethod);
            EditCommand = new Command(EditMethod);
            DeleteCommand = new Command(DeleteMethod);
            RefreshCommand = new Command(RefreshMethod);
            FillTodo();

        }

        public void AddMethod()
        {
                App.Current.MainPage.Navigation.PushAsync(new EnterTodoView());
        }

        public void EditMethod()
        {
            if (SelectedTodo != null)
                App.Current.MainPage.Navigation.PushAsync(new EnterTodoView(SelectedTodo));
        }
        public async void DeleteMethod()
        {
            if (SelectedTodo != null)
            {
                bool answer = await App.Current.MainPage.DisplayAlert("Delete", $"Delete {SelectedTodo.Text}?", "Yes", "No");
                if (answer)
                {
                    App.GlobalTodoList.Remove(SelectedTodo);
                    RefreshMethod();
                }
            }
                
        }

        public void FillTodo()
        {
            TodoList.Clear();
            foreach(Todo t in App.GlobalTodoList)
            {
                TodoList.Add(t);
            }
        }

        public void RefreshMethod()
        {
            FillTodo();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedMethod([CallerMemberName] String propname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }

    }
}
