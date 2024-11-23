
namespace GerenciadorApi.ViewModels
{
    public class ErroVM
    {
        public ErroVM(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; set; }
    }
}