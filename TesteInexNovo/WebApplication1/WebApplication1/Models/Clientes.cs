using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        public int Id { get; set; }
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        [Display(Name = "RazaoSocial")]
        public string RazaoSocial { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Display(Name = "Pais")]
        public string Pais { get; set; }
    }
}

