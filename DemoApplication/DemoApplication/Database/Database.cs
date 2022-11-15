using System;
using DemoApplication.Database.Models;

namespace DemoApplication.Database
{
    public class DatabaseAccess
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Contact> Contacts { get; set; } = new List<Contact>(); //Strong retype Prinsipi
    }

    public class TablePKAutoIncrement
    {
        private static int contactCounter;

        public static int ContactCounter //default dəyər sıfırdır. 1-dən oxumağa başlayacaq
        {
            get { return contactCounter++; }
        }
    }
}