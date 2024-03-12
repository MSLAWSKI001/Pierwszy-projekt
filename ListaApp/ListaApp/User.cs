using System;
using System.Collections.Generic;
using System.Text;

namespace ListaApp
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static List<User> UsersList { get; set; }
    }
    
}
