using AutoPark.Lib.Generator;
using AutoPark.Lib.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();
            List<Project> projects = null;
            string message;

            if (!gen.GenerateProject(ref projects, out message))
            {
                Console.WriteLine(message);
                return;
            }

            foreach (Project item in projects)
            {
                item.PrintInfo();
            }
        }
    }
}