using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace employee_manager
{
    internal abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal Salario { get; set; }

        public abstract decimal CalcularSalario();
    }
}
