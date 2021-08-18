using System;
using System.Collections.Generic;
using System.Text;

namespace LoginScreen.Models
{
    class Token
    {
        // Creating varible that get variables and set values 
        public int Id { get; set; }
        public string accessToken { get; set; }
        public string errorDescription { get; set; }

        // Creating an expire date using the DateTime function
        public DateTime expiryDate { get; set; }

        public Token() { }
    }
}
