using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Primeiro_Projeto {
    class Program {
        static void Main(string[] args) {

            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1, preco2, medida;
            preco1 = 2100.0;
            preco2 = 650.50;
            medida = 53.234567;

            Console.WriteLine("Produtos: /n" + produto1 + ", Cujo preço é R$"+ preco1);
            Console.WriteLine(produto2 + ", Cujo preço é R$"+ preco2);
            Console.WriteLine("Registro: "+ idade+" anos de idade, codigo "+codigo+" e genero: "+genero);
            Console.WriteLine("Medida com oito casas decimais: "+ medida.ToString("F8"));
            Console.WriteLine("Arredondado: "+medida.ToString("F3"));
            Console.WriteLine("Serapador decimal Invariant culture: "+ medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
