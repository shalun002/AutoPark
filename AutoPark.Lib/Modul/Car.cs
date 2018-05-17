using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1.	Машина (Модель, Год выпуска, Наименование, Тип, Гаражный номер) */

namespace AutoPark.Lib.Modul
{
    public enum CarType { Kamaz, Ecskovator, Grader, Traktor }
    public enum Status { Activ, Inactiv }

    public class Car
    {
        public string CarModel { get; set; }
        public DateTime GodVipuska { get; set; }
        public CarType CarType { get; set; }
        public int GosNomer { get; set; }
        public Status CarStatus { get; set; }


        public List<Component> components = new List<Component>();

        public void PrintInfo()
        {
            if (CarStatus == Status.Activ)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();
            Console.WriteLine("->Машина {0}, тип {1}, {2}г.в., гос.номер {3}", CarModel, CarType, GodVipuska.Year, GosNomer);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Component item in components)
            {
                Console.WriteLine("--> {0}", item.ComponentName);
            }
            
        }
    }
}