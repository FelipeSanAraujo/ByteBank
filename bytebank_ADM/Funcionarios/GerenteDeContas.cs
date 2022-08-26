using bytebank_ADM.Funcionarios.FuncionarioUtilitarios;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Gerente de contas cadastrado.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
