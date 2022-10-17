using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contato
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contato(string n, string e, string p)
        {
            Name = n;
            Email = e;
            Phone = p;
        }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
