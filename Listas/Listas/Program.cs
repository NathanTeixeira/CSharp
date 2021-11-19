using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionarios serão registrados? ");
            int N = int.Parse(Console.ReadLine());
            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Funcionario: " + (i + 1));
                Console.Write("ID ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionarios(id, nome, salario));

            }

            Console.Write("Digite o ID do funcionario que Terá um aumento: ");
            int procurarId = int.Parse(Console.ReadLine());
            Funcionarios funcionario = list.Find(x => x.Id == procurarId);
            if (funcionario != null) {
                Console.Write("Digite a porcentagem do aumento: ");
                double percent = double.Parse(Console.ReadLine());
                funcionario.increaseSalario(percent);

                Console.WriteLine("Lista Atualizada");
                foreach (Funcionarios obj in list) {
                    Console.WriteLine(obj);
                }
            }
            else {
                Console.WriteLine("ID não existe!!!");
            }



        }
    }
}
