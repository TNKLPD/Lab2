using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker locksmith1 = new Worker(name:"Vitaliy", age:19, tool:"grindingmachine", workeramount:11,
                job:"locksmith");
            Worker electrician1 = new Worker(name:"Serhiy", age:29, tool:"electriciankit", workeramount:7,
                job:"electrician");
            Worker electrician2 = new Worker(name: "Artem", age: 19, tool: "electriciankit", workeramount: 6,
                job: "electrician");
            Worker highrisemounter1 = new Worker(name: "Taras", age: 21, tool: "climberkit", workeramount: 5,
                job: "highrisemounter");

            Worker worker = new Worker("Taras", 25, "climberkit", 5, "highrisemounter");

            Crew crew = new Crew();
            crew.AddMember(locksmith1);
            crew.AddMember(electrician1);
            crew.AddMember(electrician2);
            crew.AddMember(highrisemounter1);

            Crew crew1 = new Crew(locksmith1,electrician1,electrician2,highrisemounter1);

            foreach (var item in crew.Members)
            {
                Console.WriteLine(item.WorkerAmount);
            }
            foreach (var item in crew1.Members)
            {
                Console.WriteLine(item.WorkerAmount);
            }
        Console.ReadLine();
        }
    }
}
