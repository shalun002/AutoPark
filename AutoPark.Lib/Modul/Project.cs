using System;
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
    }
}