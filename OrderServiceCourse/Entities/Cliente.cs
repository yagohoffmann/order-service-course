﻿using System;
namespace OrderServiceCourse.Entities
{
    class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Cliente()
        {

        }
        public Cliente(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
