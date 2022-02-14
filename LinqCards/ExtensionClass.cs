using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCards
{
    public static class ExtensionClass
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second) //Фасует карты так: 1 от начала 1 от середины, 2 от начала 2 от середины и так все 26.
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext()) //Будет выполняться пока в обоих коллекциях возможно перемещение к следующему элементу
            {
                yield return firstIter.Current; //Возвращает текущий элемент не прерывая цикл
                yield return secondIter.Current; //Возвращает текущий элемент не прерывая цикл
            }
        }
       
    }
}
