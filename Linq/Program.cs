using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(); //Основной список
            people.Add(new Person("Иван", "Иванов"));
            people.Add(new Person("Вася", "Васильев"));
            people.Add(new Person("Егор", "Егоров"));
            people.Add(new Person("Дима", "Димонов"));
            people.Add(new Person("Дима", "Кац"));

            Console.WriteLine("Вывод основного списка");
            foreach(Person p in people)
            {
                Console.WriteLine(p.Firstname + " " + p.Lastname);
            }

            Console.WriteLine("\nВывод первой сущности из списка сущностей с именем Егор:");

            var results = from p in people where p.Firstname == "Егор" select new { p.Firstname, p.Lastname }; //Первый запрос, который находит сущностей с Firstname = Егор
            Console.WriteLine(results.ToList()[0].Firstname +" "+ results.ToList()[0].Lastname); //Вывод первой из найденных сущностей


            Console.WriteLine("\nВывод сущностей с именем Дима используя фильтр применимый к основному списку");
            IEnumerable<Person> dimon = people.Where(m => m.Firstname == "Дима"); //Использование LINQ через методы создание "фильтра", который применяется к изначальному списку при каждом обращении.
            foreach (Person dimons in dimon){ 
                Console.WriteLine(dimons.Firstname + " " + dimons.Lastname);
            }

            
            List<Person> dimons2 = people.Where(m => m.Firstname == "Дима").ToList(); //Создание нового списка который запечатляет основной список в один момент времени - не изменяется при изменении основного списка

            Console.WriteLine("\nВторой список полученный через LINQ:");
            foreach (Person dimons in dimons2)
            {
                Console.WriteLine(dimons.Firstname + " " + dimons.Lastname);
            }

            people.Add(new Person("Дима", "Второй"));
            
            Console.WriteLine("\nПосле добавление третьего человека с именем Дима в основной список фильтр отображает изменения:");
            foreach (Person dimons in dimon)
            {
                Console.WriteLine(dimons.Firstname + " " + dimons.Lastname);
            }


            Console.WriteLine("\nА вот отдельный список полученный через LINQ нет:");
            foreach (Person dimons in dimons2)
            {
                Console.WriteLine(dimons.Firstname + " " + dimons.Lastname);
            }


            Console.WriteLine("\nДва фильтра одновременно имя = Дима + фамилия = Второй:");
            IEnumerable<Person> second = dimon.Where(m => m.Lastname == "Второй");
            foreach(Person p in second)
            {
                Console.WriteLine(p.Firstname + " " + p.Lastname);
            }
            Person per = people.Where(m => m.Firstname == "Дима").First(); //Вернёт первый экземпляр класса в списке для которого выполняется условие если условие может не выполниться юзать FirstOrDefault которое если что вернёт null вместо ошибки
            Console.WriteLine("\nПервый человек в основнмо списке с именем Дима:");
            Console.WriteLine(per.Firstname + " " + per.Lastname);
        }
    }
}
