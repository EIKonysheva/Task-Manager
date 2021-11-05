using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Proect p = new Proect();
            p.CheckStatus();
            p.CreateTask();
            p.CheckStatus();
            Tasks task = new Tasks();
            task.AssignTask(2);
            task.assigned[2] = true;
            task.AssignTask(3);
        }
    }
}
