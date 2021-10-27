using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

namespace GenericsStart
{


    interface IHasName{
        String Name { get; set; }
    }

    class person:IHasName{
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public person(int id, String n, int a){
            Id = id;
            Name = n;
            Age = a;
        }

        public person(){}

         new public String ToString(){
            return Name;
        }

    }

    class animal:IHasName{
        public int Id { get; set; }
        public String AnimalKind { get; set; }
        public String Name { get; set; }

        public void MakeSound(){

        }

        new public String ToString(){
            return AnimalKind;
        }

        
    }

    static class GenericFunctions{

         public static Boolean Save<T1>(String FileName, List<T1> personlist){

            using(StreamWriter outputFile = new StreamWriter(FileName)){
                foreach(T1 i in personlist){   
                    String jsonString = JsonSerializer.Serialize(i);
                    Console.WriteLine(jsonString);
                    outputFile.WriteLine(jsonString);
                }
            }

            
            return true;
        }

        public static List<T2> Read<T2>(String FileName){
              
            List<T2> ReadList = new List<T2>();
            System.IO.StreamReader file;
            try{
                String line;
                file = new System.IO.StreamReader(FileName);  
                while((line = file.ReadLine()) != null)  
                {  

                    T2 p = JsonSerializer.Deserialize<T2>(line.Replace("\n", "").Replace("\r", ""));
                    ReadList.Add(p);

                    Console.WriteLine(line);

                }  
                file.Close(); 
     
            }
            catch(FileNotFoundException){
                Console.WriteLine("File Not Found");
            }
            catch(JsonException){
                Console.WriteLine("Problem with JSON");
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("FinalyBlock");
            }
            
            return ReadList;
        }

        public static void PrintList<T1>(List<T1> t)
            where T1:IHasName{
            foreach(T1 p in t){
                Console.WriteLine(p.Name);
            }
        }

    }


  

    class Program
    {
        static void Main(string[] args)
        {
      
            List<person> personlist = new List<person>();

            personlist.Add(new person(1,"Joris",10));
            personlist.Add(new person(2,"Jan",20));

            GenericFunctions.Save<person>("persons.txt",personlist);


            List<person> personListFromText = GenericFunctions.Read<person>("persons.txt");

            List<animal> animallist = new List<animal>();

            animallist.Add(new animal(){Id=1, AnimalKind="Cat", Name="Cat Lucy"});
            animallist.Add(new animal(){Id=2, AnimalKind="Dog", Name="Dog Boris"});
            animallist.Add(new animal(){Id=3, AnimalKind="Tiger", Name="Tiger Emir"});

            GenericFunctions.Save<animal>("animals.txt",animallist);

            List<animal> animalListFromText = GenericFunctions.Read<animal>("animals.txt");
            


            GenericFunctions.PrintList<animal>(animallist);
            GenericFunctions.PrintList<person>(personlist);


            

        }
    }
}
