using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace APLUS.Models
{
    [Table("Project1")]
    public class ProjectModel
    {
        public ProjectModel(string name, string description, string telephoneNumber, string email, string address)
        {
            Name = name;
            Description = description;
            TelephoneNumber = telephoneNumber;
            Email = email;
            Address = address;
        }

        public ProjectModel()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
