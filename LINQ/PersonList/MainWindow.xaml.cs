using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PersonList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public String firstname { get; set; } = "";
        public String lastname { get; set; } = "";
        public String age { get; set; }

        public ObservableCollection<Person> PersonList { get; set; } = new ObservableCollection<Person>();
        public ObservableCollection<Person> ProcessedPersonList { get; set; } = new ObservableCollection<Person>();

        public String Input { get; set; }
        public String InputAge { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            AddNameToList.Click += AddNameToListMethod;

            SortListFirstName.Click += SortListFirstNameMethod;
            SortListLastName.Click += SortListLastNameMethod;
            SortListFisteLastName.Click += SortListFisteLastNameMethod;

            AllPersonsWithA.Click += AllPersonsWithAMethod;
            AllPersonsWithInput.Click += AllPersonsWithInputMethod;


            PersonsOlderThan20.Click += PersonsOlderThan20Method;
            AllPersonsOlderThanInputAge.Click += AllPersonsOlderThanInputAgeMethod;

            TotalAge.Click += TotalAgeMethod;
            AverageAge.Click += AverageAgeMethod;

            DataContext = this;
        }

        public void AddNameToListMethod(object sender, EventArgs args){
            try{
                PersonList.Add(new Person(){FirstName = firstname, LastName = lastname, Age = Int32.Parse(age)});
            }
            catch(FormatException e){
                MessageBox.Show("Age not a number");
            }
            catch(OverflowException e){
                MessageBox.Show("Age to big");
            }
        }

        public void SortListFirstNameMethod(object sender, EventArgs args){
            UpdateProcessedList(PersonList.OrderBy(p => p.FirstName).ToList());
        }
        public void SortListLastNameMethod(object sender, EventArgs args){
            UpdateProcessedList(PersonList.OrderBy(p => p.LastName).ToList());
        }
        public void SortListFisteLastNameMethod(object sender, EventArgs args){
            UpdateProcessedList(PersonList.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList());
        }
        public void AllPersonsWithAMethod(object sender, EventArgs args){
            UpdateProcessedList(PersonList.Where(p => p.FirstName.Contains("a") || p.LastName.Contains("a")).OrderBy(p => p.FirstName).ToList());
        }
        public void AllPersonsWithInputMethod(object sender, EventArgs args){
            UpdateProcessedList(PersonList.Where(p => p.FirstName.Contains(Input) || p.LastName.Contains(Input)).ToList());
        }
        public void PersonsOlderThan20Method(object sender, EventArgs args){
            UpdateProcessedList(PersonList.Where(p => p.Age > 20).ToList());
        }
        public void AllPersonsOlderThanInputAgeMethod(object sender, EventArgs args){
            try{  
                UpdateProcessedList(PersonList.Where(p => p.Age > Int32.Parse(InputAge)).ToList());
            }
            catch(FormatException e){
                MessageBox.Show("Input Age not a number");
            }
            catch(OverflowException e){
                MessageBox.Show("Input Age to big");
            }
        }
        public void TotalAgeMethod(object sender, EventArgs args){
            int totalage = PersonList.Where(p => p.Age > 20).Sum(p => p.Age);
            MessageBox.Show($"The total age is {totalage}");
        }
        public void AverageAgeMethod(object sender, EventArgs args){
            double averageage = PersonList.Where(p => p.Age > 20).Average(p => p.Age);
            MessageBox.Show($"The avarage age is {averageage}");
        }

        void UpdateProcessedList(List<Person> pl){
            ProcessedPersonList.Clear();
            foreach(Person p in pl){
                ProcessedPersonList.Add(p);
            }
        }


    }
}
