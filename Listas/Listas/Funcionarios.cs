using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas {
    class Funcionarios {

        public int Id { get; set; }
        public String Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void increaseSalario(double porcentagem) {
            double x;
            x = (Salario * porcentagem) / 100;
            Salario += x;
        }

        public override string ToString() {
            return "ID: " + Id + " Nome: " + Nome + " Salario: " + Salario;
        }
    }
}
