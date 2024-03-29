﻿namespace MovieMaker.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime MovieTime { get; set; }
        public DateTime StartFilming { get; set; }
        public DateTime EndFilming { get; set; }
        public decimal Budget { get; set; }
        public Director Director { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
