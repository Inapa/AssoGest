using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AssoGest.Models
{
    public class Associado
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} e requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Name { get; set; }


        [EmailAddress(ErrorMessage = "Por favor digete o email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data de adesao")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EntryDate { get; set; }

        [Required(ErrorMessage = "{0} e requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} o tamanho deve ser entre {2} e {1}")]
        public string Morada { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }


    }
}
