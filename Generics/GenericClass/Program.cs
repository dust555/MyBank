using System;
using System.Collections.Generic;

namespace GenericClass
{

    interface IHasSize{
        int Size { get; set; }
    }

    class file:IHasSize{
        public int Size {get;set;}
        public String FileName {get;set;}

        new public String ToString(){
            return FileName + " - " + Size;
        }
    }

    class FILargestO <T> 
            where T: IHasSize{

        List<T> FILargestOList = new List<T>();

        public void Add(T t){
            FILargestOList.Add(t);
        }

        public T Pop(){
            T t;
            int Size = 0;
            int selectedindex = 0;
            int i = 0;
            Boolean first = true;
            foreach(T t1 in FILargestOList){
                if(first){
                    Size = t1.Size;
                    first = false;

                }
                else{
                    if(t1.Size > Size){
                        Size = t1.Size;
                        selectedindex = i;
                    }
                }
                i++;

            }

            t = FILargestOList[selectedindex];
            FILargestOList.RemoveAt(selectedindex);
            return t;
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FILargestO<file> filelist = new FILargestO<file>();

            filelist.Add(new file(){Size=100, FileName="FirstFile"});
            filelist.Add(new file(){Size=200, FileName="SecondFile"});
            filelist.Add(new file(){Size=50, FileName="ThirdFile"});


            Console.WriteLine(filelist.Pop().ToString());
            Console.WriteLine(filelist.Pop().ToString());
            Console.WriteLine(filelist.Pop().ToString());


        }
    }
}
