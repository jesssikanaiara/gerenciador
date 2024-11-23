using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GerenciadorApi.Models;

namespace GerenciadorApi.ViewModels
{
    public class ClienteVM : ModeloBaseVM
    {
       public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
    }
    
}