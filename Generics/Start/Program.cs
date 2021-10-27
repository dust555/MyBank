using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

namespace GenericsStart
{


    class person{
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public person(int id, String n, int a){
            Id = id;
            Name = n;
            Age = a;
        }

        public person(){}

        public static Boolean Save(String FileName, List<person> personlist){

            using(StreamWriter outputFile = new StreamWriter(FileName)){
                foreach(person i in personlist){   
                    String jsonString = JsonSerializer.Serialize(i);
                    Console.WriteLine(jsonString);
                    outputFile.WriteLine(jsonString);
                }
            }

            
            return true;
        }

        public static List<person> Read(String FileName){

            String line;  
            List<person> ReadList = new List<person>();
            System.IO.StreamReader file = new System.IO.StreamReader(FileName);  
            while((line = file.ReadLine()) != null)  
            {  
                try{
                    person p = JsonSerializer.Deserialize<person>(line.Replace("\n", "").Replace("\r", ""));
                    ReadList.Add(p);
                }
                catch(Exception e){
                    Console.WriteLine(e);
                }
                Console.WriteLine(line);
            }  
  
            file.Close();  

            return ReadList;
        }

    }


  

    class Program
    {
        static void Main(string[] args)
        {
      
            List<person> personlist = new List<person>();

            personlist.Add(new person(1,"Joris",10));
            personlist.Add(new person(2,"Jan",20));

            person.Save("persons.txt",personlist);


            List<person> personListFromText = person.Read("persons.txt");


            foreach(person p in personListFromText){
                Console.WriteLine(p.Name);

            }

        }
    }
}
