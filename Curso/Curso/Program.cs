using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso {
    class Exercicios {
        static void Main(string[] args) {

            Console.WriteLine("NOME COMPLETO: ");
            string nome = Console.ReadLine();
            Console.WriteLine("QUANTOS QUARTOS TEM NA SUA CASA: ");
            
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("PREÇO DO PRODUTO: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("ULTIMO NOME, IDADE E ALTURA: ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2]);

            Console.WriteLine("#############################");
            Console.WriteLine("INFORMAÇOES");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(ultimoNome+" "+idade+" "+altura.ToString("F2"));
        





        }
    }
}
