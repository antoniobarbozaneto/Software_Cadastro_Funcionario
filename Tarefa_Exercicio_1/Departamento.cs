using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Exercicio_1
{
    class Departamento
    {
        public int Id;
        public string Nome_Dep;

        public Departamento()
        {

        }

        public void Incluir(string Id, string Nome_Dep)
        {
            this.Id = Convert.ToInt32(Id);
            this.Nome_Dep = Nome_Dep;
        }
    }
}
