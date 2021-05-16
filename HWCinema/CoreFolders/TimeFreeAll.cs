using System.Collections.Generic;

namespace HWCinema.CoreFolders
{
    public class TimeFreeAll
    {
        /// <summary>
        /// Вариации расписаний
        /// </summary>
        public List<int> Variants;
        /// <summary>
        /// Сортированный список
        /// </summary>
        public List<int> Sorts;
        /// <summary>
        /// Уникальные фильмы(без повторов самих фильмов)
        /// </summary>
        public List<int> Uniques;
        /// <summary>
        /// Список с приоритетами
        /// </summary>
        public List<int> Priorities;
        /// <summary>
        /// Без повторов в залах
        /// </summary>
        public List<int> NoRepeats;
        /// <summary>
        /// Уникальные приоритетные
        /// </summary>
        public List<int> UniquesPriorities;
        /// <summary>
        /// Уникальные без повторов в залах
        /// </summary>
        public List<int> UniquesNoRepeats;
        /// <summary>
        /// Приоритетные без повторов в залах
        /// </summary>
        public List<int> PrioritiesNoRepeats;

        public TimeFreeAll()
        {
            Variants = new List<int>();
            Sorts = new List<int>();
            Uniques = new List<int>();
            Priorities = new List<int>();
            NoRepeats = new List<int>();
            UniquesPriorities = new List<int>();
            UniquesNoRepeats = new List<int>();
            PrioritiesNoRepeats = new List<int>();
        }
    }
}