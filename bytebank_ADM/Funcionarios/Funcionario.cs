namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int contadorCadastros { get; set; }


        //Encapsulamento: acessando uma propriedade indiretamente através de um método.

        public Funcionario(string cpf, double salario)
        {
            contadorCadastros += 1;
            Console.WriteLine("Funcionario adicionado.");

            this.Salario = salario;
            this.Cpf = cpf;
        }

        public abstract void AumentarSalario();
        public abstract double getBonificacao();
    }
}
