using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Usuários
{
    public class Cadastrar
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<Cadastrar> list = new List<Cadastrar>();

        public void TelaInicial()
        {
            int op = 0;
            while (op != 5)
            {
                Console.WriteLine("Bem vindo ao cadastro");
                Console.WriteLine("===============\n");
                Console.WriteLine("1 - Cadastrar\n2 - Exibir cadastro\n3 - Editar cadastro\n4 - Excluir cadastro\n5 - Sair\n");

                try
                {
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 5:
                            break;

                        case 1:
                            Cadastro();
                            continue;

                        case 2:
                            Exibir();
                            break;

                        case 3:
                            Editar();
                            break;

                        case 4:
                            Excluir();
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;



                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }


        }

        private void Cadastro()
        {
            try
            {
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                Cadastrar usuario = new Cadastrar();

                usuario.Nome = nome;
                usuario.Idade = idade;

                list.Add(usuario);

                Console.WriteLine("\nParabens cadastro realizado com sucesso\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }
        private void Exibir()
        {

            Console.WriteLine("Usuários cadastrados abaixo: \n\n");

            foreach (var usuario in list)
            {
                Console.WriteLine(usuario.Nome);
                Console.WriteLine(usuario.Idade);
                Console.WriteLine("==================\n");


            }
        }

        private void Editar()
        {
            try
            {
                Exibir();


                Console.WriteLine("\nDigite o nome do usuário que deseja alterar o nome:");
                string nomeEditavel = Console.ReadLine();
                Cadastrar usuarioEditavel = list.FirstOrDefault(e => e.Nome == nomeEditavel);
                Console.WriteLine("==================================================\n");
                Console.WriteLine("Digite o novo nome de usuário");

                if (usuarioEditavel != null)
                {
                    usuarioEditavel.Nome = Console.ReadLine();
                    Console.WriteLine("Digite uma nova idade");
                    usuarioEditavel.Idade = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Editado com sucesso\n");

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nUsuário não encontrado\n");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }







        }

        private void Excluir()
        {
            Console.WriteLine("\nDigite o nome do usuário que deseja alterar o nome");
            try
            {
                string nomeExcluido = Console.ReadLine();
                if (nomeExcluido != null)
                {
                    Cadastrar usuarioExcluido = list.FirstOrDefault(e => e.Nome == nomeExcluido);
                    list.Remove(usuarioExcluido);

                    Console.Clear();

                    Console.WriteLine("Usuário Removido com sucesso\n");
                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("\nUsuário não encontrado\n");
                }

            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }


        }
    }
}
