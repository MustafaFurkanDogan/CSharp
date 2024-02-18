﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        //propert
        public int Id { get; set; }
        public string LastName { get; set; }

        private string _firstName;
        public string FirstName
        {
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }

        }
        public string City { get; set; }

    }
}
