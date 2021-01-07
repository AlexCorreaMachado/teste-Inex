using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    
    public class Paises
    {
        public int Id { get; set; }
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
