using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        protected internal override double getBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
