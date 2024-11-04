using Microsoft.EntityFrameworkCore; 
 
     public class ProdutoContext : DbContext 
     { 
         public DbSet<Produto> Produtos { get; set; } 
 
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
         { 
             optionsBuilder.UseInMemoryDatabase("TarefasDB"); 
         } 
     }