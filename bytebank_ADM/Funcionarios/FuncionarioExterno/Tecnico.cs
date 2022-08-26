using bytebank_ADM.AcessoExterno;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios.FuncionarioExterno
{
    public class Tecnico : EmpresaTerceirizada, IAutenticavel
    {
        public Tecnico(string cpf) : base(cpf, 1350)
        {
            Console.WriteLine("Terceirizado adicionado com sucesso.");
        }

        public bool Autenticar(string senha)
        {
            return Senha == Senha;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.19;
        }

        public override double getBonificacao()
        {
            return Salario * 0.09;
        }
    }
}
