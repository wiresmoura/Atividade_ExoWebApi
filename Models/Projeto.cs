using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Projeto.cs Modelo do sistema. Nela,  encontramos os atributos da entidade Projeto.

namespace Exo.WebApi.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string NomeDoProjeto { get; set; }
        public string Area { get; set; }
        public bool Status { get; set; }
    }
}