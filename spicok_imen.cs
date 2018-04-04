using System;
using System.Collections.Generic;

namespace cписок_имен
{
    static class Ran  
{   
    public static void MakeMixList<t>(IList<t> list)  
    {  
        Random r = new Random();  
  
        SortedList<int, t> mixedList = new SortedList<int, t>();  
        foreach (t item in list)  
            mixedList.Add(r.Next(), item);  
          
        list.Clear();  
        for (int i = 0; i < mixedList.Count; i++)  
        {  
            list.Add(mixedList.Values[i]);  
        }

        
    }  
}  
    class Program
    {
       
        static void Main(string[] args)
        {
            //заполнение списка
         //List [1] = "Anton";
           // List[2] = "Evgen";
            //List [3] = "Pavel";
            List<string> myList = new List<string>();
            //for(int i = 0; i < 100; i++) 
            myList.Add("Anton");
            myList.Add("Vakhid");
            myList.Add("Nikolay");
            myList.Add("Pavel");
            foreach (string key in myList)
                Console.WriteLine(key);
            //myList.Add(i.ToString()); 
  
        //перемешивание списка  
        Ran.MakeMixList(myList);
            foreach (string key in myList)
                Console.WriteLine(key);
            //Console.WriteLine(myList);
        Console.ReadKey(); 
        }
    }
}
