using System.Collections.Generic;
using System;
using System.Linq;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>();
            Cars.Add(new Car("УАЗ", 75, "Иван", "Иванов"));
            Cars.Add(new Car("УАЗ", 75, "Иван", "Васильев"));
            Cars.Add(new Car("Ока", 30, "Дарья", "Кац"));
            Person person = new Person("Дмитрий", "Донской");
            Cars.Add(new Car("Камаз", 220, person));
            Cars.Add(new Car("Белаз", 2300, person));

            Console.WriteLine("Вывод владельцев УАЗов:");
            var filter1 = from car in Cars  //Фильтр выводящий всех владельцев УАЗа
                          where car.Name == "УАЗ"
                          select car;
            foreach(Car car in filter1)
            {
                Console.WriteLine(car.Owner.Firstname + " "+ car.Owner.Lastname);
            }

            Console.WriteLine("\nВывод всех марок авто в списке:");
            var filter2 = from car in Cars
                          let formatedname = "Марка" +" "+ car.Name
                          select new Car()
                          {
                              Name = formatedname,
                              Power = car.Power,
                              Owner = car.Owner
                          };
            foreach(Car car in filter2 )
            {
                Console.WriteLine(car.Name);
            }
        }
        
    }
}
