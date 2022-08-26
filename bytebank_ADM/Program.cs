using bytebank_ADM.Funcionarios;
using bytebank_ADM.Funcionarios.FuncionarioExterno;
using bytebank_ADM.ParceiroComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

SistemaInterno();

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Auxiliar luiz = new Auxiliar("123456789-00");
    luiz.Nome = "Luiz";

    Desenvolvedor felipe = new Desenvolvedor("987654321-55");
    felipe.Nome = "Felipe";

    Designer fernando = new Designer("753159852-44");
    fernando.Nome= "Fernando";

    Diretor lusca = new Diretor("624846957-77");
    lusca.Nome = "Lusca";
  
    GerenteDeContas armando = new GerenteDeContas("487954236-65");
    armando.Nome = "Armando";

    Tecnico tercerizada = new Tecnico("678.347.321-98");
    tercerizada.Nome = "Cicero";
  
    gerenciador.Registrar(luiz);
    gerenciador.Registrar(felipe);
    gerenciador.Registrar(fernando);
    gerenciador.Registrar(lusca);
    gerenciador.Registrar(armando);
    gerenciador.Registrar(tercerizada);

    Console.WriteLine($"Bonificação do {luiz.Nome}: {luiz.getBonificacao()}");
    Console.WriteLine($"Bonificação do {felipe.Nome}: {felipe.getBonificacao()}");
    Console.WriteLine($"Bonificação do {fernando.Nome}: {fernando.getBonificacao()}");
    Console.WriteLine($"Bonificação do {lusca.Nome}: {lusca.getBonificacao()}");
    Console.WriteLine($"Bonificação do {armando.Nome}: {armando.getBonificacao()}");
    Console.WriteLine($"Bonificação do {tercerizada.Nome}: {tercerizada.getBonificacao()}");

    Console.WriteLine($"\nTotal de bonificação: {gerenciador.getBonificacao()}\n");
}

void SistemaInterno()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor Felipe = new Diretor("123.456.789-99");
    Felipe.Nome = "Felipe";
    Felipe.Senha = "128";

    GerenteDeContas Lusca = new GerenteDeContas("456.789.123-14");
    Lusca.Nome = "Felipe";
    Lusca.Senha = "123";

    ParComercial parceiro = new ParComercial();
    parceiro.Senha = "555";

    Tecnico tecnico = new Tecnico("784.624.963-45");
    tecnico.Nome = "Julio";
    tecnico.Senha = "951";

    sistema.Logar(Felipe, "128");
    sistema.Logar(Lusca, "123");
    sistema.Logar(parceiro, "555");
    sistema.Logar(tecnico, "951");

    Console.WriteLine("\n---------\n");
}

Console.ReadKey();