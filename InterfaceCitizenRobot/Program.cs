using System;
using System.Collections.Generic;

namespace CitizenRobot
{

    interface ICityMember{
        public int Id { get; set; }
        public String Type{get;set;}
    }

    class Citizen : ICityMember{
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public String Type { get; set; } = "Citizen";
    }

    class Robot : ICityMember{
        public int Id { get; set; }
        public String Model { get; set; }
        public String Type { get; set; } = "Robot";
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<int> allowedId = new List<int>() {1,2,3,4,5,6,7,8};
            List<ICityMember> cityMembers = new List<ICityMember>();

            String line;

            do{
                Console.WriteLine("Enter Citizen(Id,Name,Age) or Robot(Id,Model). Enter 'end' to end");
                line = Console.ReadLine();

                String[] parts = line.Split(',');

                switch(parts.Length){
                    case 3:
                        try{
                            cityMembers.Add(new Citizen(){Id=Int32.Parse(parts[0]),Name=parts[1], Age=Int32.Parse(parts[2])});
                            Console.WriteLine("Citizen added");
                        }
                        catch{
                            Console.WriteLine("Citizen in wrong format");
                        }
                        break;
                    case 2:
                        try{
                            cityMembers.Add(new Robot(){Id=Int32.Parse(parts[0]),Model=parts[1]});
                            Console.WriteLine("Robot added");
                        }
                        catch{
                            Console.WriteLine("Robot in wrong format");
                        }
                        break;
                    default:
                        if(!line.Equals("end")){
                            Console.WriteLine("Line in wrong format");
                        }
                        break;
                }


            }while(!line.Equals("end"));


            checkCityMembers(cityMembers,allowedId);


            void checkCityMembers(List<ICityMember> cm, List<int> ai){
                foreach(ICityMember citymember in cm){
                    if(!ai.Contains(citymember.Id)){
                        Console.WriteLine($"{citymember.Type} with id {citymember.Id} not allowed");
                    }
                }
            }
        }
    }
}
