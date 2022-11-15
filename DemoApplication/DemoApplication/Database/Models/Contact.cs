using System;
namespace DemoApplication.Database.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public Contact(int id, string name, string email, string phone, string message)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Message = message;
        }
    }
}