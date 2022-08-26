using bytebank_ADM.AcessoExterno;
using bytebank_ADM.ParceiroComercial;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            bool UsuAutenticado = usuario.Autenticar(senha);
            if (UsuAutenticado == true)
            {
                Console.WriteLine("Usuário logado!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

        //public bool Logar(GerenteDeContas diretor, string senha)
        //{
        //    if (diretor.Autenticar(senha) == true)
        //    {
        //        Console.WriteLine("Usuário logado!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta!");
        //        return false;
        //    }
        //}

        public bool Logar(ParComercial usuario, string senha)
        {
            bool UsuAutenticado = usuario.Autenticar(senha);
            if (UsuAutenticado == true)
            {
                Console.WriteLine("Usuário logado!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

        public bool Logar(EmpresaTerceirizada empresa, string senha)
        {
            bool UsuarioAutenticado = empresa.Autenticar(senha);
            if(UsuarioAutenticado == true)
            {
                Console.WriteLine("Empresa Logada com sucesso.");
                return true;
            }

            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
