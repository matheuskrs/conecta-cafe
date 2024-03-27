using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConectaCafe.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "É necessário inserir um nome.")]
        [StringLength(30, ErrorMessage = "Insira um nome menor do que 30 caracteres para a tag.")]
        public string Nome { get; set; }
        public ICollection<BlogTag> BlogTags { get; set; }
    }
}