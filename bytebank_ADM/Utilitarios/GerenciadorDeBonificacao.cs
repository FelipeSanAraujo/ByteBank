using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
