using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace wpf{


    class ViewModel{
        public ObservableCollection<Person> PersonList {get;set;} = new ObservableCollection<Person>();

        public Person SelectedPerson { get; set; }

        public String FirstName { get; set; } = "";
        public String LastName { get; set; } = "";

        public void AddPersonToList(object sender, RoutedEventArgs args){
            Person p = new Person(){FirstName = FirstName, LastName=LastName};
            PersonList.Add(p);
            MessageBox.Show(p.FirstName + " " + p.LastName + " added to list");
        }

        public void RemovePersonFromList(object sender, RoutedEventArgs args){
            if(SelectedPerson != null){
                PersonList.Remove(SelectedPerson);
                SelectedPerson = null;
            }
        }

        public void SortListFirstName(object sender, RoutedEventArgs args){
            UpdateList(PersonList.OrderBy(p=>p.FirstName).ToList());
        }

        public void SortListLastName(object sender, RoutedEventArgs args){
            UpdateList(PersonList.OrderBy(p=>p.LastName).ToList());
        }

        public void UpdateList(List<Person> pl){
            PersonList.Clear();

            foreach(Person p in pl){
                PersonList.Add(p);
            }
        }


        public async void UploadList(object sender, RoutedEventArgs args){

            HttpClient client = new HttpClient();

            var response = await client.GetAsync($"http://www.seamine.be/xamarin.php?list={JsonSerializer.Serialize(PersonList)}");
            string result = await response.Content.ReadAsStringAsync();
            if(result.Equals("1")){
                MessageBox.Show("Upload successful");
            }
            else{
                MessageBox.Show("Something went wrong with the upload");
            }

        }
        

        public async void CountToMaxInt(object sender, RoutedEventArgs args){
            await Task.Run(() => {
                for(int i=0; i<Int32.MaxValue; i++){}
                MessageBox.Show($"Counted to {Int32.MaxValue}");
                });
        }

    }

}