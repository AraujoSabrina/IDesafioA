using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDesafioA
{
    public class Estudante
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Definir(int Identifica, string Nome, string Senha)
        {
            Id = Identifica;
            Username = Nome;
            Password = Senha;
        }
        public Estudante GetEstudante()
        {
             return new Estudante { Id = Id, Username = Username, Password = Password };

        }
    }
}
