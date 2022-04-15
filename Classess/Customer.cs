using System;
using System.Collections.Generic;
using System.Text;

namespace Classess
{
    class Customer
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        
        private string _firstName;
        public string FirstName
        {

            get
            {
                return "Mr. " + _firstName;
            }
            set
            { _firstName = value; }
        }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }
}
