using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Usuários
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cadastrar novoCadastro = new Cadastrar();

            novoCadastro.TelaInicial();


            Console.ReadLine();
        }
    }
}
