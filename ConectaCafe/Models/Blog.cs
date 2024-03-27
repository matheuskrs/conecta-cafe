using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConectaCafe.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira um título.")]
        [StringLength(100, ErrorMessage = "Insira um título menor do que 100 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Insira o texto do blog.")]
        [StringLength(500,ErrorMessage = "Insira um texto menor do que 500 caracteres.")]
        public string Texto { get; set; }
        [StringLength(200)]
        public string Foto { get; set; }
        public DateTime DataBlog { get; set; }
        public ICollection<BlogTag> BlogTags { get; set; }
    }
}