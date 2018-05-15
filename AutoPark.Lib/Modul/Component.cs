using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2.	Компонент (Наименование, код компонента) (пример. Двигатель, КП, Трансмиссия) */

namespace AutoPark.Lib.Modul
{
    public enum Parts { Engine = 1, KPP, Transmission }

    public class Component
    {
        public Parts ComponentName { get; set; }
        public int ComponentId { get; set; }
    }
}