using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqCards
{

    internal class Program
    {
        static IEnumerable<string> Suits()
        {
            yield return "крести";
            yield return "бубны";
            yield return "червы";
            yield return "пики";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "двойка";
            yield return "тройка";
            yield return "четвёрка";
            yield return "пятёрка";
            yield return "шестёрка";
            yield return "семёрка";
            yield return "восьмёрка";
            yield return "девятка";
            yield return "десятка";
            yield return "валет";
            yield return "дама";
            yield return "король";
            yield return "туз";
        }
        static void Main(string[] args)
        {

            var startingDeck = from s in Suits() //Несколько фром дают запрос SelectMany и сочетание каждого первого элемента с каждым вторым
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            //var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank })); //Можно было записать и так

            foreach (var card in startingDeck)
            {
                Console.WriteLine("Масть: {0,-8} Ранг: {1,-10}",card.Suit,card.Rank);
            }

            var top = startingDeck.Take(26); //Берёт 26 первых элементов
            var bottom = startingDeck.Skip(26); //Берёт 26 последних элементов
            var shuffle = top.InterleaveSequenceWith(bottom); //Одна итерация перемешивания

            Console.WriteLine("\n После одного перемешивания: ");
            Console.WriteLine("");

            foreach (var card in shuffle)
            {
                Console.WriteLine("Масть: {0,-8} Ранг: {1,-10}", card.Suit, card.Rank);
            }

        }
    }
}
