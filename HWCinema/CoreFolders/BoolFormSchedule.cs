namespace HWCinema.CoreFolders
{
    public class BoolFormSchedule
    {
        /// <summary>
        /// Отвечает за отображения лучшего варианта для зала
        /// </summary>
        public bool IsBest { get; set; }

        /// <summary>
        /// Отвечает за отображения сортированных вариантов
        /// </summary>
        public bool IsSort { get; set; }

        /// <summary>
        /// Отвечает за повторы фильмов в расписании
        /// </summary>
        public bool IsNotRepeat { get; set; }

        /// <summary>
        /// Отвечает за отображения уникальных вариантов
        /// </summary>
        public bool IsUnique { get; set; }

        /// <summary>
        /// Отвечает за отображения приоритетных  вариантов
        /// </summary>
        public bool IsPriority { get; set;}

        public BoolFormSchedule()
        {
            IsNotRepeat = false;
            IsBest = false;
            IsSort = false;
            IsUnique = false;
            IsPriority = false;
        }
    }
}