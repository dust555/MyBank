using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TodoList.ViewModel
{
    internal class BaseViewmodel:INotifyPropertyChanged
    {

        public String PageTitle { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedMethod([CallerMemberName] String propname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}
