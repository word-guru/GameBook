﻿namespace GameBook.Lib
{
    public record Game
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string GenreName { get; set; }
    }
}