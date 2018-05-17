using AutoPark.Lib.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Lib
{
    public class Service
    {
        public Car Search(Project project, int GosNomer)
        {
            foreach (Car item in project.cars)
            {
                if (item.GosNomer == GosNomer) return item;
                Console.WriteLine();
                Console.Clear();
            }
            return null;
        }

        public Car Search(Project project, string CarModel)
        {
            foreach (Car item in project.cars)
            {
                if (item.CarModel == CarModel) return item;
                Console.Clear();
            }
            return null;
        }

        //public void StatusCar(List<Project> projects, Car CarModel)
        //{
        //    for (int i = 0; i < projects.E   .cars.Count; i++)
        //    {

        //    }

        //    foreach (Car item in project.cars)
        //    {
        //        if (item.CarModel == CarModel.CarModel);
        //        item.CarStatus = 
        //        Console.Clear();
        //    }
        //}
    }
}