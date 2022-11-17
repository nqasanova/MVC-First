﻿using System;
namespace DemoApplication.Database.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}