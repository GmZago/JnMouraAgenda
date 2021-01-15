using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JnMouraAgenda.Models
{
    public class DadosAgenda
    {
        [Key]
        public int IdTelefone { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

    }
}