using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Task_Manager
{
    class Proect
    {
        public Proect() 
        {
        }
        Proect(string description, DateTime deadlines,  string customer, string teamlead, string tasks, string status) 
        {
        }
        StreamReader sr = new StreamReader("TasksFile.txt");
        List<string> myList = new List<string>();
        public void CreateTask() 
        {
            
            while (!sr.EndOfStream)
            {
                myList.Add(sr.ReadLine());

            }
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
                
            }
        }
        public void CheckStatus()
        {
            if (myList.Count == 10)
            {
                Console.WriteLine("Cтатус проекта: Исполнение");
            }
            else 
            {
                Console.WriteLine("Статус проекта: Проект");
            }
        }
    }
}
