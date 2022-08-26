using bytebank_ADM.Funcionarios.FuncionarioUtilitarios;

namespace bytebank_ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
