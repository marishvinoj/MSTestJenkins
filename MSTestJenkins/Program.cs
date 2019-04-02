using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestJenkins
{
    public class Test
    {
        public string m1(string name)
        {
            return "Welcome " + name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.m1("Marish");
        }
    }
}
