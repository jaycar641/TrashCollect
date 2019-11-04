using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollectorProject.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId;

        public string firstName;
        public string lastName;
        public int zipcode;
    }
}