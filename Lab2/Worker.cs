using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Worker
    {
        private PersonInfo _personInfo;
        private int _workerAmount;
        private string _job;
        public static readonly int CAPACITY_OF_FACTORY = 99;
        public string Job
        {
            get => _job;
            set => _job = value.Trim();
        }
        public int WorkerAmount 
        {  
            get => _workerAmount;
            set => _workerAmount = value >= 0 && value < CAPACITY_OF_FACTORY ? value : throw new NullReferenceException(); 
        }
        public Worker(string name, int age, string tool, int workeramount, string job)
        {
            _personInfo = new PersonInfo(name, age, tool);
            WorkerAmount = workeramount;
            Job = job;
        }
    }
}
