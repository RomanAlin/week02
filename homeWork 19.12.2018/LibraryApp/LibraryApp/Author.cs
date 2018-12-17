using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Author
    {
        public Author(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            if(email.Contains(".") && email.Contains("@"))
            {
                   this.Email= email;
            }
            else
            {
                Console.WriteLine($"your email {email}is not valid");
            }
        }
        
        public string Name { get; set; }
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Author {Name} & {Email}");
        }


    }
}
