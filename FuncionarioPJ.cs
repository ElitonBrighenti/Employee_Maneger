using employee_manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEE_MANEGER
{
    internal class FuncionarioPJ : Funcionario
    {
        public int HorasTrabalhadas { get; set; }
        public decimal ValorHora { get; set; }


        public override decimal CalcularSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }

    }
}
