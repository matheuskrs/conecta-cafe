using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConectaCafe.Models
{
    [Table("Avaliacao")]
    public class Avaliacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "É necessário inserir o nome da pessoa.")]
        [StringLength(60, ErrorMessage = "O nome tem que possuir menos que 60 caracteres.")]
        public string Pessoa { get; set; }
        [Required(ErrorMessage = "É necessário informar o título.")]
        [Display(Name = "Título")]
        [StringLength(100, ErrorMessage = "O título tem que ser menor do que 60 caracteres.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Insira o texto da avaliação.")]
        [StringLength(500, ErrorMessage = "O texto tem que possuir menos que 500 caracteres.")]
        public string Texto { get; set; }
        [Required(ErrorMessage = "Insira uma nota válida.")]
        [Column(TypeName = "decimal(1,0)")]    
        public decimal Nota { get; set; }
        [Display(Name = "Data da Avaliação")]
        [DataType(DataType.Date)]
        public DateTime DataAvaliacao { get; set; }
    }
}