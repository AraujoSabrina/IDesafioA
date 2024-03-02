// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDesafioA
{
    public class LoginManager()
    {
        
        Estudante estuda = new Estudante();
        public void Login()
        {
            if(estuda.Id == estuda.GetEstudante().Id)
            {
                Console.WriteLine("Sucesso");
            }
        }

    }
}
