using System;
using System.IO;

namespace FunçãoCRSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            StreamWriter arquivo = new StreamWriter(@"c:\Gugu\clientes.rtf",true);
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            arquivo.WriteLine("Nome: "+nome+"- Data Cadastro: "+data());
            arquivo.Close();
        }

        /// <summary>
        /// A função data é responsável por pegar a data do sistema.
        /// </summary>
        /// <returns>Retorna a data do sistema</returns>
        static string data(){
            return DateTime.Now.ToString();

        
        }

        

    }
}
