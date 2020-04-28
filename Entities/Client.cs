using System;
using System.Security.Authentication.ExtendedProtection;

namespace Orders_122.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() //faltou no meu codigo
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }

    }
}
