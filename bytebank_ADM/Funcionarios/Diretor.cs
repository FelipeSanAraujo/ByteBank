using bytebank_ADM.Funcionarios.FuncionarioUtilitarios;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Diretor cadastrado.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; 
        }

        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
