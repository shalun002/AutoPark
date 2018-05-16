using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1.	Машина (Модель, Год выпуска, Наименование, Тип, Гаражный номер) */

namespace AutoPark.Lib.Modul
{
    public enum CarType { Kamaz, Ecskovator, Grader, Traktor }

    public class Car
    {
        public string CarModel { get; set; }
        public DateTime GodVipuska { get; set; }
        public CarType CarType { get; set; }
        public int GosNomer { get; set; }

        public List<Component> components = new List<Component>();

        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-> {0}\t {1} g.v.", CarModel, GodVipuska.Year);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Component item in components)
            {
                Console.WriteLine("--> {0}", item.ComponentName);
            }
        }
    }
}