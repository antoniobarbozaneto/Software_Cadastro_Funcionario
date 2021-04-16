using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Exercicio_1
{
    class Salario
    {
        public string Data_Pag;
        public double Valor_Salario;

        public Salario()
        {

        }

        public void Incluir(string Data_Pag, string Valor_Salario)
        {
            this.Data_Pag = Data_Pag;
            this.Valor_Salario = Convert.ToDouble(Valor_Salario);
        }
    }
}
