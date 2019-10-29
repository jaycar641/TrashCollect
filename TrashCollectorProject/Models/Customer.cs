using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        //Customize User Registration with adding username and Role in article

        [Key]
        public int Id { get; set; }

        public string firstName;
        public string lastName;
        public string streetAddress;
        public string city;
        public string state;
        public int zipcode;
        public string pickupDay;
        public int balance;
        public int monthlyRate;
        public string startDate;
        public string endDate;
               

    }
}