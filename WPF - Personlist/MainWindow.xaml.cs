﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ViewModel vm;
        public MainWindow()
        {

            InitializeComponent();
            vm = new ViewModel();

            AddNameToList.Click += vm.AddPersonToList;
            DeleteFromList.Click += vm.RemovePersonFromList;

            SortListFirstName.Click += vm.SortListFirstName;
            SortListLastName.Click += vm.SortListLastName;

            UploadList.Click += vm.UploadList;

            CountToMaxInt.Click += vm.CountToMaxInt;


            DataContext = vm;
        }
    }
}
