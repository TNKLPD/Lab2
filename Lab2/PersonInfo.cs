using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PersonInfo
    {
        private string _name;
        private int _age;
        private string _tool;
        
        public string Name 
        { 
            get => _name;
            set => _name = value.Trim(); 
        }
        public int Age 
        {  
            get => _age; 
            set => _age = value >= 0 ? value : throw new ArgumentOutOfRangeException(); 
        }
        public string Tool 
        {  
            get => _tool; 
            set => _tool = value.Trim(); 
        }

        public PersonInfo(string name, int age, string tool) 
        {
            Name = name;
            Age = age;
            Tool = tool;


        }
    }
}
