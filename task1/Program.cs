using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Проверка работы проекта с наследованием.");
            Console.Write("\nВведите адрес здания: ");
            string adress = Convert.ToString(Console.ReadLine());
            Console.Write("Введите длину здания: ");
            double lenghtHouse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину здания: ");
            double widthHouse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту здания: ");
            double heightHouse = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите адрес второго здания: ");
            string adress2 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите длину второго здания: ");
            double lenghtHouse2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину второго здания: ");
            double widthHouse2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту второго здания: ");
            double heightHouse2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите этажность второго здания: ");
            double numberOfStoreys = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Building building = new Building(adress, lenghtHouse, widthHouse, heightHouse);
            MultiBuilding multiBuilding = new MultiBuilding(adress2, lenghtHouse2, widthHouse2, heightHouse2, numberOfStoreys);

            Console.Write(building.GetPrint());
            Console.Write($"\nВторое здание:\n{multiBuilding.GetPrint()}");
            Console.ReadKey();
        }
    }
}
