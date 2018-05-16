using AutoPark.Lib;
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

            Console.WriteLine("Выберите проект: ");
            foreach (var item in projects)
                Console.WriteLine(" - " + item.ProjectName);

            Project temp = null;
            do
            {
                Console.Write("-> ");
                string name = Console.ReadLine();

                temp = projects.FirstOrDefault(o => o.ProjectName == name);

                if (temp != null)
                    break;

                Console.WriteLine("Проект не найден!");
            }
            while (temp == null);

            Console.WriteLine("Выберите критерии поиска: 1 - гаражный номер, 2 - модель");

            int choise = 0;
            do
            {
                Console.Write("-> ");
                Int32.TryParse(Console.ReadLine(), out choise);

            } while (choise != 1 && choise != 2);

            int gosNomer = 0;
            string modelCar;

            Service service = new Service();
            Car findCar = null;

            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Введите гос. номер машины: ");
                        Int32.TryParse(Console.ReadLine(), out gosNomer);

                        service.Search(temp, gosNomer);

                    }
                    break;
                case 2:
                    {
                        Console.Write("Введите модель машины: ");
                        service.Search(temp, Console.ReadLine());
                    }
                    break;
            }
            if (findCar == null)
                Console.WriteLine("Машина не найдена");
            else
                findCar.PrintInfo();
        }
    }
}