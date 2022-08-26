using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.AcessoExterno
{
    public abstract class EmpresaTerceirizada : Funcionario, IAutenticavel
    {
        public EmpresaTerceirizada(string cpf, int salario) : base(cpf, salario)
        {

        }
        private string _cnpj;
        public string Cnpj 
        {
            private get
            {
                return _cnpj;
            }
            set
            {
                _cnpj = value;
            } }
        public string Senha { get; set; }
        public bool VerificarCnpj(string cnpj)
        {
            return _cnpj == cnpj;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
