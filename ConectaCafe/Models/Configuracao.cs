using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConectaCafe.Models
{
    [Table("Configuracao")]
    public class Configuracao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Horário de Funcionamento")]
        [StringLength(200, ErrorMessage = "O horário de funcionamento deve ter menos de 200 caracteres.")]
        public string HorarioFuncionamento { get; set; }
        [StringLength(20, ErrorMessage = "O número de telefone deve conter menos que 20 caracteres.")]
        public string Telefone { get; set; }
    }
}