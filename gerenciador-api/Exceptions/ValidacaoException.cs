using System;
using System.Net;

namespace GerenciadorApi.Exceptions
{
    public class ValidacaoException : Exception
    {
        public HttpStatusCode Codigo { get; set; }
        public string Mensagem { get; set; }
        public ValidacaoException(string mensagem) : base(mensagem){
            Mensagem = mensagem;
            Codigo = HttpStatusCode.BadRequest;
        }
    }
}