using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OficinaMecanica.Models
{
    public class Estimate
    {
        
        public int Id { get; set; }
        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Client { get; set; }
        [Display(Name = "Data e Hora")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public DateTime Date { get; set; }
        [Display(Name = "Vendedor")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Seller { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Description { get; set; }
        [Display(Name = "Valor")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(0.0,double.MaxValue,ErrorMessage ="O valor do orçamento não pode ser negativo")]
        public double Value { get; set; }
    }
}
