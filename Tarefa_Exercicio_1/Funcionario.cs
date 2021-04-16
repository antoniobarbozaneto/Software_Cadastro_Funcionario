using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Exercicio_1
{
    class Funcionario
    {
        public string Nome;
        public string Cpf;

        public Salario Sal;
        public Departamento Dep;
        public Funcionario()
        {
            Sal = new Salario();
            Dep = new Departamento();
        }

        public void Incluir(string Nome, string Cpf, string Data_pag, string Valor_salario, string Id, string Nome_Dep)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            Sal.Incluir(Data_pag, Valor_salario);
            Dep.Incluir(Id, Nome);
        }
    }
}
