using employee_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_MANEGER
{
    internal class Estagiario : Funcionario, IBeneficios
    {
        public  decimal ValeTransporte { get; set; }

        public override decimal CalcularSalario()
        {
            return Salario;
        }
        public decimal CalcularBeneficios()
        {
            return ValeTransporte;
        }
    }
}
