using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Locksmith:Worker
    {
        private int _readSpeed;
        public int ReadSpeed 
        { 
            get=>_readSpeed;
            set => _readSpeed = value >= 0 && value <= 163333 ? value : throw new ArgumentOutOfRangeException();
        }
        public Locksmith(string name, int age, string tool, int workeramount, int readspeed, string job) : base(name, age, tool, workeramount, job)
        {
            ReadSpeed = readspeed;
        }
    }
}
