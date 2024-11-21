using MeuProjeto.Models; 
using System.Data.SqlClient; 
using Microsoft.Data.SqlClient; 
using System; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.WriteLine("Iniciando conexão com BD..."); 
        using(var contexto = new ProdutoContext()) 
        { 
            Console.WriteLine("Inserindo dados"); 
            contexto.Produtos.Add(new Produto{ Id = 100, Nome = "Prego" }); 
            contexto.Produtos.Add(new Produto{ Id = 200, Nome = "Parafuso"}); 
            contexto.SaveChanges(); 
            } 
    } 
} 
