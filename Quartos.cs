using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace s6exer
{
    internal class Quartos
    {

        public string Nome { get; set; }

        public string Email { get; set; }


        public Quartos(string nome, string email) {
        
        Nome = nome;
        Email = email;      
        }

        public override string ToString()
        {

            return Nome + ", " + Email;
        }






    }
}
