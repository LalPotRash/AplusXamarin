using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplus.Models
{
    [Table("Project1")]
    public class Project
    {
        public Project(string name, string description, string telephoneNumber1, string email, string address)
        {
            Name = name;
            Description = description;
            TelephoneNumber1 = telephoneNumber1;
            Email = email;
            Address = address;
        }

        public Project()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
