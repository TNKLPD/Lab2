using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Electrician:Worker
    {
        private int _readSpeed;
        public int ReadSpeed1
        {
            get => _readSpeed;
            set => _readSpeed = value >= 0 && value <= 163333 ? value : throw new ArgumentOutOfRangeException();
        }
        public Electrician(string name, int age, string tool, int workeramount, int readspeed, string job) : base(name, age, tool, workeramount, job)
        {
            ReadSpeed1 = readspeed;
        }
    }
}
