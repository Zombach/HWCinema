namespace HWCinema.CoreFolders
{
    public class FilmData
    {
        /// <summary>
        /// Movie name
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Movie time is running
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Priority film
        /// </summary>
        public bool IsPriority { get; set; }
        /// <summary>
        /// Number of repetitions
        /// </summary>
        public int RepeatCount { get; set; }
        public bool RepeatOtherHalls { get; set; }
 
        public FilmData(string name, int time, bool isPriority = false)
        {
            Name = name;
            Time = time;
            IsPriority = isPriority;
            RepeatCount = 0;
            RepeatOtherHalls = false;
        }
    }
}
