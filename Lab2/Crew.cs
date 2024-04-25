using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Crew
    {
        private Worker[] _members;

        public Worker[] Members => _members;

        public Crew() 
        {
            _members = Array.Empty<Worker>();
        }
        public Crew(params Worker[] members)
        {
            _members = members;
        }
        public void AddMember(Worker worker)
        {
            Array.Resize(ref _members, _members.Length + 1);
            _members[_members.Length - 1] = worker;
        }
        public override string ToString()
        {
            return Members.ToString();
        }
    }
}
