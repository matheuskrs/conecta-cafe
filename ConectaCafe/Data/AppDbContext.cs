using ConectaCafe.Models;
using Microsoft.EntityFrameworkCore;

namespace ConectaCafe.Data;
//Quem sabe quem é o alvo da conexão é o AppDbContext, e quem faz a conexão é o DbContext
public class AppDbContext : DbContext //Seu pai já sabe fazer algo, ele vai te ensinar, herança na programação, a classe fará o preciso usando quem já sabe (DbContext).
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //ctor
    {}

    public DbSet<Avaliacao> Avaliacoes { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogTag> BlogTags { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Configuracao> Configuracoes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // FluentAPI
        #region muitos para muitos do BlogTag
            
        #endregion
    }
}