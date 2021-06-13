using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedListLibrary
{
    public interface IClosedList<T> : IList<T>
    {
        /// <summary>
        /// Перемещение указателя на следющий элемент
        /// </summary>
        /// <param name="step">шаг</param>
        void MoveNext(int step = 1);
        /// <summary>
        /// Перемещение указателя на предыдущий элемент
        /// </summary>
        /// <param name="step">шаг</param>
        void MoveBack(int step = 1);
        /// <summary>
        /// Элемент с нулевым индексом
        /// </summary>
        T Head { get; }
        /// <summary>
        /// Возвращает текущий элемент
        /// </summary>
        T Current { get; }
        /// <summary>
        /// Возвращает предыдущий элемент
        /// </summary>
        T Previous { get; }
        /// <summary>
        /// Возвращает следующий элемент
        /// </summary>
        T Next { get; }
        /// <summary>
        /// Событие которое срабатывает при прохождении указателя через нулевой элемент
        /// </summary>
        event EventHandler<T> HeadReached;
    }
}
