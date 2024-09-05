using employee_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_MANEGER
{
    internal class FuncionarioCLT : Funcionario, IBeneficios
    {
        public decimal ValeTransporte { get; set; }
        public decimal ValeRefeicao { get; set; }

        public override decimal CalcularSalario()
        {
            return Salario;
        }
        public decimal CalcularBeneficios()
        {
            return ValeRefeicao + ValeTransporte;
        }
    }
}
