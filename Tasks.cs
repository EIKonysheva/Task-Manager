using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_Manager
{
    class Tasks
    {
        public Tasks() 
        {
        }
        StreamReader sr = new StreamReader("Employees.txt");
       static List<string> emp = new List<string>();
       public bool[] assigned = new bool[emp.Count];

        public void AssignTask(int empnum)
        {
            while (!sr.EndOfStream)
            {
                emp.Add(sr.ReadLine());
            }
            //bool[] assigned;
            assigned = new bool[emp.Count];
            assigned[empnum] = true;
            { for (int i = 0; i < assigned.Length; i++)
                {
                    if (!assigned[i])
                    {
                        Console.WriteLine($"Работник {i} не имеет задач");
                    } 
                    else if (assigned[empnum])
                    {
                        //assigned[empnum] = true;
                        Console.WriteLine($"Работник {empnum} получил задачу");
                    }
                    //else
                    //{                        
                    //    Console.WriteLine($"У работника {empnum} уже есть задачa, передадим следующему");
                    //    assigned[empnum++] = true;
                    //}
                }
            } 
        }
        public void WriteReport()
        {
            
        }
    }    
}


          
