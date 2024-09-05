using employee_manager;

namespace EMPLOYEE_MANEGER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            FuncionarioPJ funcionarioPJ = new FuncionarioPJ()
            {
                Nome = "Eliton",
                CPF = "10246727942",
                HorasTrabalhadas = 12,
                ValorHora = 50,

            };
            funcionario.Add(funcionarioPJ);

            FuncionarioCLT funcionarioCLT = new FuncionarioCLT()
            {
                Nome = "Eliton",
                CPF = "10246727942",
                ValeTransporte = 150,
                ValeRefeicao = 250
            };
            funcionario.Add(funcionarioPJ);
        }
    }
}
