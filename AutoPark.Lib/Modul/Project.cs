﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3.	Проект (Наименование) (пример. Варваринский ГОК, Карагандинская шахта, СС ГОК) */

namespace AutoPark.Lib.Modul
{
    public class Project
    {
        public string ProjectName { get; set; }
        public List<Car> cars = new List<Car>();

        public void PrintInfo()
        {
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("\t\t Project: {0}", ProjectName);
            Console.WriteLine("/////////////////////////////////////////////////");
            foreach (Car item in cars)
            {
                Console.WriteLine("================================================");
                item.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}