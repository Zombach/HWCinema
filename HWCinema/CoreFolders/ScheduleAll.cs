using System.Collections.Generic;

namespace HWCinema.CoreFolders
{
    public class ScheduleAll
    {
        /// <summary>
        /// Вариации расписаний
        /// </summary>
        public List<List<FilmData>> Variants;
        /// <summary>
        /// Сортированный список
        /// </summary>
        public List<List<FilmData>> Sorts;
        /// <summary>
        /// Уникальные фильмы(без повторов самих фильмов)
        /// </summary>
        public List<List<FilmData>> Uniques;
        /// <summary>
        /// Список с приоритетами
        /// </summary>
        public List<List<FilmData>> Priorities;
        /// <summary>
        /// Без повторов в залах
        /// </summary>
        public List<List<FilmData>> NoRepeats;
        /// <summary>
        /// Уникальные приоритетные
        /// </summary>
        public List<List<FilmData>> UniquesPriorities;
        /// <summary>
        /// Уникальные без повторов в залах
        /// </summary>
        public List<List<FilmData>> UniquesNoRepeats;
        /// <summary>
        /// Приоритетные без повторов в залах
        /// </summary>
        public List<List<FilmData>> PrioritiesNoRepeats;
        /// <summary>
        /// Список фильмов, для составления расписания
        /// </summary>
        public List<FilmData> Bases;

        public ScheduleAll()
        {
            Variants = new List<List<FilmData>>();
            Sorts = new List<List<FilmData>>();
            Uniques = new List<List<FilmData>>();
            Priorities = new List<List<FilmData>>();
            NoRepeats = new List<List<FilmData>>();
            UniquesPriorities = new List<List<FilmData>>();
            UniquesNoRepeats = new List<List<FilmData>>();
            PrioritiesNoRepeats = new List<List<FilmData>>();
            Bases = new List<FilmData>();
        }
    }
}