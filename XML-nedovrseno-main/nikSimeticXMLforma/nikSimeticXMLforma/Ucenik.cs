using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticXMLforma
{
    class Ucenik
    {
        string ime;
        string prezime;
        string razred;
        string email;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Razred { get => razred; set => razred = value; }
        public string Email { get => email; set => email = value; }

        public Ucenik(string ime, string prezime, string razred, string email)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;
            this.email = email;
        }
        public Ucenik()
        {

        }
    }
}
