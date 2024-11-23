using System;
using FluentValidation;

namespace GerenciadorApi.ViewModels
{
    public abstract class ModeloBaseVM
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}